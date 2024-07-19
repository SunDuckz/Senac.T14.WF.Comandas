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
            cyberButton1 = new ReaLTaiizor.Controls.CyberButton();
            btnVoltar = new ReaLTaiizor.Controls.CyberButton();
            dgvUsuarios = new DataGridView();
            cyberGroupBox1 = new ReaLTaiizor.Controls.CyberGroupBox();
            labelId = new ReaLTaiizor.Controls.MetroLabel();
            labelSenha = new ReaLTaiizor.Controls.MetroLabel();
            labelEmail = new ReaLTaiizor.Controls.MetroLabel();
            labelNome = new ReaLTaiizor.Controls.MetroLabel();
            txtId = new ReaLTaiizor.Controls.CyberTextBox();
            txtSenha = new ReaLTaiizor.Controls.CyberTextBox();
            txtEmail = new ReaLTaiizor.Controls.CyberTextBox();
            txtNome = new ReaLTaiizor.Controls.CyberTextBox();
            btnNovo = new ReaLTaiizor.Controls.CyberButton();
            btnSalvar = new ReaLTaiizor.Controls.CyberButton();
            btnExcluir = new ReaLTaiizor.Controls.CyberButton();
            btnEditar = new ReaLTaiizor.Controls.CyberButton();
            formUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            cyberGroupBox1.SuspendLayout();
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
            formUsuarios.Controls.Add(cyberButton1);
            formUsuarios.Controls.Add(btnVoltar);
            formUsuarios.Controls.Add(dgvUsuarios);
            formUsuarios.Controls.Add(cyberGroupBox1);
            formUsuarios.Controls.Add(btnNovo);
            formUsuarios.Controls.Add(btnSalvar);
            formUsuarios.Controls.Add(btnExcluir);
            formUsuarios.Controls.Add(btnEditar);
            formUsuarios.Dock = DockStyle.Fill;
            formUsuarios.Location = new Point(0, 0);
            formUsuarios.Name = "formUsuarios";
            formUsuarios.Size = new Size(800, 450);
            formUsuarios.TabIndex = 0;
            formUsuarios.TabStop = false;
            formUsuarios.Text = "Usuarios";
            formUsuarios.TitleAlign = HorizontalAlignment.Center;
            formUsuarios.TitleHeight = 25;
            // 
            // cyberButton1
            // 
            cyberButton1.Alpha = 20;
            cyberButton1.BackColor = Color.Transparent;
            cyberButton1.Background = true;
            cyberButton1.Background_WidthPen = 4F;
            cyberButton1.BackgroundPen = true;
            cyberButton1.ColorBackground = Color.FromArgb(37, 52, 68);
            cyberButton1.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            cyberButton1.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cyberButton1.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cyberButton1.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberButton1.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberButton1.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberButton1.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberButton1.Effect_1 = true;
            cyberButton1.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            cyberButton1.Effect_1_Transparency = 25;
            cyberButton1.Effect_2 = true;
            cyberButton1.Effect_2_ColorBackground = Color.White;
            cyberButton1.Effect_2_Transparency = 20;
            cyberButton1.Font = new Font("Arial", 11F);
            cyberButton1.ForeColor = Color.FromArgb(245, 245, 245);
            cyberButton1.Lighting = false;
            cyberButton1.LinearGradient_Background = false;
            cyberButton1.LinearGradientPen = false;
            cyberButton1.Location = new Point(642, 280);
            cyberButton1.Name = "cyberButton1";
            cyberButton1.PenWidth = 15;
            cyberButton1.Rounding = true;
            cyberButton1.RoundingInt = 70;
            cyberButton1.Size = new Size(118, 39);
            cyberButton1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberButton1.TabIndex = 12;
            cyberButton1.Tag = "Cyber";
            cyberButton1.TextButton = "Cancelar";
            cyberButton1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberButton1.Timer_Effect_1 = 5;
            cyberButton1.Timer_RGB = 300;
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
            btnVoltar.Location = new Point(6, 38);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.PenWidth = 15;
            btnVoltar.Rounding = true;
            btnVoltar.RoundingInt = 70;
            btnVoltar.Size = new Size(74, 33);
            btnVoltar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnVoltar.TabIndex = 5;
            btnVoltar.Tag = "Cyber";
            btnVoltar.TextButton = "←";
            btnVoltar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnVoltar.Timer_Effect_1 = 5;
            btnVoltar.Timer_RGB = 300;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(30, 325);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 62;
            dgvUsuarios.Size = new Size(731, 113);
            dgvUsuarios.TabIndex = 11;
            // 
            // cyberGroupBox1
            // 
            cyberGroupBox1.Alpha = 20;
            cyberGroupBox1.BackColor = Color.Transparent;
            cyberGroupBox1.Background = true;
            cyberGroupBox1.Background_WidthPen = 3F;
            cyberGroupBox1.BackgroundPen = true;
            cyberGroupBox1.ColorBackground = Color.FromArgb(37, 52, 68);
            cyberGroupBox1.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            cyberGroupBox1.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cyberGroupBox1.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cyberGroupBox1.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberGroupBox1.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberGroupBox1.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberGroupBox1.Controls.Add(labelId);
            cyberGroupBox1.Controls.Add(labelSenha);
            cyberGroupBox1.Controls.Add(labelEmail);
            cyberGroupBox1.Controls.Add(labelNome);
            cyberGroupBox1.Controls.Add(txtId);
            cyberGroupBox1.Controls.Add(txtSenha);
            cyberGroupBox1.Controls.Add(txtEmail);
            cyberGroupBox1.Controls.Add(txtNome);
            cyberGroupBox1.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberGroupBox1.ForeColor = Color.FromArgb(245, 245, 245);
            cyberGroupBox1.Lighting = false;
            cyberGroupBox1.LinearGradient_Background = false;
            cyberGroupBox1.LinearGradientPen = false;
            cyberGroupBox1.Location = new Point(30, 38);
            cyberGroupBox1.Name = "cyberGroupBox1";
            cyberGroupBox1.PenWidth = 15;
            cyberGroupBox1.RGB = false;
            cyberGroupBox1.Rounding = true;
            cyberGroupBox1.RoundingInt = 60;
            cyberGroupBox1.Size = new Size(731, 236);
            cyberGroupBox1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberGroupBox1.TabIndex = 10;
            cyberGroupBox1.Tag = "Cyber";
            cyberGroupBox1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberGroupBox1.Timer_RGB = 300;
            // 
            // labelId
            // 
            labelId.Font = new Font("Microsoft Sans Serif", 10F);
            labelId.IsDerivedStyle = true;
            labelId.Location = new Point(85, 23);
            labelId.Name = "labelId";
            labelId.Size = new Size(73, 34);
            labelId.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            labelId.StyleManager = null;
            labelId.TabIndex = 7;
            labelId.Text = "Id:";
            labelId.ThemeAuthor = "Taiizor";
            labelId.ThemeName = "MetroLight";
            // 
            // labelSenha
            // 
            labelSenha.Font = new Font("Microsoft Sans Serif", 10F);
            labelSenha.IsDerivedStyle = true;
            labelSenha.Location = new Point(85, 179);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(84, 34);
            labelSenha.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            labelSenha.StyleManager = null;
            labelSenha.TabIndex = 6;
            labelSenha.Text = "Senha:";
            labelSenha.ThemeAuthor = "Taiizor";
            labelSenha.ThemeName = "MetroLight";
            // 
            // labelEmail
            // 
            labelEmail.Font = new Font("Microsoft Sans Serif", 10F);
            labelEmail.IsDerivedStyle = true;
            labelEmail.Location = new Point(85, 127);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(73, 34);
            labelEmail.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            labelEmail.StyleManager = null;
            labelEmail.TabIndex = 5;
            labelEmail.Text = "Email:";
            labelEmail.ThemeAuthor = "Taiizor";
            labelEmail.ThemeName = "MetroLight";
            // 
            // labelNome
            // 
            labelNome.Font = new Font("Microsoft Sans Serif", 10F);
            labelNome.IsDerivedStyle = true;
            labelNome.Location = new Point(85, 75);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(73, 34);
            labelNome.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            labelNome.StyleManager = null;
            labelNome.TabIndex = 4;
            labelNome.Text = "Nome:";
            labelNome.ThemeAuthor = "Taiizor";
            labelNome.ThemeName = "MetroLight";
            // 
            // txtId
            // 
            txtId.Alpha = 20;
            txtId.BackColor = Color.Transparent;
            txtId.Background_WidthPen = 3F;
            txtId.BackgroundPen = true;
            txtId.ColorBackground = Color.FromArgb(37, 52, 68);
            txtId.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            txtId.ColorLighting = Color.FromArgb(29, 200, 238);
            txtId.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtId.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtId.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtId.Enabled = false;
            txtId.Font = new Font("Arial", 9F);
            txtId.ForeColor = Color.FromArgb(245, 245, 245);
            txtId.Lighting = false;
            txtId.LinearGradientPen = false;
            txtId.Location = new Point(213, 19);
            txtId.Name = "txtId";
            txtId.PenWidth = 15;
            txtId.RGB = false;
            txtId.Rounding = true;
            txtId.RoundingInt = 60;
            txtId.Size = new Size(461, 38);
            txtId.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtId.TabIndex = 3;
            txtId.Tag = "Cyber";
            txtId.TextButton = "1";
            txtId.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtId.Timer_RGB = 300;
            // 
            // txtSenha
            // 
            txtSenha.Alpha = 20;
            txtSenha.BackColor = Color.Transparent;
            txtSenha.Background_WidthPen = 3F;
            txtSenha.BackgroundPen = true;
            txtSenha.ColorBackground = Color.FromArgb(37, 52, 68);
            txtSenha.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            txtSenha.ColorLighting = Color.FromArgb(29, 200, 238);
            txtSenha.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtSenha.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtSenha.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtSenha.Enabled = false;
            txtSenha.Font = new Font("Arial", 9F);
            txtSenha.ForeColor = Color.FromArgb(245, 245, 245);
            txtSenha.Lighting = false;
            txtSenha.LinearGradientPen = false;
            txtSenha.Location = new Point(213, 175);
            txtSenha.Name = "txtSenha";
            txtSenha.PenWidth = 15;
            txtSenha.RGB = false;
            txtSenha.Rounding = true;
            txtSenha.RoundingInt = 60;
            txtSenha.Size = new Size(461, 38);
            txtSenha.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtSenha.TabIndex = 2;
            txtSenha.Tag = "Cyber";
            txtSenha.TextButton = "";
            txtSenha.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtSenha.Timer_RGB = 300;
            // 
            // txtEmail
            // 
            txtEmail.Alpha = 20;
            txtEmail.BackColor = Color.Transparent;
            txtEmail.Background_WidthPen = 3F;
            txtEmail.BackgroundPen = true;
            txtEmail.ColorBackground = Color.FromArgb(37, 52, 68);
            txtEmail.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            txtEmail.ColorLighting = Color.FromArgb(29, 200, 238);
            txtEmail.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtEmail.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtEmail.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtEmail.Enabled = false;
            txtEmail.Font = new Font("Arial", 9F);
            txtEmail.ForeColor = Color.FromArgb(245, 245, 245);
            txtEmail.Lighting = false;
            txtEmail.LinearGradientPen = false;
            txtEmail.Location = new Point(213, 123);
            txtEmail.Name = "txtEmail";
            txtEmail.PenWidth = 15;
            txtEmail.RGB = false;
            txtEmail.Rounding = true;
            txtEmail.RoundingInt = 60;
            txtEmail.Size = new Size(461, 38);
            txtEmail.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtEmail.TabIndex = 1;
            txtEmail.Tag = "Cyber";
            txtEmail.TextButton = "";
            txtEmail.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtEmail.Timer_RGB = 300;
            // 
            // txtNome
            // 
            txtNome.Alpha = 20;
            txtNome.BackColor = Color.Transparent;
            txtNome.Background_WidthPen = 3F;
            txtNome.BackgroundPen = true;
            txtNome.ColorBackground = Color.FromArgb(37, 52, 68);
            txtNome.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            txtNome.ColorLighting = Color.FromArgb(29, 200, 238);
            txtNome.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtNome.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtNome.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtNome.Enabled = false;
            txtNome.Font = new Font("Arial", 9F);
            txtNome.ForeColor = Color.FromArgb(245, 245, 245);
            txtNome.Lighting = false;
            txtNome.LinearGradientPen = false;
            txtNome.Location = new Point(213, 71);
            txtNome.Name = "txtNome";
            txtNome.PenWidth = 15;
            txtNome.RGB = false;
            txtNome.Rounding = true;
            txtNome.RoundingInt = 60;
            txtNome.Size = new Size(461, 38);
            txtNome.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtNome.TabIndex = 0;
            txtNome.Tag = "Cyber";
            txtNome.TextButton = "";
            txtNome.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtNome.Timer_RGB = 300;
            // 
            // btnNovo
            // 
            btnNovo.Alpha = 20;
            btnNovo.BackColor = Color.Transparent;
            btnNovo.Background = true;
            btnNovo.Background_WidthPen = 4F;
            btnNovo.BackgroundPen = true;
            btnNovo.ColorBackground = Color.FromArgb(37, 52, 68);
            btnNovo.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnNovo.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnNovo.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnNovo.ColorLighting = Color.FromArgb(29, 200, 238);
            btnNovo.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnNovo.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnNovo.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnNovo.Effect_1 = true;
            btnNovo.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnNovo.Effect_1_Transparency = 25;
            btnNovo.Effect_2 = true;
            btnNovo.Effect_2_ColorBackground = Color.White;
            btnNovo.Effect_2_Transparency = 20;
            btnNovo.Font = new Font("Arial", 11F);
            btnNovo.ForeColor = Color.FromArgb(245, 245, 245);
            btnNovo.Lighting = false;
            btnNovo.LinearGradient_Background = false;
            btnNovo.LinearGradientPen = false;
            btnNovo.Location = new Point(50, 280);
            btnNovo.Name = "btnNovo";
            btnNovo.PenWidth = 15;
            btnNovo.Rounding = true;
            btnNovo.RoundingInt = 70;
            btnNovo.Size = new Size(118, 39);
            btnNovo.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnNovo.TabIndex = 9;
            btnNovo.Tag = "Cyber";
            btnNovo.TextButton = "Novo";
            btnNovo.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnNovo.Timer_Effect_1 = 5;
            btnNovo.Timer_RGB = 300;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Alpha = 20;
            btnSalvar.BackColor = Color.Transparent;
            btnSalvar.Background = true;
            btnSalvar.Background_WidthPen = 4F;
            btnSalvar.BackgroundPen = true;
            btnSalvar.ColorBackground = Color.FromArgb(37, 52, 68);
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
            btnSalvar.Location = new Point(346, 280);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.PenWidth = 15;
            btnSalvar.Rounding = true;
            btnSalvar.RoundingInt = 70;
            btnSalvar.Size = new Size(118, 39);
            btnSalvar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnSalvar.TabIndex = 8;
            btnSalvar.Tag = "Cyber";
            btnSalvar.TextButton = "Salvar";
            btnSalvar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnSalvar.Timer_Effect_1 = 5;
            btnSalvar.Timer_RGB = 300;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Alpha = 20;
            btnExcluir.BackColor = Color.Transparent;
            btnExcluir.Background = true;
            btnExcluir.Background_WidthPen = 4F;
            btnExcluir.BackgroundPen = true;
            btnExcluir.ColorBackground = Color.FromArgb(37, 52, 68);
            btnExcluir.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnExcluir.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnExcluir.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnExcluir.ColorLighting = Color.FromArgb(29, 200, 238);
            btnExcluir.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnExcluir.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnExcluir.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnExcluir.Effect_1 = true;
            btnExcluir.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnExcluir.Effect_1_Transparency = 25;
            btnExcluir.Effect_2 = true;
            btnExcluir.Effect_2_ColorBackground = Color.White;
            btnExcluir.Effect_2_Transparency = 20;
            btnExcluir.Font = new Font("Arial", 11F);
            btnExcluir.ForeColor = Color.FromArgb(245, 245, 245);
            btnExcluir.Lighting = false;
            btnExcluir.LinearGradient_Background = false;
            btnExcluir.LinearGradientPen = false;
            btnExcluir.Location = new Point(494, 280);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.PenWidth = 15;
            btnExcluir.Rounding = true;
            btnExcluir.RoundingInt = 70;
            btnExcluir.Size = new Size(118, 39);
            btnExcluir.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnExcluir.TabIndex = 7;
            btnExcluir.Tag = "Cyber";
            btnExcluir.TextButton = "Excluir";
            btnExcluir.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnExcluir.Timer_Effect_1 = 5;
            btnExcluir.Timer_RGB = 300;
            // 
            // btnEditar
            // 
            btnEditar.Alpha = 20;
            btnEditar.BackColor = Color.Transparent;
            btnEditar.Background = true;
            btnEditar.Background_WidthPen = 4F;
            btnEditar.BackgroundPen = true;
            btnEditar.ColorBackground = Color.FromArgb(37, 52, 68);
            btnEditar.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnEditar.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnEditar.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnEditar.ColorLighting = Color.FromArgb(29, 200, 238);
            btnEditar.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnEditar.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnEditar.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnEditar.Effect_1 = true;
            btnEditar.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnEditar.Effect_1_Transparency = 25;
            btnEditar.Effect_2 = true;
            btnEditar.Effect_2_ColorBackground = Color.White;
            btnEditar.Effect_2_Transparency = 20;
            btnEditar.Font = new Font("Arial", 11F);
            btnEditar.ForeColor = Color.FromArgb(245, 245, 245);
            btnEditar.Lighting = false;
            btnEditar.LinearGradient_Background = false;
            btnEditar.LinearGradientPen = false;
            btnEditar.Location = new Point(198, 280);
            btnEditar.Name = "btnEditar";
            btnEditar.PenWidth = 15;
            btnEditar.Rounding = true;
            btnEditar.RoundingInt = 70;
            btnEditar.Size = new Size(118, 39);
            btnEditar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnEditar.TabIndex = 6;
            btnEditar.Tag = "Cyber";
            btnEditar.TextButton = "Editar";
            btnEditar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnEditar.Timer_Effect_1 = 5;
            btnEditar.Timer_RGB = 300;
            btnEditar.Click += btnEditar_Click;
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
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            cyberGroupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.DreamForm formUsuarios;
        private ReaLTaiizor.Controls.CyberButton btnVoltar;
        private ReaLTaiizor.Controls.CyberButton btnNovo;
        private ReaLTaiizor.Controls.CyberButton btnSalvar;
        private ReaLTaiizor.Controls.CyberButton btnExcluir;
        private ReaLTaiizor.Controls.CyberButton btnEditar;
        private ReaLTaiizor.Controls.CyberGroupBox cyberGroupBox1;
        private ReaLTaiizor.Controls.CyberTextBox txtSenha;
        private ReaLTaiizor.Controls.CyberTextBox txtEmail;
        private ReaLTaiizor.Controls.CyberTextBox txtNome;
        private ReaLTaiizor.Controls.MetroLabel labelNome;
        private ReaLTaiizor.Controls.CyberTextBox txtId;
        private ReaLTaiizor.Controls.MetroLabel labelId;
        private ReaLTaiizor.Controls.MetroLabel labelSenha;
        private ReaLTaiizor.Controls.MetroLabel labelEmail;
        private DataGridView dgvUsuarios;
        private ReaLTaiizor.Controls.CyberButton cyberButton1;
    }
}