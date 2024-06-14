namespace Comandas
{
    partial class FrmCardapioCad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            formCardapioCad = new ReaLTaiizor.Forms.DreamForm();
            btnSair = new ReaLTaiizor.Controls.CyberButton();
            formCardapioCad.SuspendLayout();
            SuspendLayout();
            // 
            // formCardapioCad
            // 
            formCardapioCad.ColorA = Color.FromArgb(40, 218, 255);
            formCardapioCad.ColorB = Color.FromArgb(63, 63, 63);
            formCardapioCad.ColorC = Color.FromArgb(41, 41, 41);
            formCardapioCad.ColorD = Color.FromArgb(27, 27, 27);
            formCardapioCad.ColorE = Color.FromArgb(0, 0, 0, 0);
            formCardapioCad.ColorF = Color.FromArgb(25, 255, 255, 255);
            formCardapioCad.Controls.Add(btnSair);
            formCardapioCad.Dock = DockStyle.Fill;
            formCardapioCad.Location = new Point(0, 0);
            formCardapioCad.Name = "formCardapioCad";
            formCardapioCad.Size = new Size(800, 450);
            formCardapioCad.TabIndex = 0;
            formCardapioCad.TabStop = false;
            formCardapioCad.Text = "dreamForm1";
            formCardapioCad.TitleAlign = HorizontalAlignment.Center;
            formCardapioCad.TitleHeight = 25;
            // 
            // btnSair
            // 
            btnSair.Alpha = 20;
            btnSair.BackColor = Color.Transparent;
            btnSair.Background = true;
            btnSair.Background_WidthPen = 4F;
            btnSair.BackgroundPen = true;
            btnSair.ColorBackground = Color.FromArgb(37, 52, 68);
            btnSair.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnSair.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnSair.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnSair.ColorLighting = Color.FromArgb(29, 200, 238);
            btnSair.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnSair.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnSair.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnSair.Effect_1 = true;
            btnSair.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnSair.Effect_1_Transparency = 25;
            btnSair.Effect_2 = true;
            btnSair.Effect_2_ColorBackground = Color.White;
            btnSair.Effect_2_Transparency = 20;
            btnSair.Font = new Font("Arial", 11F);
            btnSair.ForeColor = Color.FromArgb(245, 245, 245);
            btnSair.Lighting = false;
            btnSair.LinearGradient_Background = false;
            btnSair.LinearGradientPen = false;
            btnSair.Location = new Point(12, 385);
            btnSair.Name = "btnSair";
            btnSair.PenWidth = 15;
            btnSair.Rounding = true;
            btnSair.RoundingInt = 70;
            btnSair.Size = new Size(101, 53);
            btnSair.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnSair.TabIndex = 4;
            btnSair.Tag = "Cyber";
            btnSair.TextButton = "←";
            btnSair.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnSair.Timer_Effect_1 = 5;
            btnSair.Timer_RGB = 300;
            btnSair.Click += btnSair_Click;
            // 
            // FrmCardapioCad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(formCardapioCad);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCardapioCad";
            Text = "FrmCardapioCad";
            TransparencyKey = Color.Fuchsia;
            formCardapioCad.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.DreamForm formCardapioCad;
        private ReaLTaiizor.Controls.CyberButton btnSair;
    }
}