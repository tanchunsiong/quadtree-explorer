namespace QuadTreeExplorer
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
            this.tbTopRight = new System.Windows.Forms.TextBox();
            this.tbTopLeft = new System.Windows.Forms.TextBox();
            this.tbBotLeft = new System.Windows.Forms.TextBox();
            this.tbBotRight = new System.Windows.Forms.TextBox();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.tbQuadTree = new System.Windows.Forms.TextBox();
            this.Go = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbTopRight
            // 
            this.tbTopRight.Location = new System.Drawing.Point(197, 44);
            this.tbTopRight.Multiline = true;
            this.tbTopRight.Name = "tbTopRight";
            this.tbTopRight.Size = new System.Drawing.Size(100, 41);
            this.tbTopRight.TabIndex = 1;
            // 
            // tbTopLeft
            // 
            this.tbTopLeft.Location = new System.Drawing.Point(13, 44);
            this.tbTopLeft.Multiline = true;
            this.tbTopLeft.Name = "tbTopLeft";
            this.tbTopLeft.Size = new System.Drawing.Size(100, 41);
            this.tbTopLeft.TabIndex = 1;
            // 
            // tbBotLeft
            // 
            this.tbBotLeft.Location = new System.Drawing.Point(12, 381);
            this.tbBotLeft.Multiline = true;
            this.tbBotLeft.Name = "tbBotLeft";
            this.tbBotLeft.Size = new System.Drawing.Size(100, 41);
            this.tbBotLeft.TabIndex = 1;
            // 
            // tbBotRight
            // 
            this.tbBotRight.Location = new System.Drawing.Point(196, 381);
            this.tbBotRight.Multiline = true;
            this.tbBotRight.Name = "tbBotRight";
            this.tbBotRight.Size = new System.Drawing.Size(100, 41);
            this.tbBotRight.TabIndex = 1;
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(12, 91);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScrollBarsEnabled = false;
            this.webBrowser.Size = new System.Drawing.Size(284, 284);
            this.webBrowser.TabIndex = 2;
            // 
            // tbQuadTree
            // 
            this.tbQuadTree.Location = new System.Drawing.Point(13, 13);
            this.tbQuadTree.Name = "tbQuadTree";
            this.tbQuadTree.Size = new System.Drawing.Size(190, 20);
            this.tbQuadTree.TabIndex = 3;
            this.tbQuadTree.Text = "1322322311031";
            // 
            // Go
            // 
            this.Go.Location = new System.Drawing.Point(222, 11);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(75, 23);
            this.Go.TabIndex = 4;
            this.Go.Text = "Go";
            this.Go.UseVisualStyleBackColor = true;
            this.Go.Click += new System.EventHandler(this.Go_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 467);
            this.Controls.Add(this.Go);
            this.Controls.Add(this.tbQuadTree);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.tbBotLeft);
            this.Controls.Add(this.tbTopLeft);
            this.Controls.Add(this.tbBotRight);
            this.Controls.Add(this.tbTopRight);
            this.Name = "Form1";
            this.Text = "QuadTree Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTopRight;
        private System.Windows.Forms.TextBox tbTopLeft;
        private System.Windows.Forms.TextBox tbBotLeft;
        private System.Windows.Forms.TextBox tbBotRight;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.TextBox tbQuadTree;
        private System.Windows.Forms.Button Go;
    }
}

