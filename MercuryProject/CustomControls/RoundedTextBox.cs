﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MercuryProject.CustomControls
{
    [DefaultEvent("_TextChanged")]
    public partial class RoundedTextBox : UserControl
    {
        private Color borderColor = Color.Transparent;
        private Color borderFocusColor = Color.Transparent;
        private int borderSize = 2;
        private bool underlinedStyle = false;
        private bool isFocused = false;

        private int borderRadius = 0;

        private Color placeholderColor = Color.DarkGray;
        private string placeholderText = "";
        private bool isPlaceholder = false;
        private bool isPasswordChar = false;

        public RoundedTextBox()
        {
            InitializeComponent();
        }

        public event EventHandler _TextChanged;

        [Category("MyPropertie")]
        public Color BorderColor { get => borderColor; set { borderColor = value; this.Invalidate(); } }
        [Category("MyPropertie")]
        public Color BorderFocusColor { get => borderFocusColor; set => borderFocusColor = value; }
        [Category("MyPropertie")]
        public int BorderSize { get => borderSize; set { if (value >= 1) { borderSize = value; this.Invalidate(); } } }
        [Category("MyPropertie")]
        public bool UnderlinedStyle { get => underlinedStyle; set { underlinedStyle = value; this.Invalidate(); } }
        [Category("MyPropertie")]
        public bool PasswordChar { get => isPasswordChar; set { isPasswordChar = value; if (!isPlaceholder) textBox.UseSystemPasswordChar = value; } }
        [Category("MyPropertie")]
        public bool Multiline { get => textBox.Multiline; set => textBox.Multiline = value; }
        [Category("MyPropertie")]
        public override Color BackColor { get => base.BackColor; set { base.BackColor = value; textBox.BackColor = value; } }
        [Category("MyPropertie")]
        public override Color ForeColor { get => base.ForeColor; set { base.ForeColor = value; textBox.ForeColor = value; } }
        [Category("MyPropertie")]
        public override Font Font { get => base.Font; set { base.Font = value; textBox.Font = value; if (this.DesignMode) UpdateControlHeight(); } }
        [Category("MyPropertie")]
        public string Texts { get { if (isPlaceholder) return ""; else return textBox.Text; } set { textBox.Text = value; SetPlaceholder(); } }
        [Category("MyPropertie")]
        public int BorderRadius { get => borderRadius; set { if (value >= 0) { borderRadius = value; this.Invalidate(); } } }
        [Category("MyPropertie")]
        public Color PlaceholderColor { get => placeholderColor; set { placeholderColor = value; if (isPlaceholder) textBox.ForeColor = value; } }
        [Category("MyPropertie")]
        public string PlaceholderText { get => placeholderText; set { placeholderText = value; textBox.Text = ""; SetPlaceholder(); } }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;
            if (borderRadius > 1)
            {
                var rectBorderSmooth = this.ClientRectangle;
                var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
                int smoothSize = borderSize > 0 ? borderSize : 1;
                using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    this.Region = new Region(pathBorderSmooth);
                    if (borderRadius > 15) SetTextBoxRoundedRegion();
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
                    if (isFocused) penBorder.Color = borderFocusColor;
                    if (underlinedStyle)
                    {
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                        graph.SmoothingMode = SmoothingMode.None;
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    }
                    else
                    {
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                        graph.DrawPath(penBorder, pathBorder);
                    }
                }
            }
            else
            {
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    this.Region = new Region(this.ClientRectangle);
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                    if (isFocused) penBorder.Color = borderFocusColor;
                    if (underlinedStyle) 
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    else 
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }
            }
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode) 
                UpdateControlHeight();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }
        private void SetTextBoxRoundedRegion()
        {
            GraphicsPath pathText;
            if (Multiline)
            {
                pathText = GetFigurePath(textBox.ClientRectangle, borderRadius - borderSize);
                textBox.Region = new Region(pathText);
            }
            else
            {
                pathText = GetFigurePath(textBox.ClientRectangle, borderSize * 2);
                textBox.Region = new Region(pathText);
            }
            pathText.Dispose();
        }
        private void UpdateControlHeight()
        {
            if (textBox.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox.Multiline = true;
                textBox.MinimumSize = new Size(0, txtHeight);
                textBox.Multiline = false;

                this.Height = textBox.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }
        private void SetPlaceholder()
        {
            if (string.IsNullOrEmpty(textBox.Text) && placeholderText != "")
            {
                isPlaceholder = true;
                textBox.Text = placeholderText;
                textBox.ForeColor = placeholderColor;
                if (isPasswordChar)
                    textBox.UseSystemPasswordChar = false;
            }
        }
        private void RemovePlaceholder()
        {
            if (isPlaceholder && placeholderText != "")
            {
                isPlaceholder = false;
                textBox.Text = "";
                textBox.ForeColor = this.ForeColor;
                if (isPasswordChar)
                    textBox.UseSystemPasswordChar = true;
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null) _TextChanged.Invoke(sender, e);
        }
        private void textBox_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
        private void textBox_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }
        private void textBox_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }
        private void textBox_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();
            RemovePlaceholder();
        }
        private void textBox_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate();
            SetPlaceholder();
        }
    }
}
