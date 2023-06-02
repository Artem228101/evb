namespace КонференцияИнформационнаяБезопасность
{
    partial class Мероприятия
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.a4DataSet = new КонференцияИнформационнаяБезопасность.a4DataSet();
            this.мероприятияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.мероприятияTableAdapter = new КонференцияИнформационнаяБезопасность.a4DataSetTableAdapters.МероприятияTableAdapter();
            this.кодмероприятияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cобытиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.деньDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.городDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.мероприятияBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 63);
            this.panel1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(2, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "назад";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(299, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Мероприятия";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодмероприятияDataGridViewTextBoxColumn,
            this.cобытиеDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn,
            this.деньDataGridViewTextBoxColumn,
            this.городDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.мероприятияBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(134, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 220);
            this.dataGridView1.TabIndex = 4;
            // 
            // a4DataSet
            // 
            this.a4DataSet.DataSetName = "a4DataSet";
            this.a4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // мероприятияBindingSource
            // 
            this.мероприятияBindingSource.DataMember = "Мероприятия";
            this.мероприятияBindingSource.DataSource = this.a4DataSet;
            // 
            // мероприятияTableAdapter
            // 
            this.мероприятияTableAdapter.ClearBeforeFill = true;
            // 
            // кодмероприятияDataGridViewTextBoxColumn
            // 
            this.кодмероприятияDataGridViewTextBoxColumn.DataPropertyName = "Код_мероприятия";
            this.кодмероприятияDataGridViewTextBoxColumn.HeaderText = "Код_мероприятия";
            this.кодмероприятияDataGridViewTextBoxColumn.Name = "кодмероприятияDataGridViewTextBoxColumn";
            // 
            // cобытиеDataGridViewTextBoxColumn
            // 
            this.cобытиеDataGridViewTextBoxColumn.DataPropertyName = "Cобытие";
            this.cобытиеDataGridViewTextBoxColumn.HeaderText = "Cобытие";
            this.cобытиеDataGridViewTextBoxColumn.Name = "cобытиеDataGridViewTextBoxColumn";
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            // 
            // деньDataGridViewTextBoxColumn
            // 
            this.деньDataGridViewTextBoxColumn.DataPropertyName = "День";
            this.деньDataGridViewTextBoxColumn.HeaderText = "День";
            this.деньDataGridViewTextBoxColumn.Name = "деньDataGridViewTextBoxColumn";
            // 
            // городDataGridViewTextBoxColumn
            // 
            this.городDataGridViewTextBoxColumn.DataPropertyName = "Город";
            this.городDataGridViewTextBoxColumn.HeaderText = "Город";
            this.городDataGridViewTextBoxColumn.Name = "городDataGridViewTextBoxColumn";
            // 
            // Мероприятия
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Мероприятия";
            this.Text = "Мероприятия";
            this.Load += new System.EventHandler(this.Мероприятия_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.мероприятияBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private a4DataSet a4DataSet;
        private System.Windows.Forms.BindingSource мероприятияBindingSource;
        private a4DataSetTableAdapters.МероприятияTableAdapter мероприятияTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодмероприятияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cобытиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn деньDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn городDataGridViewTextBoxColumn;
    }
}