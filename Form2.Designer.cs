namespace datascience_project
{
    partial class Form2
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
            this.ddl_sub_category_name = new System.Windows.Forms.ComboBox();
            this.subcategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datasience_dbDataSet3 = new datascience_project.datasience_dbDataSet3();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textbox_link_text = new System.Windows.Forms.TextBox();
            this.textbox_sub_link_text = new System.Windows.Forms.TextBox();
            this.textbox_link_content = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.linkidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linktextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sublinktextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkcontentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linktypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subcategoryidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.datasience_dbDataSet7 = new datascience_project.datasience_dbDataSet7();
            this.linkBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.datasience_dbDataSet4 = new datascience_project.datasience_dbDataSet4();
            this.ddll_link_type = new System.Windows.Forms.ComboBox();
            this.datasience_dbDataSet2 = new datascience_project.datasience_dbDataSet2();
            this.linkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.linkTableAdapter = new datascience_project.datasience_dbDataSet2TableAdapters.linkTableAdapter();
            this.subcategoryTableAdapter = new datascience_project.datasience_dbDataSet3TableAdapters.subcategoryTableAdapter();
            this.linkTableAdapter1 = new datascience_project.datasience_dbDataSet4TableAdapters.linkTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.datetime = new System.Windows.Forms.DateTimePicker();
            this.linkTableAdapter2 = new datascience_project.datasience_dbDataSet7TableAdapters.linkTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.subcategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasience_dbDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasience_dbDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasience_dbDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasience_dbDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ddl_sub_category_name
            // 
            this.ddl_sub_category_name.DataSource = this.subcategoryBindingSource;
            this.ddl_sub_category_name.DisplayMember = "subcategory_name";
            this.ddl_sub_category_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_sub_category_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddl_sub_category_name.FormattingEnabled = true;
            this.ddl_sub_category_name.Location = new System.Drawing.Point(239, 50);
            this.ddl_sub_category_name.Margin = new System.Windows.Forms.Padding(2);
            this.ddl_sub_category_name.Name = "ddl_sub_category_name";
            this.ddl_sub_category_name.Size = new System.Drawing.Size(679, 33);
            this.ddl_sub_category_name.TabIndex = 1;
            this.ddl_sub_category_name.ValueMember = "subcategory_id";
            // 
            // subcategoryBindingSource
            // 
            this.subcategoryBindingSource.DataMember = "subcategory";
            this.subcategoryBindingSource.DataSource = this.datasience_dbDataSet3;
            // 
            // datasience_dbDataSet3
            // 
            this.datasience_dbDataSet3.DataSetName = "datasience_dbDataSet3";
            this.datasience_dbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "sub category name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "link text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "sub link text";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 192);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "link content";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 244);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "link type";
            // 
            // textbox_link_text
            // 
            this.textbox_link_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_link_text.Location = new System.Drawing.Point(239, 96);
            this.textbox_link_text.Margin = new System.Windows.Forms.Padding(2);
            this.textbox_link_text.Multiline = true;
            this.textbox_link_text.Name = "textbox_link_text";
            this.textbox_link_text.Size = new System.Drawing.Size(679, 33);
            this.textbox_link_text.TabIndex = 12;
            // 
            // textbox_sub_link_text
            // 
            this.textbox_sub_link_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_sub_link_text.Location = new System.Drawing.Point(239, 140);
            this.textbox_sub_link_text.Margin = new System.Windows.Forms.Padding(2);
            this.textbox_sub_link_text.Multiline = true;
            this.textbox_sub_link_text.Name = "textbox_sub_link_text";
            this.textbox_sub_link_text.Size = new System.Drawing.Size(679, 33);
            this.textbox_sub_link_text.TabIndex = 13;
            // 
            // textbox_link_content
            // 
            this.textbox_link_content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_link_content.Location = new System.Drawing.Point(239, 192);
            this.textbox_link_content.Margin = new System.Windows.Forms.Padding(2);
            this.textbox_link_content.Multiline = true;
            this.textbox_link_content.Name = "textbox_link_content";
            this.textbox_link_content.Size = new System.Drawing.Size(679, 33);
            this.textbox_link_content.TabIndex = 14;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(514, 325);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 38);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(647, 325);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(129, 38);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(788, 325);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(129, 38);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.linkidDataGridViewTextBoxColumn,
            this.linktextDataGridViewTextBoxColumn,
            this.sublinktextDataGridViewTextBoxColumn,
            this.linkcontentDataGridViewTextBoxColumn,
            this.linktypeDataGridViewTextBoxColumn,
            this.subcategoryidDataGridViewTextBoxColumn,
            this.user_fullname,
            this.date});
            this.dataGridView1.DataSource = this.linkBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(46, 378);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(881, 268);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // linkidDataGridViewTextBoxColumn
            // 
            this.linkidDataGridViewTextBoxColumn.DataPropertyName = "link_id";
            this.linkidDataGridViewTextBoxColumn.HeaderText = "link_id";
            this.linkidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.linkidDataGridViewTextBoxColumn.Name = "linkidDataGridViewTextBoxColumn";
            this.linkidDataGridViewTextBoxColumn.ReadOnly = true;
            this.linkidDataGridViewTextBoxColumn.Width = 150;
            // 
            // linktextDataGridViewTextBoxColumn
            // 
            this.linktextDataGridViewTextBoxColumn.DataPropertyName = "link_text";
            this.linktextDataGridViewTextBoxColumn.HeaderText = "link_text";
            this.linktextDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.linktextDataGridViewTextBoxColumn.Name = "linktextDataGridViewTextBoxColumn";
            this.linktextDataGridViewTextBoxColumn.Width = 150;
            // 
            // sublinktextDataGridViewTextBoxColumn
            // 
            this.sublinktextDataGridViewTextBoxColumn.DataPropertyName = "sub_link_text";
            this.sublinktextDataGridViewTextBoxColumn.HeaderText = "sub_link_text";
            this.sublinktextDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sublinktextDataGridViewTextBoxColumn.Name = "sublinktextDataGridViewTextBoxColumn";
            this.sublinktextDataGridViewTextBoxColumn.Width = 150;
            // 
            // linkcontentDataGridViewTextBoxColumn
            // 
            this.linkcontentDataGridViewTextBoxColumn.DataPropertyName = "link_content";
            this.linkcontentDataGridViewTextBoxColumn.HeaderText = "link_content";
            this.linkcontentDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.linkcontentDataGridViewTextBoxColumn.Name = "linkcontentDataGridViewTextBoxColumn";
            this.linkcontentDataGridViewTextBoxColumn.Width = 150;
            // 
            // linktypeDataGridViewTextBoxColumn
            // 
            this.linktypeDataGridViewTextBoxColumn.DataPropertyName = "link_type";
            this.linktypeDataGridViewTextBoxColumn.HeaderText = "link_type";
            this.linktypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.linktypeDataGridViewTextBoxColumn.Name = "linktypeDataGridViewTextBoxColumn";
            this.linktypeDataGridViewTextBoxColumn.Width = 150;
            // 
            // subcategoryidDataGridViewTextBoxColumn
            // 
            this.subcategoryidDataGridViewTextBoxColumn.DataPropertyName = "sub_category_id";
            this.subcategoryidDataGridViewTextBoxColumn.HeaderText = "sub_category_id";
            this.subcategoryidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.subcategoryidDataGridViewTextBoxColumn.Name = "subcategoryidDataGridViewTextBoxColumn";
            this.subcategoryidDataGridViewTextBoxColumn.Width = 150;
            // 
            // user_fullname
            // 
            this.user_fullname.DataPropertyName = "user_fullname";
            this.user_fullname.HeaderText = "user_fullname";
            this.user_fullname.Name = "user_fullname";
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "date";
            this.date.Name = "date";
            // 
            // linkBindingSource2
            // 
            this.linkBindingSource2.DataMember = "link";
            this.linkBindingSource2.DataSource = this.datasience_dbDataSet7;
            // 
            // datasience_dbDataSet7
            // 
            this.datasience_dbDataSet7.DataSetName = "datasience_dbDataSet7";
            this.datasience_dbDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // linkBindingSource1
            // 
            this.linkBindingSource1.DataMember = "link";
            this.linkBindingSource1.DataSource = this.datasience_dbDataSet4;
            // 
            // datasience_dbDataSet4
            // 
            this.datasience_dbDataSet4.DataSetName = "datasience_dbDataSet4";
            this.datasience_dbDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ddll_link_type
            // 
            this.ddll_link_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddll_link_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddll_link_type.FormattingEnabled = true;
            this.ddll_link_type.Items.AddRange(new object[] {
            "Youtube",
            "LinkedIn",
            "Google",
            "Website"});
            this.ddll_link_type.Location = new System.Drawing.Point(239, 244);
            this.ddll_link_type.Margin = new System.Windows.Forms.Padding(2);
            this.ddll_link_type.Name = "ddll_link_type";
            this.ddll_link_type.Size = new System.Drawing.Size(679, 33);
            this.ddll_link_type.TabIndex = 20;
            // 
            // datasience_dbDataSet2
            // 
            this.datasience_dbDataSet2.DataSetName = "datasience_dbDataSet2";
            this.datasience_dbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // linkBindingSource
            // 
            this.linkBindingSource.DataMember = "link";
            this.linkBindingSource.DataSource = this.datasience_dbDataSet2;
            // 
            // linkTableAdapter
            // 
            this.linkTableAdapter.ClearBeforeFill = true;
            // 
            // subcategoryTableAdapter
            // 
            this.subcategoryTableAdapter.ClearBeforeFill = true;
            // 
            // linkTableAdapter1
            // 
            this.linkTableAdapter1.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoryToolStripMenuItem,
            this.subCategoryToolStripMenuItem,
            this.linkToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(957, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            this.categoryToolStripMenuItem.Text = "Category";
            this.categoryToolStripMenuItem.Click += new System.EventHandler(this.categoryToolStripMenuItem_Click);
            // 
            // subCategoryToolStripMenuItem
            // 
            this.subCategoryToolStripMenuItem.Name = "subCategoryToolStripMenuItem";
            this.subCategoryToolStripMenuItem.Size = new System.Drawing.Size(90, 22);
            this.subCategoryToolStripMenuItem.Text = "Sub Category";
            this.subCategoryToolStripMenuItem.Click += new System.EventHandler(this.subCategoryToolStripMenuItem_Click);
            // 
            // linkToolStripMenuItem
            // 
            this.linkToolStripMenuItem.Name = "linkToolStripMenuItem";
            this.linkToolStripMenuItem.Size = new System.Drawing.Size(41, 22);
            this.linkToolStripMenuItem.Text = "Link";
            this.linkToolStripMenuItem.Click += new System.EventHandler(this.linkToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(47, 22);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 349);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 25);
            this.button1.TabIndex = 22;
            this.button1.Text = "Export to Excel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 288);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 26);
            this.label6.TabIndex = 23;
            this.label6.Text = "date";
            // 
            // datetime
            // 
            this.datetime.Location = new System.Drawing.Point(239, 291);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(678, 20);
            this.datetime.TabIndex = 24;
            // 
            // linkTableAdapter2
            // 
            this.linkTableAdapter2.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 689);
            this.Controls.Add(this.datetime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ddll_link_type);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textbox_link_content);
            this.Controls.Add(this.textbox_sub_link_text);
            this.Controls.Add(this.textbox_link_text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ddl_sub_category_name);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.subcategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasience_dbDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasience_dbDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasience_dbDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasience_dbDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox ddl_sub_category_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textbox_link_text;
        private System.Windows.Forms.TextBox textbox_sub_link_text;
        private System.Windows.Forms.TextBox textbox_link_content;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox ddll_link_type;
        private datasience_dbDataSet2 datasience_dbDataSet2;
        private System.Windows.Forms.BindingSource linkBindingSource;
        private datasience_dbDataSet2TableAdapters.linkTableAdapter linkTableAdapter;
        private datasience_dbDataSet3 datasience_dbDataSet3;
        private System.Windows.Forms.BindingSource subcategoryBindingSource;
        private datasience_dbDataSet3TableAdapters.subcategoryTableAdapter subcategoryTableAdapter;
        private datasience_dbDataSet4 datasience_dbDataSet4;
        private System.Windows.Forms.BindingSource linkBindingSource1;
        private datasience_dbDataSet4TableAdapters.linkTableAdapter linkTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn linktextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sublinktextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkcontentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn linktypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subcategoryidDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linkToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker datetime;
        private datasience_dbDataSet7 datasience_dbDataSet7;
        private System.Windows.Forms.BindingSource linkBindingSource2;
        private datasience_dbDataSet7TableAdapters.linkTableAdapter linkTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}