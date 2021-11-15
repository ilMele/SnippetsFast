namespace SnippetsFast
{
    partial class Snippet
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Snippet));
            this.namesnp = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.envsnp = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // namesnp
            // 
            this.namesnp.AutoSize = true;
            this.namesnp.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.namesnp.Location = new System.Drawing.Point(3, 24);
            this.namesnp.Name = "namesnp";
            this.namesnp.Size = new System.Drawing.Size(39, 21);
            this.namesnp.TabIndex = 0;
            this.namesnp.Text = "title";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(0, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 3);
            this.panel1.TabIndex = 3;
            // 
            // envsnp
            // 
            this.envsnp.AutoSize = true;
            this.envsnp.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.envsnp.Location = new System.Drawing.Point(3, 0);
            this.envsnp.Name = "envsnp";
            this.envsnp.Size = new System.Drawing.Size(34, 21);
            this.envsnp.TabIndex = 4;
            this.envsnp.Text = "env";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(332, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(33, 33);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(291, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(33, 33);
            this.panel3.TabIndex = 6;
            // 
            // Snippet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.envsnp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.namesnp);
            this.Name = "Snippet";
            this.Size = new System.Drawing.Size(370, 60);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label namesnp;
        private BindingSource bindingSource1;
        private Panel panel1;
        private Label envsnp;
        private Panel panel2;
        private Panel panel3;
    }
}
