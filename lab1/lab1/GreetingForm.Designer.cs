namespace lab1
{
    partial class GreetingForm
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
            this.MainSplitter = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridEchipaj = new System.Windows.Forms.DataGridView();
            this.labelEchipaj = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridPirati = new System.Windows.Forms.DataGridView();
            this.labelPirati = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitter)).BeginInit();
            this.MainSplitter.Panel1.SuspendLayout();
            this.MainSplitter.Panel2.SuspendLayout();
            this.MainSplitter.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEchipaj)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPirati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainSplitter
            // 
            this.MainSplitter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainSplitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.MainSplitter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MainSplitter.Location = new System.Drawing.Point(3, 3);
            this.MainSplitter.Name = "MainSplitter";
            this.MainSplitter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // MainSplitter.Panel1
            // 
            this.MainSplitter.Panel1.Controls.Add(this.panel1);
            this.MainSplitter.Panel1.Controls.Add(this.labelEchipaj);
            // 
            // MainSplitter.Panel2
            // 
            this.MainSplitter.Panel2.Controls.Add(this.panel2);
            this.MainSplitter.Panel2.Controls.Add(this.labelPirati);
            this.MainSplitter.Size = new System.Drawing.Size(790, 609);
            this.MainSplitter.SplitterDistance = 304;
            this.MainSplitter.SplitterWidth = 7;
            this.MainSplitter.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.gridEchipaj);
            this.panel1.Location = new System.Drawing.Point(17, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 256);
            this.panel1.TabIndex = 2;
            // 
            // gridEchipaj
            // 
            this.gridEchipaj.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridEchipaj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEchipaj.Location = new System.Drawing.Point(0, 0);
            this.gridEchipaj.Name = "gridEchipaj";
            this.gridEchipaj.RowHeadersWidth = 51;
            this.gridEchipaj.RowTemplate.Height = 24;
            this.gridEchipaj.Size = new System.Drawing.Size(754, 253);
            this.gridEchipaj.TabIndex = 1;
            // 
            // labelEchipaj
            // 
            this.labelEchipaj.AutoSize = true;
            this.labelEchipaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEchipaj.Location = new System.Drawing.Point(12, 9);
            this.labelEchipaj.Name = "labelEchipaj";
            this.labelEchipaj.Size = new System.Drawing.Size(107, 29);
            this.labelEchipaj.TabIndex = 0;
            this.labelEchipaj.Text = "Echipaje";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.gridPirati);
            this.panel2.Location = new System.Drawing.Point(17, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(757, 251);
            this.panel2.TabIndex = 3;
            // 
            // gridPirati
            // 
            this.gridPirati.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPirati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPirati.Location = new System.Drawing.Point(0, 0);
            this.gridPirati.Name = "gridPirati";
            this.gridPirati.RowHeadersWidth = 51;
            this.gridPirati.RowTemplate.Height = 24;
            this.gridPirati.Size = new System.Drawing.Size(754, 247);
            this.gridPirati.TabIndex = 2;
            // 
            // labelPirati
            // 
            this.labelPirati.AutoSize = true;
            this.labelPirati.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPirati.Location = new System.Drawing.Point(12, 5);
            this.labelPirati.Name = "labelPirati";
            this.labelPirati.Size = new System.Drawing.Size(68, 29);
            this.labelPirati.TabIndex = 2;
            this.labelPirati.Text = "Pirati";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Location = new System.Drawing.Point(3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.MainSplitter);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Size = new System.Drawing.Size(905, 619);
            this.splitContainer1.SplitterDistance = 800;
            this.splitContainer1.SplitterWidth = 7;
            this.splitContainer1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // GreetingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 623);
            this.Controls.Add(this.splitContainer1);
            this.Name = "GreetingForm";
            this.Text = "Lab1";
            this.Load += new System.EventHandler(this.GreetingForm_Load);
            this.MainSplitter.Panel1.ResumeLayout(false);
            this.MainSplitter.Panel1.PerformLayout();
            this.MainSplitter.Panel2.ResumeLayout(false);
            this.MainSplitter.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitter)).EndInit();
            this.MainSplitter.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridEchipaj)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPirati)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer MainSplitter;
        private System.Windows.Forms.DataGridView gridEchipaj;
        private System.Windows.Forms.Label labelEchipaj;
        private System.Windows.Forms.Label labelPirati;
        private System.Windows.Forms.DataGridView gridPirati;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}