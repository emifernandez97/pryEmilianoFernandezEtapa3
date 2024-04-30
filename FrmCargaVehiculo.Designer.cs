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
            ((System.ComponentModel.ISupportInitialize)PctVehiculo).BeginInit();
            SuspendLayout();
            // 
            // btnAuto
            // 
            btnAuto.Location = new Point(12, 315);
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
            btnAvion.Location = new Point(252, 315);
            btnAvion.Name = "btnAvion";
            btnAvion.Size = new Size(101, 60);
            btnAvion.TabIndex = 2;
            btnAvion.Text = "Cargar Avion";
            btnAvion.UseVisualStyleBackColor = true;
            // 
            // btnBarco
            // 
            btnBarco.Location = new Point(132, 315);
            btnBarco.Name = "btnBarco";
            btnBarco.Size = new Size(101, 60);
            btnBarco.TabIndex = 3;
            btnBarco.Text = "Cargar Barco";
            btnBarco.UseVisualStyleBackColor = true;
            // 
            // FrmCargaVehiculo
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 428);
            Controls.Add(btnBarco);
            Controls.Add(btnAvion);
            Controls.Add(PctVehiculo);
            Controls.Add(btnAuto);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FrmCargaVehiculo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Carga de Vehiculo";
            ((System.ComponentModel.ISupportInitialize)PctVehiculo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAuto;
        private PictureBox PctVehiculo;
        private Button btnAvion;
        private Button btnBarco;
    }
}
