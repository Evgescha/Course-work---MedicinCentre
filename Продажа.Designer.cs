namespace MedicinCentre
{
    partial class Продажа
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
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicincentreDataSet = new MedicinCentre.medicincentreDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.medicinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.sellTableAdapter = new MedicinCentre.medicincentreDataSetTableAdapters.sellTableAdapter();
            this.usersTableAdapter = new MedicinCentre.medicincentreDataSetTableAdapters.usersTableAdapter();
            this.medicincentreDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicinTableAdapter = new MedicinCentre.medicincentreDataSetTableAdapters.medicinTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.warehouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouseTableAdapter = new MedicinCentre.medicincentreDataSetTableAdapters.warehouseTableAdapter();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.whatDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicincentreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicincentreDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Кто продал";
            this.label1.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.usersBindingSource;
            this.comboBox2.DisplayMember = "fio";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(113, 35);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(167, 21);
            this.comboBox2.TabIndex = 33;
            this.comboBox2.ValueMember = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Кому продал";
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.medicinBindingSource;
            this.comboBox3.DisplayMember = "name";
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(113, 62);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(167, 21);
            this.comboBox3.TabIndex = 35;
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
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Что продал";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(113, 89);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(167, 20);
            this.dateTimePicker1.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Когда";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Количество";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(113, 117);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(167, 20);
            this.textBox2.TabIndex = 37;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 23);
            this.button1.TabIndex = 43;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(265, 23);
            this.button2.TabIndex = 44;
            this.button2.Text = "Редактировать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 240);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(265, 23);
            this.button3.TabIndex = 45;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
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
            this.dataGridView1.Location = new System.Drawing.Point(298, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(651, 260);
            this.dataGridView1.TabIndex = 46;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
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
            this.whenDDataGridViewTextBoxColumn.Width = 62;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
            this.countDataGridViewTextBoxColumn.Width = 91;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Кто продал";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 89;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Кому продал";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 97;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Что продал";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 90;
            // 
            // sellBindingSource
            // 
            this.sellBindingSource.DataMember = "sell";
            this.sellBindingSource.DataSource = this.medicincentreDataSet;
            // 
            // sellTableAdapter
            // 
            this.sellTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // medicincentreDataSetBindingSource
            // 
            this.medicincentreDataSetBindingSource.DataSource = this.medicincentreDataSet;
            this.medicincentreDataSetBindingSource.Position = 0;
            // 
            // medicinTableAdapter
            // 
            this.medicinTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 20);
            this.textBox1.TabIndex = 47;
            this.textBox1.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.whatDataGridViewTextBoxColumn1,
            this.countDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.warehouseBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(298, 143);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(643, 119);
            this.dataGridView2.TabIndex = 48;
            this.dataGridView2.Visible = false;
            // 
            // warehouseBindingSource
            // 
            this.warehouseBindingSource.DataMember = "warehouse";
            this.warehouseBindingSource.DataSource = this.medicincentreDataSet;
            // 
            // warehouseTableAdapter
            // 
            this.warehouseTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.Width = 40;
            // 
            // whatDataGridViewTextBoxColumn1
            // 
            this.whatDataGridViewTextBoxColumn1.DataPropertyName = "what";
            this.whatDataGridViewTextBoxColumn1.HeaderText = "what";
            this.whatDataGridViewTextBoxColumn1.Name = "whatDataGridViewTextBoxColumn1";
            this.whatDataGridViewTextBoxColumn1.Width = 55;
            // 
            // countDataGridViewTextBoxColumn1
            // 
            this.countDataGridViewTextBoxColumn1.DataPropertyName = "count";
            this.countDataGridViewTextBoxColumn1.HeaderText = "count";
            this.countDataGridViewTextBoxColumn1.Name = "countDataGridViewTextBoxColumn1";
            this.countDataGridViewTextBoxColumn1.Width = 59;
            // 
            // Продажа
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 283);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Продажа";
            this.Text = "Продажа";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Продажа_FormClosing);
            this.Load += new System.EventHandler(this.Продажа_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicincentreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicincentreDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private medicincentreDataSet medicincentreDataSet;
        private System.Windows.Forms.BindingSource sellBindingSource;
        private medicincentreDataSetTableAdapters.sellTableAdapter sellTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private medicincentreDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource medicincentreDataSetBindingSource;
        private System.Windows.Forms.BindingSource medicinBindingSource;
        private medicincentreDataSetTableAdapters.medicinTableAdapter medicinTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn whoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toWhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn whatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn whenDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource warehouseBindingSource;
        private medicincentreDataSetTableAdapters.warehouseTableAdapter warehouseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn whatDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn1;
    }
}