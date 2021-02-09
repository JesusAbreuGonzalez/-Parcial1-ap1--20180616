
namespace _Parcial1_ap1__20180616.UI.Registros
{
    partial class RegistrosDeCiudades
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrosDeCiudades));
            this.CiudadIdLabel = new System.Windows.Forms.Label();
            this.CiudadNombreLabel = new System.Windows.Forms.Label();
            this.CiudadIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CiudadNombreTextBox = new System.Windows.Forms.TextBox();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.CiudadesErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CiudadIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CiudadesErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // CiudadIdLabel
            // 
            this.CiudadIdLabel.AutoSize = true;
            this.CiudadIdLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CiudadIdLabel.Location = new System.Drawing.Point(31, 34);
            this.CiudadIdLabel.Name = "CiudadIdLabel";
            this.CiudadIdLabel.Size = new System.Drawing.Size(96, 28);
            this.CiudadIdLabel.TabIndex = 0;
            this.CiudadIdLabel.Text = "Ciudad Id";
            // 
            // CiudadNombreLabel
            // 
            this.CiudadNombreLabel.AutoSize = true;
            this.CiudadNombreLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CiudadNombreLabel.Location = new System.Drawing.Point(31, 130);
            this.CiudadNombreLabel.Name = "CiudadNombreLabel";
            this.CiudadNombreLabel.Size = new System.Drawing.Size(85, 28);
            this.CiudadNombreLabel.TabIndex = 1;
            this.CiudadNombreLabel.Text = "Nombre";
            // 
            // CiudadIdNumericUpDown
            // 
            this.CiudadIdNumericUpDown.Location = new System.Drawing.Point(133, 39);
            this.CiudadIdNumericUpDown.Name = "CiudadIdNumericUpDown";
            this.CiudadIdNumericUpDown.Size = new System.Drawing.Size(150, 27);
            this.CiudadIdNumericUpDown.TabIndex = 2;
            // 
            // CiudadNombreTextBox
            // 
            this.CiudadNombreTextBox.Location = new System.Drawing.Point(122, 134);
            this.CiudadNombreTextBox.Name = "CiudadNombreTextBox";
            this.CiudadNombreTextBox.Size = new System.Drawing.Size(311, 27);
            this.CiudadNombreTextBox.TabIndex = 3;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButton.Image")));
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(289, 37);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(80, 29);
            this.BuscarButton.TabIndex = 4;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoButton.Image")));
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NuevoButton.Location = new System.Drawing.Point(33, 226);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(92, 50);
            this.NuevoButton.TabIndex = 5;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButton.Image")));
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButton.Location = new System.Drawing.Point(187, 226);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(92, 50);
            this.GuardarButton.TabIndex = 6;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarButton.Image")));
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarButton.Location = new System.Drawing.Point(341, 226);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(92, 50);
            this.EliminarButton.TabIndex = 7;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // CiudadesErrorProvider
            // 
            this.CiudadesErrorProvider.ContainerControl = this;
            // 
            // RegistrosDeCiudades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 305);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.CiudadNombreTextBox);
            this.Controls.Add(this.CiudadIdNumericUpDown);
            this.Controls.Add(this.CiudadNombreLabel);
            this.Controls.Add(this.CiudadIdLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrosDeCiudades";
            this.Text = "RegistrosDeCiudades";
            ((System.ComponentModel.ISupportInitialize)(this.CiudadIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CiudadesErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CiudadIdLabel;
        private System.Windows.Forms.Label CiudadNombreLabel;
        private System.Windows.Forms.NumericUpDown CiudadIdNumericUpDown;
        private System.Windows.Forms.TextBox CiudadNombreTextBox;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.ErrorProvider CiudadesErrorProvider;
    }
}