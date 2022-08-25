
namespace BombonesPP2022.Windows
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.GenerosButton = new System.Windows.Forms.Button();
            this.AutoresButton = new System.Windows.Forms.Button();
            this.EditorialesButton = new System.Windows.Forms.Button();
            this.CerrarButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-320, -135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Neptuno SRL";
            // 
            // GenerosButton
            // 
            this.GenerosButton.Image = global::BombonesPP2022.Windows.Properties.Resources.nut_32px;
            this.GenerosButton.Location = new System.Drawing.Point(62, 177);
            this.GenerosButton.Name = "GenerosButton";
            this.GenerosButton.Size = new System.Drawing.Size(143, 67);
            this.GenerosButton.TabIndex = 7;
            this.GenerosButton.Text = "Generos Literarios";
            this.GenerosButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GenerosButton.UseVisualStyleBackColor = true;
            this.GenerosButton.Click += new System.EventHandler(this.GenerosButton_Click);
            // 
            // AutoresButton
            // 
            this.AutoresButton.Image = global::BombonesPP2022.Windows.Properties.Resources.chocolate_bar_32px;
            this.AutoresButton.Location = new System.Drawing.Point(62, 87);
            this.AutoresButton.Name = "AutoresButton";
            this.AutoresButton.Size = new System.Drawing.Size(143, 67);
            this.AutoresButton.TabIndex = 7;
            this.AutoresButton.Text = "Autores";
            this.AutoresButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AutoresButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AutoresButton.UseVisualStyleBackColor = true;
            this.AutoresButton.Click += new System.EventHandler(this.AutoresButton_Click);
            // 
            // EditorialesButton
            // 
            this.EditorialesButton.Image = global::BombonesPP2022.Windows.Properties.Resources.america_32px;
            this.EditorialesButton.Location = new System.Drawing.Point(62, 265);
            this.EditorialesButton.Name = "EditorialesButton";
            this.EditorialesButton.Size = new System.Drawing.Size(143, 67);
            this.EditorialesButton.TabIndex = 7;
            this.EditorialesButton.Text = "Editoriales";
            this.EditorialesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EditorialesButton.UseVisualStyleBackColor = true;
            this.EditorialesButton.Click += new System.EventHandler(this.EditorialesButton_Click);
            // 
            // CerrarButton
            // 
            this.CerrarButton.Image = global::BombonesPP2022.Windows.Properties.Resources.shutdown_50px;
            this.CerrarButton.Location = new System.Drawing.Point(98, 365);
            this.CerrarButton.Name = "CerrarButton";
            this.CerrarButton.Size = new System.Drawing.Size(75, 59);
            this.CerrarButton.TabIndex = 6;
            this.CerrarButton.UseVisualStyleBackColor = true;
            this.CerrarButton.Click += new System.EventHandler(this.CerrarButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "BIBLIOTECA";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GenerosButton);
            this.Controls.Add(this.AutoresButton);
            this.Controls.Add(this.EditorialesButton);
            this.Controls.Add(this.CerrarButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CerrarButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EditorialesButton;
        private System.Windows.Forms.Button AutoresButton;
        private System.Windows.Forms.Button GenerosButton;
        private System.Windows.Forms.Label label2;
    }
}

