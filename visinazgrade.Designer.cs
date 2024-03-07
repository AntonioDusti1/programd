namespace visinazgrade
{
    partial class Form1
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
            this.btnIzracunaj = new System.Windows.Forms.Button();
            this.txtBrojKatova = new System.Windows.Forms.TextBox();
            this.txtVisina = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnIzracunaj
            // 
            this.btnIzracunaj.Location = new System.Drawing.Point(411, 193);
            this.btnIzracunaj.Name = "btnIzracunaj";
            this.btnIzracunaj.Size = new System.Drawing.Size(75, 23);
            this.btnIzracunaj.TabIndex = 0;
            this.btnIzracunaj.Text = "Rezultat";
            this.btnIzracunaj.UseVisualStyleBackColor = true;
            // 
            // txtBrojKatova
            // 
            this.txtBrojKatova.Location = new System.Drawing.Point(261, 161);
            this.txtBrojKatova.Name = "txtBrojKatova";
            this.txtBrojKatova.Size = new System.Drawing.Size(141, 20);
            this.txtBrojKatova.TabIndex = 1;
            // 
            // txtVisina
            // 
            this.txtVisina.Location = new System.Drawing.Point(497, 161);
            this.txtVisina.Name = "txtVisina";
            this.txtVisina.Size = new System.Drawing.Size(136, 20);
            this.txtVisina.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtVisina);
            this.Controls.Add(this.txtBrojKatova);
            this.Controls.Add(this.btnIzracunaj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIzracunaj;
        private System.Windows.Forms.TextBox txtBrojKatova;
        private System.Windows.Forms.TextBox txtVisina;
    }
}

