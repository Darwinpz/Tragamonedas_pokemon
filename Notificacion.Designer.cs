namespace Tragamonedas_pokemon
{
    partial class Notificacion
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LBL_MENSAJE = new System.Windows.Forms.Label();
            this.BTN_ACEPTAR = new System.Windows.Forms.Button();
            this.IMAGEN = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMAGEN)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.IMAGEN, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LBL_MENSAJE, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BTN_ACEPTAR, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(503, 366);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // LBL_MENSAJE
            // 
            this.LBL_MENSAJE.AutoSize = true;
            this.LBL_MENSAJE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_MENSAJE.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_MENSAJE.Location = new System.Drawing.Point(3, 274);
            this.LBL_MENSAJE.Name = "LBL_MENSAJE";
            this.LBL_MENSAJE.Size = new System.Drawing.Size(497, 36);
            this.LBL_MENSAJE.TabIndex = 1;
            this.LBL_MENSAJE.Text = "-";
            this.LBL_MENSAJE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTN_ACEPTAR
            // 
            this.BTN_ACEPTAR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_ACEPTAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ACEPTAR.Location = new System.Drawing.Point(3, 313);
            this.BTN_ACEPTAR.Name = "BTN_ACEPTAR";
            this.BTN_ACEPTAR.Size = new System.Drawing.Size(497, 50);
            this.BTN_ACEPTAR.TabIndex = 2;
            this.BTN_ACEPTAR.Text = "ACEPTAR";
            this.BTN_ACEPTAR.UseVisualStyleBackColor = true;
            this.BTN_ACEPTAR.Click += new System.EventHandler(this.BTN_ACEPTAR_Click);
            // 
            // IMAGEN
            // 
            this.IMAGEN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IMAGEN.Location = new System.Drawing.Point(3, 3);
            this.IMAGEN.Name = "IMAGEN";
            this.IMAGEN.Size = new System.Drawing.Size(497, 268);
            this.IMAGEN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IMAGEN.TabIndex = 0;
            this.IMAGEN.TabStop = false;
            // 
            // Notificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(503, 366);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Notificacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notificacion";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMAGEN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox IMAGEN;
        private System.Windows.Forms.Label LBL_MENSAJE;
        private System.Windows.Forms.Button BTN_ACEPTAR;
    }
}