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
            btnSalvar = new ReaLTaiizor.Controls.CyberButton();
            btnCancelar = new ReaLTaiizor.Controls.CyberButton();
            gpbAddCad = new ReaLTaiizor.Controls.CyberGroupBox();
            headerLabel3 = new ReaLTaiizor.Controls.HeaderLabel();
            LbDescricao = new ReaLTaiizor.Controls.HeaderLabel();
            LbTitulo = new ReaLTaiizor.Controls.HeaderLabel();
            cbPossuiPreparo = new ReaLTaiizor.Controls.CyberCheckBox();
            txtPreco = new ReaLTaiizor.Controls.CyberTextBox();
            txtDescricao = new ReaLTaiizor.Controls.CyberTextBox();
            txtTitulo = new ReaLTaiizor.Controls.CyberTextBox();
            btnSair = new ReaLTaiizor.Controls.CyberButton();
            formCardapioCad.SuspendLayout();
            gpbAddCad.SuspendLayout();
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
            formCardapioCad.Controls.Add(btnSalvar);
            formCardapioCad.Controls.Add(btnCancelar);
            formCardapioCad.Controls.Add(gpbAddCad);
            formCardapioCad.Controls.Add(btnSair);
            formCardapioCad.Dock = DockStyle.Fill;
            formCardapioCad.Location = new Point(0, 0);
            formCardapioCad.Name = "formCardapioCad";
            formCardapioCad.Size = new Size(1000, 650);
            formCardapioCad.TabIndex = 0;
            formCardapioCad.TabStop = false;
            formCardapioCad.Text = "dreamForm1";
            formCardapioCad.TitleAlign = HorizontalAlignment.Center;
            formCardapioCad.TitleHeight = 25;
            // 
            // btnSalvar
            // 
            btnSalvar.Alpha = 20;
            btnSalvar.BackColor = Color.Transparent;
            btnSalvar.Background = true;
            btnSalvar.Background_WidthPen = 4F;
            btnSalvar.BackgroundPen = true;
            btnSalvar.ColorBackground = Color.DarkGreen;
            btnSalvar.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnSalvar.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnSalvar.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnSalvar.ColorLighting = Color.FromArgb(29, 200, 238);
            btnSalvar.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnSalvar.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnSalvar.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnSalvar.Effect_1 = true;
            btnSalvar.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnSalvar.Effect_1_Transparency = 25;
            btnSalvar.Effect_2 = true;
            btnSalvar.Effect_2_ColorBackground = Color.White;
            btnSalvar.Effect_2_Transparency = 20;
            btnSalvar.Font = new Font("Arial", 11F);
            btnSalvar.ForeColor = Color.FromArgb(245, 245, 245);
            btnSalvar.Lighting = false;
            btnSalvar.LinearGradient_Background = false;
            btnSalvar.LinearGradientPen = false;
            btnSalvar.Location = new Point(704, 546);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.PenWidth = 15;
            btnSalvar.Rounding = true;
            btnSalvar.RoundingInt = 70;
            btnSalvar.Size = new Size(217, 80);
            btnSalvar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnSalvar.TabIndex = 7;
            btnSalvar.Tag = "Cyber";
            btnSalvar.TextButton = "# Salvar";
            btnSalvar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnSalvar.Timer_Effect_1 = 5;
            btnSalvar.Timer_RGB = 300;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Alpha = 20;
            btnCancelar.BackColor = Color.Transparent;
            btnCancelar.Background = true;
            btnCancelar.Background_WidthPen = 4F;
            btnCancelar.BackgroundPen = true;
            btnCancelar.ColorBackground = Color.Maroon;
            btnCancelar.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnCancelar.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnCancelar.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnCancelar.ColorLighting = Color.FromArgb(29, 200, 238);
            btnCancelar.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnCancelar.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnCancelar.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnCancelar.Effect_1 = true;
            btnCancelar.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnCancelar.Effect_1_Transparency = 25;
            btnCancelar.Effect_2 = true;
            btnCancelar.Effect_2_ColorBackground = Color.White;
            btnCancelar.Effect_2_Transparency = 20;
            btnCancelar.Font = new Font("Arial", 11F);
            btnCancelar.ForeColor = Color.FromArgb(245, 245, 245);
            btnCancelar.Lighting = false;
            btnCancelar.LinearGradient_Background = false;
            btnCancelar.LinearGradientPen = false;
            btnCancelar.Location = new Point(446, 546);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.PenWidth = 15;
            btnCancelar.Rounding = true;
            btnCancelar.RoundingInt = 70;
            btnCancelar.Size = new Size(217, 80);
            btnCancelar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnCancelar.TabIndex = 6;
            btnCancelar.Tag = "Cyber";
            btnCancelar.TextButton = "X Cancelar";
            btnCancelar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnCancelar.Timer_Effect_1 = 5;
            btnCancelar.Timer_RGB = 300;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // gpbAddCad
            // 
            gpbAddCad.Alpha = 20;
            gpbAddCad.BackColor = Color.Transparent;
            gpbAddCad.Background = true;
            gpbAddCad.Background_WidthPen = 3F;
            gpbAddCad.BackgroundPen = true;
            gpbAddCad.ColorBackground = Color.FromArgb(37, 52, 68);
            gpbAddCad.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            gpbAddCad.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            gpbAddCad.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            gpbAddCad.ColorLighting = Color.FromArgb(29, 200, 238);
            gpbAddCad.ColorPen_1 = Color.FromArgb(37, 52, 68);
            gpbAddCad.ColorPen_2 = Color.FromArgb(41, 63, 86);
            gpbAddCad.Controls.Add(headerLabel3);
            gpbAddCad.Controls.Add(LbDescricao);
            gpbAddCad.Controls.Add(LbTitulo);
            gpbAddCad.Controls.Add(cbPossuiPreparo);
            gpbAddCad.Controls.Add(txtPreco);
            gpbAddCad.Controls.Add(txtDescricao);
            gpbAddCad.Controls.Add(txtTitulo);
            gpbAddCad.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            gpbAddCad.ForeColor = Color.FromArgb(245, 245, 245);
            gpbAddCad.Lighting = false;
            gpbAddCad.LinearGradient_Background = false;
            gpbAddCad.LinearGradientPen = false;
            gpbAddCad.Location = new Point(31, 52);
            gpbAddCad.Name = "gpbAddCad";
            gpbAddCad.PenWidth = 15;
            gpbAddCad.RGB = false;
            gpbAddCad.Rounding = true;
            gpbAddCad.RoundingInt = 60;
            gpbAddCad.Size = new Size(933, 472);
            gpbAddCad.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            gpbAddCad.TabIndex = 5;
            gpbAddCad.Tag = "Cyber";
            gpbAddCad.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            gpbAddCad.Timer_RGB = 300;
            // 
            // headerLabel3
            // 
            headerLabel3.AutoSize = true;
            headerLabel3.BackColor = Color.Transparent;
            headerLabel3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headerLabel3.ForeColor = Color.FromArgb(255, 255, 255);
            headerLabel3.Location = new Point(103, 298);
            headerLabel3.Name = "headerLabel3";
            headerLabel3.Size = new Size(116, 40);
            headerLabel3.TabIndex = 6;
            headerLabel3.Text = "Preço";
            // 
            // LbDescricao
            // 
            LbDescricao.AutoSize = true;
            LbDescricao.BackColor = Color.Transparent;
            LbDescricao.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbDescricao.ForeColor = Color.FromArgb(255, 255, 255);
            LbDescricao.Location = new Point(103, 173);
            LbDescricao.Name = "LbDescricao";
            LbDescricao.Size = new Size(186, 40);
            LbDescricao.TabIndex = 5;
            LbDescricao.Text = "Descrição";
            // 
            // LbTitulo
            // 
            LbTitulo.AutoSize = true;
            LbTitulo.BackColor = Color.Transparent;
            LbTitulo.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbTitulo.ForeColor = Color.FromArgb(255, 255, 255);
            LbTitulo.Location = new Point(103, 42);
            LbTitulo.Name = "LbTitulo";
            LbTitulo.Size = new Size(111, 40);
            LbTitulo.TabIndex = 4;
            LbTitulo.Text = "Título";
            // 
            // cbPossuiPreparo
            // 
            cbPossuiPreparo.BackColor = Color.Transparent;
            cbPossuiPreparo.Background = true;
            cbPossuiPreparo.Background_WidthPen = 2F;
            cbPossuiPreparo.BackgroundPen = true;
            cbPossuiPreparo.Checked = false;
            cbPossuiPreparo.ColorBackground = Color.FromArgb(37, 52, 68);
            cbPossuiPreparo.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            cbPossuiPreparo.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cbPossuiPreparo.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cbPossuiPreparo.ColorChecked = Color.FromArgb(29, 200, 238);
            cbPossuiPreparo.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cbPossuiPreparo.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cbPossuiPreparo.CyberCheckBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cbPossuiPreparo.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            cbPossuiPreparo.Effect_1_Transparency = 25;
            cbPossuiPreparo.Effect_2 = true;
            cbPossuiPreparo.Effect_2_ColorBackground = Color.White;
            cbPossuiPreparo.Effect_2_Transparency = 15;
            cbPossuiPreparo.Font = new Font("Arial", 11F);
            cbPossuiPreparo.ForeColor = Color.FromArgb(245, 245, 245);
            cbPossuiPreparo.LinearGradient_Background = false;
            cbPossuiPreparo.LinearGradientPen = false;
            cbPossuiPreparo.Location = new Point(624, 348);
            cbPossuiPreparo.Name = "cbPossuiPreparo";
            cbPossuiPreparo.RGB = false;
            cbPossuiPreparo.Rounding = true;
            cbPossuiPreparo.RoundingInt = 100;
            cbPossuiPreparo.Size = new Size(255, 45);
            cbPossuiPreparo.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cbPossuiPreparo.TabIndex = 3;
            cbPossuiPreparo.Tag = "Cyber";
            cbPossuiPreparo.TextButton = "Possui Preparo?";
            cbPossuiPreparo.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cbPossuiPreparo.Timer_Effect_1 = 1;
            cbPossuiPreparo.Timer_RGB = 300;
            // 
            // txtPreco
            // 
            txtPreco.Alpha = 20;
            txtPreco.BackColor = Color.Transparent;
            txtPreco.Background_WidthPen = 3F;
            txtPreco.BackgroundPen = true;
            txtPreco.ColorBackground = Color.FromArgb(41, 41, 41);
            txtPreco.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            txtPreco.ColorLighting = Color.FromArgb(29, 200, 238);
            txtPreco.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtPreco.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtPreco.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtPreco.Font = new Font("Arial", 12F);
            txtPreco.ForeColor = Color.FromArgb(245, 245, 245);
            txtPreco.Lighting = false;
            txtPreco.LinearGradientPen = false;
            txtPreco.Location = new Point(73, 343);
            txtPreco.Name = "txtPreco";
            txtPreco.PenWidth = 15;
            txtPreco.RGB = false;
            txtPreco.Rounding = true;
            txtPreco.RoundingInt = 60;
            txtPreco.Size = new Size(514, 50);
            txtPreco.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtPreco.TabIndex = 2;
            txtPreco.Tag = "Cyber";
            txtPreco.TextButton = "";
            txtPreco.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtPreco.Timer_RGB = 300;
            // 
            // txtDescricao
            // 
            txtDescricao.Alpha = 20;
            txtDescricao.BackColor = Color.Transparent;
            txtDescricao.Background_WidthPen = 3F;
            txtDescricao.BackgroundPen = true;
            txtDescricao.ColorBackground = Color.FromArgb(41, 41, 41);
            txtDescricao.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            txtDescricao.ColorLighting = Color.FromArgb(29, 200, 238);
            txtDescricao.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtDescricao.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtDescricao.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtDescricao.Font = new Font("Arial", 12F);
            txtDescricao.ForeColor = Color.FromArgb(245, 245, 245);
            txtDescricao.Lighting = false;
            txtDescricao.LinearGradientPen = false;
            txtDescricao.Location = new Point(73, 215);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.PenWidth = 15;
            txtDescricao.RGB = false;
            txtDescricao.Rounding = true;
            txtDescricao.RoundingInt = 60;
            txtDescricao.Size = new Size(806, 50);
            txtDescricao.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtDescricao.TabIndex = 1;
            txtDescricao.Tag = "Cyber";
            txtDescricao.TextButton = "";
            txtDescricao.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtDescricao.Timer_RGB = 300;
            // 
            // txtTitulo
            // 
            txtTitulo.Alpha = 20;
            txtTitulo.BackColor = Color.Transparent;
            txtTitulo.Background_WidthPen = 3F;
            txtTitulo.BackgroundPen = true;
            txtTitulo.ColorBackground = Color.FromArgb(41, 41, 41);
            txtTitulo.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            txtTitulo.ColorLighting = Color.FromArgb(29, 200, 238);
            txtTitulo.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtTitulo.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtTitulo.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtTitulo.Font = new Font("Arial", 12F);
            txtTitulo.ForeColor = Color.FromArgb(245, 245, 245);
            txtTitulo.Lighting = false;
            txtTitulo.LinearGradientPen = false;
            txtTitulo.Location = new Point(73, 85);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.PenWidth = 15;
            txtTitulo.RGB = false;
            txtTitulo.Rounding = true;
            txtTitulo.RoundingInt = 60;
            txtTitulo.Size = new Size(806, 50);
            txtTitulo.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtTitulo.TabIndex = 0;
            txtTitulo.Tag = "Cyber";
            txtTitulo.TextButton = "";
            txtTitulo.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtTitulo.Timer_RGB = 300;
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
            btnSair.Location = new Point(12, 585);
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
            ClientSize = new Size(1000, 650);
            Controls.Add(formCardapioCad);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCardapioCad";
            Text = "FrmCardapioCad";
            TransparencyKey = Color.Fuchsia;
            formCardapioCad.ResumeLayout(false);
            gpbAddCad.ResumeLayout(false);
            gpbAddCad.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.DreamForm formCardapioCad;
        private ReaLTaiizor.Controls.CyberButton btnSair;
        private ReaLTaiizor.Controls.CyberGroupBox gpbAddCad;
        private ReaLTaiizor.Controls.CyberTextBox txtPreco;
        private ReaLTaiizor.Controls.CyberTextBox txtDescricao;
        private ReaLTaiizor.Controls.CyberTextBox txtTitulo;
        private ReaLTaiizor.Controls.CyberCheckBox cbPossuiPreparo;
        private ReaLTaiizor.Controls.HeaderLabel headerLabel3;
        private ReaLTaiizor.Controls.HeaderLabel LbDescricao;
        private ReaLTaiizor.Controls.HeaderLabel LbTitulo;
        private ReaLTaiizor.Controls.CyberButton btnSalvar;
        private ReaLTaiizor.Controls.CyberButton btnCancelar;
    }
}