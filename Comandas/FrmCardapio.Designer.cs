namespace Comandas
{
    partial class FrmCardapio
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
            formCardapio = new ReaLTaiizor.Forms.DreamForm();
            btnNovoItem = new ReaLTaiizor.Controls.CyberButton();
            txtCardapioPesq = new ReaLTaiizor.Controls.CyberTextBox();
            dataGridView1 = new DataGridView();
            cyberButton2 = new ReaLTaiizor.Controls.CyberButton();
            btnExcluir = new ReaLTaiizor.Controls.CyberButton();
            btnVoltar = new ReaLTaiizor.Controls.CyberButton();
            formCardapio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // formCardapio
            // 
            formCardapio.ColorA = Color.FromArgb(40, 218, 255);
            formCardapio.ColorB = Color.FromArgb(63, 63, 63);
            formCardapio.ColorC = Color.FromArgb(41, 41, 41);
            formCardapio.ColorD = Color.FromArgb(27, 27, 27);
            formCardapio.ColorE = Color.FromArgb(0, 0, 0, 0);
            formCardapio.ColorF = Color.FromArgb(25, 255, 255, 255);
            formCardapio.Controls.Add(btnNovoItem);
            formCardapio.Controls.Add(txtCardapioPesq);
            formCardapio.Controls.Add(dataGridView1);
            formCardapio.Controls.Add(cyberButton2);
            formCardapio.Controls.Add(btnExcluir);
            formCardapio.Controls.Add(btnVoltar);
            formCardapio.Dock = DockStyle.Fill;
            formCardapio.Location = new Point(0, 0);
            formCardapio.Name = "formCardapio";
            formCardapio.Size = new Size(1000, 650);
            formCardapio.TabIndex = 0;
            formCardapio.TabStop = false;
            formCardapio.Text = "dreamForm1";
            formCardapio.TitleAlign = HorizontalAlignment.Center;
            formCardapio.TitleHeight = 25;
            // 
            // btnNovoItem
            // 
            btnNovoItem.Alpha = 20;
            btnNovoItem.BackColor = Color.Transparent;
            btnNovoItem.Background = true;
            btnNovoItem.Background_WidthPen = 4F;
            btnNovoItem.BackgroundPen = true;
            btnNovoItem.ColorBackground = Color.FromArgb(37, 52, 68);
            btnNovoItem.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnNovoItem.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnNovoItem.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnNovoItem.ColorLighting = Color.FromArgb(29, 200, 238);
            btnNovoItem.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnNovoItem.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnNovoItem.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnNovoItem.Effect_1 = true;
            btnNovoItem.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnNovoItem.Effect_1_Transparency = 25;
            btnNovoItem.Effect_2 = true;
            btnNovoItem.Effect_2_ColorBackground = Color.White;
            btnNovoItem.Effect_2_Transparency = 20;
            btnNovoItem.Font = new Font("Arial", 11F);
            btnNovoItem.ForeColor = Color.FromArgb(245, 245, 245);
            btnNovoItem.Lighting = false;
            btnNovoItem.LinearGradient_Background = false;
            btnNovoItem.LinearGradientPen = false;
            btnNovoItem.Location = new Point(31, 108);
            btnNovoItem.Name = "btnNovoItem";
            btnNovoItem.PenWidth = 15;
            btnNovoItem.Rounding = true;
            btnNovoItem.RoundingInt = 70;
            btnNovoItem.Size = new Size(258, 60);
            btnNovoItem.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnNovoItem.TabIndex = 10;
            btnNovoItem.Tag = "Cyber";
            btnNovoItem.TextButton = "+ Novo item Cardápio";
            btnNovoItem.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnNovoItem.Timer_Effect_1 = 5;
            btnNovoItem.Timer_RGB = 300;
            btnNovoItem.Click += btnNovoItem_Click;
            // 
            // txtCardapioPesq
            // 
            txtCardapioPesq.Alpha = 20;
            txtCardapioPesq.BackColor = Color.Transparent;
            txtCardapioPesq.Background_WidthPen = 3F;
            txtCardapioPesq.BackgroundPen = true;
            txtCardapioPesq.ColorBackground = Color.FromArgb(37, 52, 68);
            txtCardapioPesq.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            txtCardapioPesq.ColorLighting = Color.FromArgb(29, 200, 238);
            txtCardapioPesq.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtCardapioPesq.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtCardapioPesq.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtCardapioPesq.Font = new Font("Arial", 12F);
            txtCardapioPesq.ForeColor = Color.FromArgb(245, 245, 245);
            txtCardapioPesq.Lighting = false;
            txtCardapioPesq.LinearGradientPen = false;
            txtCardapioPesq.Location = new Point(31, 45);
            txtCardapioPesq.Name = "txtCardapioPesq";
            txtCardapioPesq.PenWidth = 15;
            txtCardapioPesq.RGB = false;
            txtCardapioPesq.Rounding = true;
            txtCardapioPesq.RoundingInt = 60;
            txtCardapioPesq.Size = new Size(929, 51);
            txtCardapioPesq.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtCardapioPesq.TabIndex = 9;
            txtCardapioPesq.Tag = "Cyber";
            txtCardapioPesq.TextButton = "Digite aqui para pesquisar";
            txtCardapioPesq.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtCardapioPesq.Timer_RGB = 300;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 180);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(929, 381);
            dataGridView1.TabIndex = 8;
            // 
            // cyberButton2
            // 
            cyberButton2.Alpha = 20;
            cyberButton2.BackColor = Color.Transparent;
            cyberButton2.Background = true;
            cyberButton2.Background_WidthPen = 4F;
            cyberButton2.BackgroundPen = true;
            cyberButton2.ColorBackground = Color.ForestGreen;
            cyberButton2.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            cyberButton2.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cyberButton2.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cyberButton2.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberButton2.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberButton2.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberButton2.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberButton2.Effect_1 = true;
            cyberButton2.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            cyberButton2.Effect_1_Transparency = 25;
            cyberButton2.Effect_2 = true;
            cyberButton2.Effect_2_ColorBackground = Color.White;
            cyberButton2.Effect_2_Transparency = 20;
            cyberButton2.Font = new Font("Arial", 11F);
            cyberButton2.ForeColor = Color.FromArgb(245, 245, 245);
            cyberButton2.Lighting = false;
            cyberButton2.LinearGradient_Background = false;
            cyberButton2.LinearGradientPen = false;
            cyberButton2.Location = new Point(813, 585);
            cyberButton2.Name = "cyberButton2";
            cyberButton2.PenWidth = 15;
            cyberButton2.Rounding = true;
            cyberButton2.RoundingInt = 70;
            cyberButton2.Size = new Size(165, 53);
            cyberButton2.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberButton2.TabIndex = 7;
            cyberButton2.Tag = "Cyber";
            cyberButton2.TextButton = "# Editar";
            cyberButton2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberButton2.Timer_Effect_1 = 5;
            cyberButton2.Timer_RGB = 300;
            cyberButton2.Click += cyberButton2_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Alpha = 20;
            btnExcluir.BackColor = Color.Transparent;
            btnExcluir.Background = true;
            btnExcluir.Background_WidthPen = 4F;
            btnExcluir.BackgroundPen = true;
            btnExcluir.ColorBackground = Color.Maroon;
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
            btnExcluir.Location = new Point(630, 585);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.PenWidth = 15;
            btnExcluir.Rounding = true;
            btnExcluir.RoundingInt = 70;
            btnExcluir.Size = new Size(165, 53);
            btnExcluir.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnExcluir.TabIndex = 6;
            btnExcluir.Tag = "Cyber";
            btnExcluir.TextButton = "X Excluir";
            btnExcluir.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnExcluir.Timer_Effect_1 = 5;
            btnExcluir.Timer_RGB = 300;
            btnExcluir.Click += btnExcluir_Click;
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
            btnVoltar.Location = new Point(6, 585);
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
            // FrmCardapio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 650);
            Controls.Add(formCardapio);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCardapio";
            Text = "FrmCardapio";
            TransparencyKey = Color.Fuchsia;
            formCardapio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.DreamForm formCardapio;
        private ReaLTaiizor.Controls.CyberButton btnVoltar;
        private ReaLTaiizor.Controls.CyberButton cyberButton2;
        private ReaLTaiizor.Controls.CyberButton btnExcluir;
        private ReaLTaiizor.Controls.CyberTextBox txtCardapioPesq;
        private DataGridView dataGridView1;
        private ReaLTaiizor.Controls.CyberButton btnNovoItem;
    }
}