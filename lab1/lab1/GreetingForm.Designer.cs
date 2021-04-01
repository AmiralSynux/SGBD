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
            this.gridMarinar = new System.Windows.Forms.DataGridView();
            this.labelPirati = new System.Windows.Forms.Label();
            this.deletePirat = new System.Windows.Forms.Button();
            this.updateMarinar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.refresh = new System.Windows.Forms.Button();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.adauga = new System.Windows.Forms.Button();
            this.cod_echipajText = new lab1.WaterMarkTextBox();
            this.cod_individText = new lab1.WaterMarkTextBox();
            this.aliasText = new lab1.WaterMarkTextBox();
            this.functieText = new lab1.WaterMarkTextBox();
            this.cod_marinarText = new lab1.WaterMarkTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitter)).BeginInit();
            this.MainSplitter.Panel1.SuspendLayout();
            this.MainSplitter.Panel2.SuspendLayout();
            this.MainSplitter.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEchipaj)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMarinar)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainSplitter
            // 
            this.MainSplitter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainSplitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.MainSplitter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MainSplitter.Location = new System.Drawing.Point(12, 5);
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
            this.MainSplitter.Size = new System.Drawing.Size(836, 411);
            this.MainSplitter.SplitterDistance = 205;
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
            this.panel1.Size = new System.Drawing.Size(803, 157);
            this.panel1.TabIndex = 2;
            // 
            // gridEchipaj
            // 
            this.gridEchipaj.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridEchipaj.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridEchipaj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEchipaj.Location = new System.Drawing.Point(0, 0);
            this.gridEchipaj.Name = "gridEchipaj";
            this.gridEchipaj.ReadOnly = true;
            this.gridEchipaj.RowHeadersWidth = 51;
            this.gridEchipaj.RowTemplate.Height = 24;
            this.gridEchipaj.Size = new System.Drawing.Size(800, 154);
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
            this.panel2.Controls.Add(this.gridMarinar);
            this.panel2.Location = new System.Drawing.Point(17, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(803, 131);
            this.panel2.TabIndex = 3;
            // 
            // gridMarinar
            // 
            this.gridMarinar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridMarinar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridMarinar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMarinar.Location = new System.Drawing.Point(0, 0);
            this.gridMarinar.Name = "gridMarinar";
            this.gridMarinar.ReadOnly = true;
            this.gridMarinar.RowHeadersWidth = 51;
            this.gridMarinar.RowTemplate.Height = 24;
            this.gridMarinar.Size = new System.Drawing.Size(800, 127);
            this.gridMarinar.TabIndex = 2;
            this.gridMarinar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMarinar_CellClick);
            // 
            // labelPirati
            // 
            this.labelPirati.AutoSize = true;
            this.labelPirati.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPirati.Location = new System.Drawing.Point(12, 5);
            this.labelPirati.Name = "labelPirati";
            this.labelPirati.Size = new System.Drawing.Size(100, 29);
            this.labelPirati.TabIndex = 2;
            this.labelPirati.Text = "Marinari";
            // 
            // deletePirat
            // 
            this.deletePirat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePirat.Location = new System.Drawing.Point(3, 3);
            this.deletePirat.Name = "deletePirat";
            this.deletePirat.Size = new System.Drawing.Size(149, 35);
            this.deletePirat.TabIndex = 1;
            this.deletePirat.Text = "Delete Marinar";
            this.deletePirat.UseVisualStyleBackColor = true;
            this.deletePirat.Click += new System.EventHandler(this.deletePirat_Click);
            // 
            // updateMarinar
            // 
            this.updateMarinar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateMarinar.Location = new System.Drawing.Point(3, 41);
            this.updateMarinar.Name = "updateMarinar";
            this.updateMarinar.Size = new System.Drawing.Size(149, 35);
            this.updateMarinar.TabIndex = 2;
            this.updateMarinar.Text = "Update Marinar";
            this.updateMarinar.UseVisualStyleBackColor = true;
            this.updateMarinar.Click += new System.EventHandler(this.updateMarinar_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.adauga);
            this.panel3.Controls.Add(this.cod_echipajText);
            this.panel3.Controls.Add(this.cod_individText);
            this.panel3.Controls.Add(this.aliasText);
            this.panel3.Controls.Add(this.functieText);
            this.panel3.Controls.Add(this.cod_marinarText);
            this.panel3.Controls.Add(this.refresh);
            this.panel3.Controls.Add(this.deletePirat);
            this.panel3.Controls.Add(this.updateMarinar);
            this.panel3.Location = new System.Drawing.Point(854, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(159, 411);
            this.panel3.TabIndex = 3;
            // 
            // refresh
            // 
            this.refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.Location = new System.Drawing.Point(3, 123);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(149, 35);
            this.refresh.TabIndex = 3;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // adauga
            // 
            this.adauga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adauga.Location = new System.Drawing.Point(3, 82);
            this.adauga.Name = "adauga";
            this.adauga.Size = new System.Drawing.Size(149, 35);
            this.adauga.TabIndex = 9;
            this.adauga.Text = "Adauga Marinar";
            this.adauga.UseVisualStyleBackColor = true;
            this.adauga.Click += new System.EventHandler(this.adauga_Click);
            // 
            // cod_echipajText
            // 
            this.cod_echipajText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cod_echipajText.Location = new System.Drawing.Point(3, 300);
            this.cod_echipajText.Name = "cod_echipajText";
            this.cod_echipajText.Size = new System.Drawing.Size(149, 27);
            this.cod_echipajText.TabIndex = 8;
            this.cod_echipajText.WaterMarkColor = System.Drawing.Color.Gray;
            this.cod_echipajText.WaterMarkText = "cod echipaj(int)";
            // 
            // cod_individText
            // 
            this.cod_individText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cod_individText.Location = new System.Drawing.Point(3, 267);
            this.cod_individText.Name = "cod_individText";
            this.cod_individText.Size = new System.Drawing.Size(149, 27);
            this.cod_individText.TabIndex = 7;
            this.cod_individText.WaterMarkColor = System.Drawing.Color.Gray;
            this.cod_individText.WaterMarkText = "cod individ(int)";
            // 
            // aliasText
            // 
            this.aliasText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aliasText.Location = new System.Drawing.Point(3, 234);
            this.aliasText.Name = "aliasText";
            this.aliasText.Size = new System.Drawing.Size(149, 27);
            this.aliasText.TabIndex = 6;
            this.aliasText.WaterMarkColor = System.Drawing.Color.Gray;
            this.aliasText.WaterMarkText = "alias(string)";
            // 
            // functieText
            // 
            this.functieText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.functieText.Location = new System.Drawing.Point(3, 201);
            this.functieText.Name = "functieText";
            this.functieText.Size = new System.Drawing.Size(149, 27);
            this.functieText.TabIndex = 5;
            this.functieText.WaterMarkColor = System.Drawing.Color.Gray;
            this.functieText.WaterMarkText = "functie(string)";
            // 
            // cod_marinarText
            // 
            this.cod_marinarText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cod_marinarText.Location = new System.Drawing.Point(3, 168);
            this.cod_marinarText.Name = "cod_marinarText";
            this.cod_marinarText.Size = new System.Drawing.Size(149, 27);
            this.cod_marinarText.TabIndex = 4;
            this.cod_marinarText.WaterMarkColor = System.Drawing.Color.Gray;
            this.cod_marinarText.WaterMarkText = "cod marinar(int)";
            // 
            // GreetingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 428);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.MainSplitter);
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
            ((System.ComponentModel.ISupportInitialize)(this.gridMarinar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer MainSplitter;
        private System.Windows.Forms.DataGridView gridEchipaj;
        private System.Windows.Forms.Label labelEchipaj;
        private System.Windows.Forms.Label labelPirati;
        private System.Windows.Forms.DataGridView gridMarinar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button deletePirat;
        private System.Windows.Forms.Button updateMarinar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button refresh;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private WaterMarkTextBox cod_echipajText;
        private WaterMarkTextBox cod_individText;
        private WaterMarkTextBox aliasText;
        private WaterMarkTextBox functieText;
        private WaterMarkTextBox cod_marinarText;
        private System.Windows.Forms.Button adauga;
    }
}