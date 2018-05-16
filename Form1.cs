using CSCore.CoreAudioAPI;
using CSCore.SoundIn;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;

namespace RealtimeWave
{
    public partial class Form1 : Form
    {
        public Color StaticColor = Color.Red;
        public float ColorFadeSpeedMultiplier = 2;
        public float HeightMultiplier = 2;
        public int Points = 512;

        private int _bufferSize = (int)Math.Pow(2, 11); // must be a multiple of 2

        private WasapiLoopbackCapture _capture;

        private BufferedWaveProvider _waveProvider;

        private Color _color;
        private TimeSpan _renderTiming;

        private double _hueAngle;
        private float _tension = 0.5f;

        private float[] _waves;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _renderTiming = TimeSpan.FromMilliseconds(1000 / 60.0);

            var enu = new MMDeviceEnumerator();

            var device = enu.GetDefaultAudioEndpoint(DataFlow.Render, Role.Console);

            _capture = new WasapiLoopbackCapture(0, device.DeviceFormat, ThreadPriority.Normal);

            _capture.DataAvailable += DataAvailable;
            _capture.Initialize();
            _capture.Start();

            _waveProvider = new BufferedWaveProvider(new WaveFormat(device.DeviceFormat.SampleRate, device.DeviceFormat.BitsPerSample, device.DeviceFormat.Channels));

            new Thread(() =>
            {
                while (true)
                {
                    var time = DateTime.Now;

                    if (IsHandleCreated && Visible)
                    {
                        FixedUpdate();

                        var waves = GetWaves();

                        if (waves != null && waves.Length > 0)
                        {
                            _waves = waves;

                            BeginInvoke(new MethodInvoker(() =>
                            {
                                var p = PointToClient(Cursor.Position);

                                panel2.Visible = panel2.Enabled = p.X > panel2.Location.X - 5 && p.Y > panel2.Location.Y && p.X < ClientSize.Width && p.Y < ClientSize.Height;

                                Refresh();
                            }));
                        }
                    }

                    var t = _renderTiming - (DateTime.Now - time);

                    Thread.Sleep(t > TimeSpan.Zero ? t : TimeSpan.Zero);
                }
            })
            { IsBackground = true }.Start();
        }

        private void DataAvailable(object sender, DataAvailableEventArgs e)
        {
            _waveProvider.AddSamples(e.Data, 0, e.ByteCount);
        }

        private float[] GetWaves()
        {
            if (_waveProvider == null || _waveProvider.BufferedBytes == 0)
                return null;

            // read the bytes from the stream
            var frameSize = Math.Min(_bufferSize, _waveProvider.BufferedBytes);
            var frames = new byte[frameSize];

            _waveProvider.Read(frames, 0, frameSize);

            int bytesPerPoint = _capture.WaveFormat.BitsPerSample / 8;
            Int32[] values = new Int32[frames.Length / bytesPerPoint];

            if (values.Length < Points)
                Points = values.Length;

            var step = values.Length / (float)Points;

            List<float> averaged = new List<float>();

            for (var i = 0f; i < values.Length; i += step)
            {
                var val = 0f;
                var j = 0;

                for (; j < step && j + i < values.Length; j++)
                {
                    // bit shift the byte buffer into the right variable format
                    byte hByte = frames[(int)i * 2 + 1];
                    byte lByte = frames[(int)i * 2 + 0];

                    val += (short)((hByte << 8) | lByte);
                }

                val /= j; //avg

                var peak = val / _capture.WaveFormat.SampleRate;

                averaged.Add(peak * 100 * HeightMultiplier);
            }

            _waveProvider.ClearBuffer();

            return averaged.ToArray();
        }

        private Color Hue(double angle)
        {
            var rad = Math.PI / 180 * angle;
            var third = Math.PI / 3;

            var red = (int)(Math.Sin(rad) * 127 + 128);
            var green = (int)(Math.Sin(rad + 2 * third) * 127 + 128);
            var blue = (int)(Math.Sin(rad + 4 * third) * 127 + 128);

            return Color.FromArgb(red, green, blue);
        }

        void FixedUpdate()
        {
            if (ColorFadeSpeedMultiplier > 0)
            {
                _hueAngle += 2 * ColorFadeSpeedMultiplier;

                if (_hueAngle > 360)
                    _hueAngle = 0;

                _color = Hue(_hueAngle);
            }
            else
                _color = StaticColor;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _capture.Stop();
            _capture.Dispose();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            if (_waves == null || _waves.Length == 0)
                return;

            var points = new List<PointF>();

            var step = ClientSize.Width / (_waves.Length - 1f);

            for (var i = 0; i < _waves.Length; i++)
            {
                var peak = _waves[i];

                points.Add(new PointF(i * step, peak + ClientSize.Height / 2f));
            }

            e.Graphics.DrawCurve(new Pen(_color, 2), points.ToArray(), _tension);
        }

        private void tbarBoost_Scroll(object sender, EventArgs e)
        {
            HeightMultiplier = tbarBoost.Value;
        }

        private void tbarPoints_Scroll(object sender, EventArgs e)
        {
            Points = (int)Math.Pow(2, tbarPoints.Value);
        }

        private void tbarSmoothing_Scroll(object sender, EventArgs e)
        {
            _tension = tbarSmoothing.Value / 10f;
        }
    }
}