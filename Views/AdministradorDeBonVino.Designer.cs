namespace BomVino_PPAI.Views
{
    partial class AdministradorDeBonVino
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministradorDeBonVino));
            guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(components);
            guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            groupBoxBtnCU = new Guna.UI2.WinForms.Guna2GroupBox();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            pictureBox1 = new PictureBox();
            guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            groupBoxBtnCU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2DragControl2
            // 
            guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl2.TargetControl = this;
            guna2DragControl2.UseTransparentDrag = true;
            // 
            // groupBoxBtnCU
            // 
            groupBoxBtnCU.BackgroundImageLayout = ImageLayout.None;
            groupBoxBtnCU.BorderColor = Color.Maroon;
            groupBoxBtnCU.BorderRadius = 6;
            groupBoxBtnCU.Controls.Add(guna2Button1);
            groupBoxBtnCU.CustomBorderColor = Color.Transparent;
            groupBoxBtnCU.CustomizableEdges = customizableEdges3;
            groupBoxBtnCU.FillColor = Color.Transparent;
            groupBoxBtnCU.Font = new Font("Segoe UI", 9F);
            groupBoxBtnCU.ForeColor = Color.Transparent;
            groupBoxBtnCU.ImeMode = ImeMode.NoControl;
            groupBoxBtnCU.Location = new Point(100, 127);
            groupBoxBtnCU.Name = "groupBoxBtnCU";
            groupBoxBtnCU.ShadowDecoration.CustomizableEdges = customizableEdges4;
            groupBoxBtnCU.Size = new Size(633, 119);
            groupBoxBtnCU.TabIndex = 1;
            groupBoxBtnCU.TabStop = false;
            // 
            // guna2Button1
            // 
            guna2Button1.BorderColor = Color.Firebrick;
            guna2Button1.BorderRadius = 3;
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.Maroon;
            guna2Button1.FocusedColor = Color.White;
            guna2Button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(162, 43);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.PressedColor = Color.Maroon;
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(313, 37);
            guna2Button1.TabIndex = 10;
            guna2Button1.Text = "Importar Actualización de Vinos";
            guna2Button1.Click += OpcionImportarActualizacionVinos;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // guna2HtmlLabel4
            // 
            guna2HtmlLabel4.BackColor = Color.Transparent;
            guna2HtmlLabel4.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel4.ForeColor = Color.DimGray;
            guna2HtmlLabel4.Location = new Point(50, 21);
            guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            guna2HtmlLabel4.Size = new Size(218, 23);
            guna2HtmlLabel4.TabIndex = 4;
            guna2HtmlLabel4.Text = "Administrador De Bonvino";
            // 
            // AdministradorDeBonVino
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(833, 317);
            Controls.Add(guna2HtmlLabel4);
            Controls.Add(pictureBox1);
            Controls.Add(groupBoxBtnCU);
            Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdministradorDeBonVino";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdministradorDeBonVino";
            groupBoxBtnCU.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2Button btnImportarActualizacion;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2GroupBox groupBoxBtnCU;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
    }
}