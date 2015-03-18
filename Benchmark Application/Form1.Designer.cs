namespace Benchmark_Application
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
            this.gbxLoad = new System.Windows.Forms.GroupBox();
            this.lbxPeople = new System.Windows.Forms.ListBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.gbxSort = new System.Windows.Forms.GroupBox();
            this.btnSortZA = new System.Windows.Forms.Button();
            this.btnSortAZ = new System.Windows.Forms.Button();
            this.lbxSorted = new System.Windows.Forms.ListBox();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.rdoStartsWith = new System.Windows.Forms.RadioButton();
            this.rdoEndsWith = new System.Windows.Forms.RadioButton();
            this.rdoContains = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbxSearch = new System.Windows.Forms.ListBox();
            this.gbxLoad.SuspendLayout();
            this.gbxSort.SuspendLayout();
            this.gbxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxLoad
            // 
            this.gbxLoad.Controls.Add(this.lbxPeople);
            this.gbxLoad.Controls.Add(this.btnLoad);
            this.gbxLoad.Location = new System.Drawing.Point(12, 12);
            this.gbxLoad.Name = "gbxLoad";
            this.gbxLoad.Size = new System.Drawing.Size(163, 247);
            this.gbxLoad.TabIndex = 0;
            this.gbxLoad.TabStop = false;
            this.gbxLoad.Text = "Load";
            // 
            // lbxPeople
            // 
            this.lbxPeople.FormattingEnabled = true;
            this.lbxPeople.Location = new System.Drawing.Point(19, 48);
            this.lbxPeople.Name = "lbxPeople";
            this.lbxPeople.Size = new System.Drawing.Size(120, 173);
            this.lbxPeople.TabIndex = 1;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(19, 19);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load People";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // gbxSort
            // 
            this.gbxSort.Controls.Add(this.btnSortZA);
            this.gbxSort.Controls.Add(this.btnSortAZ);
            this.gbxSort.Controls.Add(this.lbxSorted);
            this.gbxSort.Location = new System.Drawing.Point(181, 12);
            this.gbxSort.Name = "gbxSort";
            this.gbxSort.Size = new System.Drawing.Size(163, 247);
            this.gbxSort.TabIndex = 1;
            this.gbxSort.TabStop = false;
            this.gbxSort.Text = "Sort";
            // 
            // btnSortZA
            // 
            this.btnSortZA.Location = new System.Drawing.Point(89, 19);
            this.btnSortZA.Name = "btnSortZA";
            this.btnSortZA.Size = new System.Drawing.Size(51, 23);
            this.btnSortZA.TabIndex = 4;
            this.btnSortZA.Text = "Sort ZA";
            this.btnSortZA.UseVisualStyleBackColor = true;
            this.btnSortZA.Click += new System.EventHandler(this.btnSortZA_Click);
            // 
            // btnSortAZ
            // 
            this.btnSortAZ.Location = new System.Drawing.Point(20, 19);
            this.btnSortAZ.Name = "btnSortAZ";
            this.btnSortAZ.Size = new System.Drawing.Size(51, 23);
            this.btnSortAZ.TabIndex = 3;
            this.btnSortAZ.Text = "Sort AZ";
            this.btnSortAZ.UseVisualStyleBackColor = true;
            this.btnSortAZ.Click += new System.EventHandler(this.btnSortAZ_Click);
            // 
            // lbxSorted
            // 
            this.lbxSorted.FormattingEnabled = true;
            this.lbxSorted.Location = new System.Drawing.Point(20, 48);
            this.lbxSorted.Name = "lbxSorted";
            this.lbxSorted.Size = new System.Drawing.Size(120, 173);
            this.lbxSorted.TabIndex = 2;
            // 
            // gbxSearch
            // 
            this.gbxSearch.Controls.Add(this.btnSearch);
            this.gbxSearch.Controls.Add(this.tbxSearch);
            this.gbxSearch.Controls.Add(this.rdoStartsWith);
            this.gbxSearch.Controls.Add(this.rdoEndsWith);
            this.gbxSearch.Controls.Add(this.rdoContains);
            this.gbxSearch.Controls.Add(this.btnSave);
            this.gbxSearch.Controls.Add(this.lbxSearch);
            this.gbxSearch.Location = new System.Drawing.Point(350, 12);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(274, 247);
            this.gbxSearch.TabIndex = 2;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Search";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(19, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(19, 48);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(100, 20);
            this.tbxSearch.TabIndex = 8;
            // 
            // rdoStartsWith
            // 
            this.rdoStartsWith.AutoSize = true;
            this.rdoStartsWith.Location = new System.Drawing.Point(19, 75);
            this.rdoStartsWith.Name = "rdoStartsWith";
            this.rdoStartsWith.Size = new System.Drawing.Size(77, 17);
            this.rdoStartsWith.TabIndex = 7;
            this.rdoStartsWith.TabStop = true;
            this.rdoStartsWith.Text = "Starts With";
            this.rdoStartsWith.UseVisualStyleBackColor = true;
            // 
            // rdoEndsWith
            // 
            this.rdoEndsWith.AutoSize = true;
            this.rdoEndsWith.Location = new System.Drawing.Point(19, 98);
            this.rdoEndsWith.Name = "rdoEndsWith";
            this.rdoEndsWith.Size = new System.Drawing.Size(74, 17);
            this.rdoEndsWith.TabIndex = 6;
            this.rdoEndsWith.TabStop = true;
            this.rdoEndsWith.Text = "Ends With";
            this.rdoEndsWith.UseVisualStyleBackColor = true;
            // 
            // rdoContains
            // 
            this.rdoContains.AutoSize = true;
            this.rdoContains.Location = new System.Drawing.Point(19, 121);
            this.rdoContains.Name = "rdoContains";
            this.rdoContains.Size = new System.Drawing.Size(66, 17);
            this.rdoContains.TabIndex = 5;
            this.rdoContains.TabStop = true;
            this.rdoContains.Text = "Contains";
            this.rdoContains.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(19, 162);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 40);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save Selected";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbxSearch
            // 
            this.lbxSearch.FormattingEnabled = true;
            this.lbxSearch.Location = new System.Drawing.Point(135, 48);
            this.lbxSearch.Name = "lbxSearch";
            this.lbxSearch.Size = new System.Drawing.Size(120, 173);
            this.lbxSearch.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 271);
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.gbxSort);
            this.Controls.Add(this.gbxLoad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxLoad.ResumeLayout(false);
            this.gbxSort.ResumeLayout(false);
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxLoad;
        private System.Windows.Forms.GroupBox gbxSort;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ListBox lbxPeople;
        private System.Windows.Forms.Button btnSortZA;
        private System.Windows.Forms.Button btnSortAZ;
        private System.Windows.Forms.ListBox lbxSorted;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.RadioButton rdoStartsWith;
        private System.Windows.Forms.RadioButton rdoEndsWith;
        private System.Windows.Forms.RadioButton rdoContains;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox lbxSearch;
    }
}

