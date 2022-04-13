namespace WindowsFormsAppProject
{
    partial class Main
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
            this.btnstart = new System.Windows.Forms.Button();
            this.btnex = new System.Windows.Forms.Button();
            this.btnset = new System.Windows.Forms.Button();
            this.btnpro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnstart
            // 
            this.btnstart.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnstart.Location = new System.Drawing.Point(343, 185);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(150, 61);
            this.btnstart.TabIndex = 0;
            this.btnstart.Text = "START";
            this.btnstart.UseVisualStyleBackColor = true;
            // 
            // btnex
            // 
            this.btnex.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnex.Location = new System.Drawing.Point(714, 328);
            this.btnex.Name = "btnex";
            this.btnex.Size = new System.Drawing.Size(150, 61);
            this.btnex.TabIndex = 1;
            this.btnex.Text = "EXIT";
            this.btnex.UseVisualStyleBackColor = true;
            this.btnex.Click += new System.EventHandler(this.btnex_Click);
            // 
            // btnset
            // 
            this.btnset.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnset.Location = new System.Drawing.Point(714, 185);
            this.btnset.Name = "btnset";
            this.btnset.Size = new System.Drawing.Size(150, 61);
            this.btnset.TabIndex = 3;
            this.btnset.Text = "SETTINGS";
            this.btnset.UseVisualStyleBackColor = true;
            this.btnset.Click += new System.EventHandler(this.btnset_Click);
            // 
            // btnpro
            // 
            this.btnpro.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnpro.Location = new System.Drawing.Point(343, 328);
            this.btnpro.Name = "btnpro";
            this.btnpro.Size = new System.Drawing.Size(150, 61);
            this.btnpro.TabIndex = 4;
            this.btnpro.Text = "PROFILE";
            this.btnpro.UseVisualStyleBackColor = true;
            this.btnpro.Click += new System.EventHandler(this.btnpro_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1212, 583);
            this.Controls.Add(this.btnpro);
            this.Controls.Add(this.btnset);
            this.Controls.Add(this.btnex);
            this.Controls.Add(this.btnstart);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Button btnex;
        private System.Windows.Forms.Button btnset;
        private System.Windows.Forms.Button btnpro;
    }
}