namespace GameLibraryOrganizer
{
    partial class GameLibrary
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameLibrary));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DescBox = new System.Windows.Forms.TextBox();
            this.GenreBox = new System.Windows.Forms.TextBox();
            this.DevBox = new System.Windows.Forms.TextBox();
            this.ESRBBox = new System.Windows.Forms.TextBox();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSRBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Developer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gamestableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gamesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gamesDataSet = new GameLibraryOrganizer.gamesDataSet();
            this.gamestableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gamestableTableAdapter = new GameLibraryOrganizer.gamesDataSetTableAdapters.gamestableTableAdapter();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.YearBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamestableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamestableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DescBox);
            this.groupBox1.Controls.Add(this.GenreBox);
            this.groupBox1.Controls.Add(this.DevBox);
            this.groupBox1.Controls.Add(this.ESRBBox);
            this.groupBox1.Controls.Add(this.YearBox);
            this.groupBox1.Controls.Add(this.TitleBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 326);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add game";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(90, 276);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(104, 17);
            this.radioButton4.TabIndex = 10;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Completed 100%";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(90, 253);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(75, 17);
            this.radioButton3.TabIndex = 8;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Completed";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(9, 299);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(81, 17);
            this.radioButton5.TabIndex = 11;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Want to get";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(9, 276);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(77, 17);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "In progress";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(9, 253);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(75, 17);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Yet to play";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "State";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Genre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Developer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ESRB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Year";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title";
            // 
            // DescBox
            // 
            this.DescBox.AllowDrop = true;
            this.DescBox.Location = new System.Drawing.Point(9, 175);
            this.DescBox.Multiline = true;
            this.DescBox.Name = "DescBox";
            this.DescBox.Size = new System.Drawing.Size(195, 47);
            this.DescBox.TabIndex = 6;
            // 
            // GenreBox
            // 
            this.GenreBox.Location = new System.Drawing.Point(48, 123);
            this.GenreBox.Name = "GenreBox";
            this.GenreBox.Size = new System.Drawing.Size(156, 20);
            this.GenreBox.TabIndex = 5;
            // 
            // DevBox
            // 
            this.DevBox.Location = new System.Drawing.Point(68, 97);
            this.DevBox.Name = "DevBox";
            this.DevBox.Size = new System.Drawing.Size(136, 20);
            this.DevBox.TabIndex = 4;
            // 
            // ESRBBox
            // 
            this.ESRBBox.Location = new System.Drawing.Point(48, 71);
            this.ESRBBox.Name = "ESRBBox";
            this.ESRBBox.Size = new System.Drawing.Size(156, 20);
            this.ESRBBox.TabIndex = 3;
            // 
            // TitleBox
            // 
            this.TitleBox.Location = new System.Drawing.Point(48, 19);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(156, 20);
            this.TitleBox.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(33, 344);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(82, 23);
            this.AddButton.TabIndex = 12;
            this.AddButton.Text = "Add Game";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.eSRBDataGridViewTextBoxColumn,
            this.Developer,
            this.Genre,
            this.Description,
            this.State});
            this.dataGridView1.DataSource = this.gamestableBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(228, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(579, 384);
            this.dataGridView1.TabIndex = 15;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.Width = 52;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.ReadOnly = true;
            this.yearDataGridViewTextBoxColumn.Width = 54;
            // 
            // eSRBDataGridViewTextBoxColumn
            // 
            this.eSRBDataGridViewTextBoxColumn.DataPropertyName = "ESRB";
            this.eSRBDataGridViewTextBoxColumn.HeaderText = "ESRB";
            this.eSRBDataGridViewTextBoxColumn.Name = "eSRBDataGridViewTextBoxColumn";
            this.eSRBDataGridViewTextBoxColumn.ReadOnly = true;
            this.eSRBDataGridViewTextBoxColumn.Width = 61;
            // 
            // Developer
            // 
            this.Developer.DataPropertyName = "Developer";
            this.Developer.HeaderText = "Developer";
            this.Developer.Name = "Developer";
            this.Developer.ReadOnly = true;
            this.Developer.Width = 81;
            // 
            // Genre
            // 
            this.Genre.DataPropertyName = "Genre";
            this.Genre.HeaderText = "Genre";
            this.Genre.Name = "Genre";
            this.Genre.ReadOnly = true;
            this.Genre.Width = 61;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 85;
            // 
            // State
            // 
            this.State.DataPropertyName = "State";
            this.State.HeaderText = "State";
            this.State.Name = "State";
            this.State.ReadOnly = true;
            this.State.Width = 57;
            // 
            // gamestableBindingSource1
            // 
            this.gamestableBindingSource1.DataMember = "gamestable";
            this.gamestableBindingSource1.DataSource = this.gamesDataSetBindingSource;
            // 
            // gamesDataSetBindingSource
            // 
            this.gamesDataSetBindingSource.DataSource = this.gamesDataSet;
            this.gamesDataSetBindingSource.Position = 0;
            // 
            // gamesDataSet
            // 
            this.gamesDataSet.DataSetName = "gamesDataSet";
            this.gamesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gamestableBindingSource
            // 
            this.gamestableBindingSource.DataMember = "gamestable";
            this.gamestableBindingSource.DataSource = this.gamesDataSetBindingSource;
            // 
            // gamestableTableAdapter
            // 
            this.gamestableTableAdapter.ClearBeforeFill = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(121, 344);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(85, 23);
            this.DeleteButton.TabIndex = 13;
            this.DeleteButton.Text = "Delete Game";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(33, 373);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(82, 23);
            this.ClearButton.TabIndex = 14;
            this.ClearButton.Text = "Clear Fields";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click_1);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(121, 373);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(85, 23);
            this.UpdateButton.TabIndex = 16;
            this.UpdateButton.Text = "Update State";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // YearBox
            // 
            this.YearBox.Location = new System.Drawing.Point(48, 45);
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(156, 20);
            this.YearBox.TabIndex = 2;
            // 
            // GameLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 408);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(750, 447);
            this.Name = "GameLibrary";
            this.Text = "Gaming Library Organizer";
            this.Load += new System.EventHandler(this.GameLibrary_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamestableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamestableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource gamesDataSetBindingSource;
        private gamesDataSet gamesDataSet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ESRBBox;
        private System.Windows.Forms.BindingSource gamestableBindingSource;
        private gamesDataSetTableAdapters.gamestableTableAdapter gamestableTableAdapter;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DescBox;
        private System.Windows.Forms.TextBox GenreBox;
        private System.Windows.Forms.TextBox DevBox;
        private System.Windows.Forms.BindingSource gamestableBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSRBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Developer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.TextBox YearBox;
    }
}

