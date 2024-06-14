namespace Comandas
{
    partial class FrmUsuarios
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
            formUsuarios = new ReaLTaiizor.Forms.DreamForm();
            btnVoltar = new ReaLTaiizor.Controls.CyberButton();
            formUsuarios.SuspendLayout();
            SuspendLayout();
            // 
            // formUsuarios
            // 
            formUsuarios.ColorA = Color.FromArgb(40, 218, 255);
            formUsuarios.ColorB = Color.FromArgb(63, 63, 63);
            formUsuarios.ColorC = Color.FromArgb(41, 41, 41);
            formUsuarios.ColorD = Color.FromArgb(27, 27, 27);
            formUsuarios.ColorE = Color.FromArgb(0, 0, 0, 0);
            formUsuarios.ColorF = Color.FromArgb(25, 255, 255, 255);
            formUsuarios.Controls.Add(btnVoltar);
            formUsuarios.Dock = DockStyle.Fill;
            formUsuarios.Location = new Point(0, 0);
            formUsuarios.Name = "formUsuarios";
            formUsuarios.Size = new Size(800, 450);
            formUsuarios.TabIndex = 0;
            formUsuarios.TabStop = false;
            formUsuarios.Text = "dreamForm1";
            formUsuarios.TitleAlign = HorizontalAlignment.Center;
            formUsuarios.TitleHeight = 25;
            // 
            // btnVoltar
            // 
            btnVoltar.Alpha = 20;
            btnVoltar.BackColor = Color.Transparent;
            btnVoltar.Background = true;
            btnVoltar.Background_WidthPen = 4F;
            btnVoltar.BackgroundPen = true;
            btnVoltar.ColorBackground = Color.FromArgb(37, 52, 68);
            btnVoltar.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnVoltar.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnVoltar.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnVoltar.ColorLighting = Color.FromArgb(29, 200, 238);
            btnVoltar.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnVoltar.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnVoltar.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnVoltar.Effect_1 = true;
            btnVoltar.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnVoltar.Effect_1_Transparency = 25;
            btnVoltar.Effect_2 = true;
            btnVoltar.Effect_2_ColorBackground = Color.White;
            btnVoltar.Effect_2_Transparency = 20;
            btnVoltar.Font = new Font("Arial", 11F);
            btnVoltar.ForeColor = Color.FromArgb(245, 245, 245);
            btnVoltar.Lighting = false;
            btnVoltar.LinearGradient_Background = false;
            btnVoltar.LinearGradientPen = false;
            btnVoltar.Location = new Point(12, 385);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.PenWidth = 15;
            btnVoltar.Rounding = true;
            btnVoltar.RoundingInt = 70;
            btnVoltar.Size = new Size(101, 53);
            btnVoltar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnVoltar.TabIndex = 5;
            btnVoltar.Tag = "Cyber";
            btnVoltar.TextButton = "←";
            btnVoltar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnVoltar.Timer_Effect_1 = 5;
            btnVoltar.Timer_RGB = 300;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(formUsuarios);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmUsuarios";
            Text = "dungeonForm1";
            formUsuarios.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.DreamForm formUsuarios;
        private ReaLTaiizor.Controls.CyberButton btnVoltar;
    }
}