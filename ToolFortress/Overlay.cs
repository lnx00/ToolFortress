using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolFortress
{
    public partial class Overlay : Form
    {
        #region DLL Imports
        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", EntryPoint = "GetWindowLong")]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        public static extern int BitBlt(IntPtr hDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc, int ySrc, int dwRop);

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool GetWindowRect(IntPtr hwnd, out Rect lpRect);

        public struct Rect
        {
            public int Left { get; set; }
            public int Top { get; set; }
            public int Right { get; set; }
            public int Bottom { get; set; }
        }
        #endregion

        private Graphics _gfx;
        private Process _tfProcess;

        private GLabel _plLabel;

        public Overlay()
        {
            InitializeComponent();

            int initialStyle = GetWindowLong(this.Handle, -20);
            SetWindowLong(this.Handle, -20, initialStyle | 0x80000 | 0x20);

            _gfx = this.CreateGraphics();
            _plLabel = CreateLabel("", 20, 400, 16, false);
        }

        public void Enable()
        {
            Process[] tfList = Process.GetProcessesByName("hl2");
            if (tfList.Length >= 1)
            {
                // Get the tf2 process
                _tfProcess = tfList.First();
                Rect tfRect = new Rect();
                GetWindowRect(_tfProcess.MainWindowHandle, out tfRect);

                // Resize this window
                this.Location = new Point(tfRect.Left, tfRect.Top);
                this.Size = new Size(tfRect.Right, tfRect.Bottom);

                CreateLabel("ToolFortress", 20, 60, 22);
            }
        }

        /* Clear the screen */
        public void Clear()
        {
            _gfx.Clear(Color.Lime);
        }

        /* Draw a rect on the screen */
        public void DrawRect(int pX, int pY, int pWidth, int pHeight, Color pColor, int pThickness = 2)
        {
            _gfx.DrawRectangle(new Pen(pColor, pThickness), pX, pY, pWidth, pHeight);
        }

        /* Draw a string on the screen */
        public GLabel CreateLabel(string pText, int pX, int pY, int pSize = 30, bool pBold = true)
        {
            GLabel label = new GLabel
            {
                Location = new Point(pX, pY),
                AutoSize = true,
                Text = pText,
                Font = new Font("Consolas", pSize, (pBold) ? FontStyle.Bold : FontStyle.Regular),
                BackColor = Color.Transparent,
                ForeColor = Color.White
            };

            this.Controls.Add(label);
            return label;
        }

        /* Add a new alert box */
        public void PushAlert(string pTitle, string pMessage, int pTimeout = 5000)
        {
            AlertBox alertBox = new AlertBox(pTitle, pMessage);
            alertBox.Dock = DockStyle.Bottom;

            // This is very stupid, but it works for now...
            this.pnlAlerts.Invoke((MethodInvoker)delegate
            {
                this.pnlAlerts.Controls.Add(alertBox);
                new Thread(() =>
                {
                    Thread.Sleep(pTimeout);
                    this.pnlAlerts.Invoke((MethodInvoker)delegate
                    {
                        this.pnlAlerts.Controls.Remove(alertBox);
                    });
                }).Start();
            });
        }

        public void UpdatePlayerlist(String[] pPlayerlist)
        {
            _plLabel.Text = string.Join("\n", pPlayerlist);
        }

        /* Custom label with optimized gfx */
        public class GLabel : Label
        {
            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);

                e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            }
        }
    }
}
