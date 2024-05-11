namespace pryEmilianoFernandezEtapa2
{
    partial class FrmCargaVehiculo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAuto = new Button();
            PctVehiculo = new PictureBox();
            btnAvion = new Button();
            btnBarco = new Button();
            label1 = new Label();
            label2 = new Label();
            lblNombre = new Label();
            lblTipo = new Label();
            ((System.ComponentModel.ISupportInitialize)PctVehiculo).BeginInit();
            SuspendLayout();
            // 
            // btnAuto
            // 
            btnAuto.Location = new Point(2, 393);
            btnAuto.Name = "btnAuto";
            btnAuto.Size = new Size(101, 60);
            btnAuto.TabIndex = 0;
            btnAuto.Text = "Cargar Auto";
            btnAuto.UseVisualStyleBackColor = true;
            btnAuto.Click += BtnCargar_Click;
            // 
            // PctVehiculo
            // 
            PctVehiculo.BackColor = Color.White;
            PctVehiculo.BorderStyle = BorderStyle.Fixed3D;
            PctVehiculo.Location = new Point(12, 12);
            PctVehiculo.Name = "PctVehiculo";
            PctVehiculo.Size = new Size(341, 260);
            PctVehiculo.SizeMode = PictureBoxSizeMode.StretchImage;
            PctVehiculo.TabIndex = 1;
            PctVehiculo.TabStop = false;
            // 
            // btnAvion
            // 
            btnAvion.Location = new Point(242, 393);
            btnAvion.Name = "btnAvion";
            btnAvion.Size = new Size(101, 60);
            btnAvion.TabIndex = 2;
            btnAvion.Text = "Cargar Avion";
            btnAvion.UseVisualStyleBackColor = true;
            btnAvion.Click += btnAvion_Click;
            // 
            // btnBarco
            // 
            btnBarco.Location = new Point(122, 393);
            btnBarco.Name = "btnBarco";
            btnBarco.Size = new Size(101, 60);
            btnBarco.TabIndex = 3;
            btnBarco.Text = "Cargar Barco";
            btnBarco.UseVisualStyleBackColor = true;
            btnBarco.Click += btnBarco_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 302);
            label1.Name = "label1";
            label1.Size = new Size(62, 16);
            label1.TabIndex = 4;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 341);
            label2.Name = "label2";
            label2.Size = new Size(41, 16);
            label2.TabIndex = 5;
            label2.Text = "Tipo:";
            // 
            // lblNombre
            // 
            lblNombre.BorderStyle = BorderStyle.Fixed3D;
            lblNombre.Location = new Point(171, 292);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(141, 26);
            lblNombre.TabIndex = 6;
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTipo
            // 
            lblTipo.BorderStyle = BorderStyle.Fixed3D;
            lblTipo.Location = new Point(171, 331);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(141, 26);
            lblTipo.TabIndex = 7;
            lblTipo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmCargaVehiculo
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 465);
            Controls.Add(lblTipo);
            Controls.Add(lblNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBarco);
            Controls.Add(btnAvion);
            Controls.Add(PctVehiculo);
            Controls.Add(btnAuto);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FrmCargaVehiculo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Carga de Vehiculo";
            ((System.ComponentModel.ISupportInitialize)PctVehiculo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAuto;
        private PictureBox PctVehiculo;
        private Button btnAvion;
        private Button btnBarco;
        private Label label1;
        private Label label2;
        private Label lblNombre;
        private Label lblTipo;
    }
}
