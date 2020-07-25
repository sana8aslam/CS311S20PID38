namespace FOOD
{
    partial class Form3
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Encodebtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.compressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codedFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decompressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chosbtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(226, 249);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(365, 56);
            this.listBox1.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(23, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(730, 63);
            this.label1.TabIndex = 46;
            this.label1.Text = "File Compression Application";
            // 
            // Encodebtn
            // 
            this.Encodebtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.Encodebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Encodebtn.ForeColor = System.Drawing.Color.White;
            this.Encodebtn.Location = new System.Drawing.Point(309, 344);
            this.Encodebtn.Name = "Encodebtn";
            this.Encodebtn.Size = new System.Drawing.Size(118, 42);
            this.Encodebtn.TabIndex = 45;
            this.Encodebtn.Text = "Decompress";
            this.Encodebtn.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compressToolStripMenuItem,
            this.codedFileToolStripMenuItem,
            this.decompressToolStripMenuItem,
            this.mergeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 36);
            this.menuStrip1.TabIndex = 48;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // compressToolStripMenuItem
            // 
            this.compressToolStripMenuItem.BackColor = System.Drawing.Color.CornflowerBlue;
            this.compressToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.compressToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.compressToolStripMenuItem.Name = "compressToolStripMenuItem";
            this.compressToolStripMenuItem.Size = new System.Drawing.Size(115, 32);
            this.compressToolStripMenuItem.Text = "Compress";
            // 
            // codedFileToolStripMenuItem
            // 
            this.codedFileToolStripMenuItem.BackColor = System.Drawing.Color.CornflowerBlue;
            this.codedFileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.codedFileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.codedFileToolStripMenuItem.Name = "codedFileToolStripMenuItem";
            this.codedFileToolStripMenuItem.Size = new System.Drawing.Size(122, 32);
            this.codedFileToolStripMenuItem.Text = "Coded File";
            // 
            // decompressToolStripMenuItem
            // 
            this.decompressToolStripMenuItem.BackColor = System.Drawing.Color.CornflowerBlue;
            this.decompressToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.decompressToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.decompressToolStripMenuItem.Name = "decompressToolStripMenuItem";
            this.decompressToolStripMenuItem.Size = new System.Drawing.Size(139, 32);
            this.decompressToolStripMenuItem.Text = "Decompress";
            // 
            // mergeToolStripMenuItem
            // 
            this.mergeToolStripMenuItem.BackColor = System.Drawing.Color.CornflowerBlue;
            this.mergeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.mergeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.mergeToolStripMenuItem.Name = "mergeToolStripMenuItem";
            this.mergeToolStripMenuItem.Size = new System.Drawing.Size(85, 32);
            this.mergeToolStripMenuItem.Text = "Merge";
            // 
            // chosbtn
            // 
            this.chosbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.chosbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chosbtn.ForeColor = System.Drawing.Color.White;
            this.chosbtn.Location = new System.Drawing.Point(54, 260);
            this.chosbtn.Name = "chosbtn";
            this.chosbtn.Size = new System.Drawing.Size(134, 33);
            this.chosbtn.TabIndex = 49;
            this.chosbtn.Text = "Choose File";
            this.chosbtn.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chosbtn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Encodebtn);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form3";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Encodebtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem compressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codedFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decompressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mergeToolStripMenuItem;
        private System.Windows.Forms.Button chosbtn;
    }
}