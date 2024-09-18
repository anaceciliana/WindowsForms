namespace WindowsForms
{
    partial class pagina_inicial
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(1001, 366);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 655);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.pagina_inicial_Load);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(132, 366);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(690, 655);
            this.panel2.TabIndex = 1;
            this.panel2.Click += new System.EventHandler(this.pagina_inicial_Load);
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pagina_inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsForms.Properties.Resources.Design_sem_nome__1_1;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "pagina_inicial";
            this.Text = "pagina_inicial";
            this.Load += new System.EventHandler(this.pagina_inicial_Load);
            this.Click += new System.EventHandler(this.pagina_inicial_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}