namespace WindowsFormsApplication3
{
    partial class FormBienvenida
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
            this.btnContinuar_Click2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnContinuar_Click2
            // 
            this.btnContinuar_Click2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar_Click2.Location = new System.Drawing.Point(166, 91);
            this.btnContinuar_Click2.Name = "btnContinuar_Click2";
            this.btnContinuar_Click2.Size = new System.Drawing.Size(302, 157);
            this.btnContinuar_Click2.TabIndex = 0;
            this.btnContinuar_Click2.Text = "BIENVENID@S\r\nA la Votacion Electoral\r\n";
            this.btnContinuar_Click2.UseVisualStyleBackColor = true;
            this.btnContinuar_Click2.Click += new System.EventHandler(this.btnContinuar_Click2_Click);
            // 
            // FormBienvenida
            // 
            this.ClientSize = new System.Drawing.Size(615, 353);
            this.Controls.Add(this.btnContinuar_Click2);
            this.Name = "FormBienvenida";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnContinuar_Click;
        private System.Windows.Forms.Button btnContinuar_Click2;


    }
}

