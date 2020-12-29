namespace MedicinCentre
{
    partial class Report
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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicincentreDataSet = new MedicinCentre.medicincentreDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.whoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toWhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.whatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.whenDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.sellTableAdapter = new MedicinCentre.medicincentreDataSetTableAdapters.sellTableAdapter();
            this.usersTableAdapter = new MedicinCentre.medicincentreDataSetTableAdapters.usersTableAdapter();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.medicinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.medicinTableAdapter = new MedicinCentre.medicincentreDataSetTableAdapters.medicinTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.sellBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicincentreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.usersBindingSource;
            this.comboBox2.DisplayMember = "fio";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(118, 12);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(167, 21);
            this.comboBox2.TabIndex = 35;
            this.comboBox2.ValueMember = "id";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.medicincentreDataSet;
            // 
            // medicincentreDataSet
            // 
            this.medicincentreDataSet.DataSetName = "medicincentreDataSet";
            this.medicincentreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Человек";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.whoDataGridViewTextBoxColumn,
            this.toWhoDataGridViewTextBoxColumn,
            this.whatDataGridViewTextBoxColumn,
            this.whenDDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.DataSource = this.sellBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(14, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(673, 215);
            this.dataGridView1.TabIndex = 47;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // whoDataGridViewTextBoxColumn
            // 
            this.whoDataGridViewTextBoxColumn.DataPropertyName = "who";
            this.whoDataGridViewTextBoxColumn.HeaderText = "who";
            this.whoDataGridViewTextBoxColumn.Name = "whoDataGridViewTextBoxColumn";
            this.whoDataGridViewTextBoxColumn.ReadOnly = true;
            this.whoDataGridViewTextBoxColumn.Visible = false;
            // 
            // toWhoDataGridViewTextBoxColumn
            // 
            this.toWhoDataGridViewTextBoxColumn.DataPropertyName = "toWho";
            this.toWhoDataGridViewTextBoxColumn.HeaderText = "toWho";
            this.toWhoDataGridViewTextBoxColumn.Name = "toWhoDataGridViewTextBoxColumn";
            this.toWhoDataGridViewTextBoxColumn.ReadOnly = true;
            this.toWhoDataGridViewTextBoxColumn.Visible = false;
            // 
            // whatDataGridViewTextBoxColumn
            // 
            this.whatDataGridViewTextBoxColumn.DataPropertyName = "what";
            this.whatDataGridViewTextBoxColumn.HeaderText = "what";
            this.whatDataGridViewTextBoxColumn.Name = "whatDataGridViewTextBoxColumn";
            this.whatDataGridViewTextBoxColumn.ReadOnly = true;
            this.whatDataGridViewTextBoxColumn.Visible = false;
            // 
            // whenDDataGridViewTextBoxColumn
            // 
            this.whenDDataGridViewTextBoxColumn.DataPropertyName = "whenD";
            this.whenDDataGridViewTextBoxColumn.HeaderText = "Когда";
            this.whenDDataGridViewTextBoxColumn.Name = "whenDDataGridViewTextBoxColumn";
            this.whenDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Кто продал";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Кому продал";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Что продал";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // sellBindingSource
            // 
            this.sellBindingSource.DataMember = "sell";
            this.sellBindingSource.DataSource = this.medicincentreDataSet;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(291, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(390, 23);
            this.button4.TabIndex = 49;
            this.button4.Text = "Отобразить все, что продал выбранный человек человек";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // sellTableAdapter
            // 
            this.sellTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.medicinBindingSource;
            this.comboBox3.DisplayMember = "name";
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(118, 50);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(167, 21);
            this.comboBox3.TabIndex = 50;
            this.comboBox3.ValueMember = "id";
            // 
            // medicinBindingSource
            // 
            this.medicinBindingSource.DataMember = "medicin";
            this.medicinBindingSource.DataSource = this.medicincentreDataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Лекарства";
            // 
            // medicinTableAdapter
            // 
            this.medicinTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Показано для: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 53;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(390, 23);
            this.button1.TabIndex = 57;
            this.button1.Text = "Отобразить всех, кто купил данное лекарство";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sellBindingSource1
            // 
            this.sellBindingSource1.DataMember = "sell";
            this.sellBindingSource1.DataSource = this.medicincentreDataSet;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 345);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Name = "Report";
            this.Text = "Отчеты";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Report_FormClosing);
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicincentreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private medicincentreDataSet medicincentreDataSet;
        private System.Windows.Forms.BindingSource sellBindingSource;
        private medicincentreDataSetTableAdapters.sellTableAdapter sellTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn whoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toWhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn whatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn whenDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private medicincentreDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource medicinBindingSource;
        private medicincentreDataSetTableAdapters.medicinTableAdapter medicinTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource sellBindingSource1;
    }
}