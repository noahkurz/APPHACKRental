namespace APPHACKRental
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnSearch = new System.Windows.Forms.Button();
            this.zip_textbox = new System.Windows.Forms.TextBox();
            this.state_textbox = new System.Windows.Forms.TextBox();
            this.city_textbox = new System.Windows.Forms.TextBox();
            this.street_textbox = new System.Windows.Forms.TextBox();
            this.googleMap = new Microsoft.Toolkit.Forms.UI.Controls.WebViewCompatible();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer1.Panel1.Controls.Add(this.zip_textbox);
            this.splitContainer1.Panel1.Controls.Add(this.state_textbox);
            this.splitContainer1.Panel1.Controls.Add(this.city_textbox);
            this.splitContainer1.Panel1.Controls.Add(this.street_textbox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.googleMap);
            this.splitContainer1.Size = new System.Drawing.Size(954, 643);
            this.splitContainer1.SplitterDistance = 318;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(131, 582);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(145, 49);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // zip_textbox
            // 
            this.zip_textbox.Location = new System.Drawing.Point(34, 174);
            this.zip_textbox.Name = "zip_textbox";
            this.zip_textbox.Size = new System.Drawing.Size(168, 20);
            this.zip_textbox.TabIndex = 3;
            // 
            // state_textbox
            // 
            this.state_textbox.Location = new System.Drawing.Point(34, 125);
            this.state_textbox.Name = "state_textbox";
            this.state_textbox.Size = new System.Drawing.Size(168, 20);
            this.state_textbox.TabIndex = 2;
            // 
            // city_textbox
            // 
            this.city_textbox.Location = new System.Drawing.Point(34, 70);
            this.city_textbox.Name = "city_textbox";
            this.city_textbox.Size = new System.Drawing.Size(168, 20);
            this.city_textbox.TabIndex = 1;
            // 
            // street_textbox
            // 
            this.street_textbox.Location = new System.Drawing.Point(34, 23);
            this.street_textbox.Name = "street_textbox";
            this.street_textbox.Size = new System.Drawing.Size(168, 20);
            this.street_textbox.TabIndex = 0;
            // 
            // googleMap
            // 
            this.googleMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.googleMap.Location = new System.Drawing.Point(0, 0);
            this.googleMap.Name = "googleMap";
            this.googleMap.Size = new System.Drawing.Size(632, 643);
            this.googleMap.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 643);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox zip_textbox;
        private System.Windows.Forms.TextBox state_textbox;
        private System.Windows.Forms.TextBox city_textbox;
        private System.Windows.Forms.TextBox street_textbox;
        private Microsoft.Toolkit.Forms.UI.Controls.WebViewCompatible googleMap;
    }
}

