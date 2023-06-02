namespace КонференцияИнформационнаяБезопасность
{
    partial class ЖюриМодераторы
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
            this.коджюриDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.полDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рольDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.почтаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датарожденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.странаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.направлениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.парольDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фотоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.жюриBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.a4DataSet = new КонференцияИнформационнаяБезопасность.a4DataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.кодмодератораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.полDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рольDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.почтаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датарожденияDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.странаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.направлениеDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.мероприятиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.парольDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фотоDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.модераторыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.жюриTableAdapter = new КонференцияИнформационнаяБезопасность.a4DataSetTableAdapters.ЖюриTableAdapter();
            this.модераторыTableAdapter = new КонференцияИнформационнаяБезопасность.a4DataSetTableAdapters.МодераторыTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.жюриBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.модераторыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
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
            this.label1.Location = new System.Drawing.Point(286, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Жюри\\Модератора";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.коджюриDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn,
            this.полDataGridViewTextBoxColumn,
            this.рольDataGridViewTextBoxColumn,
            this.почтаDataGridViewTextBoxColumn,
            this.датарожденияDataGridViewTextBoxColumn,
            this.странаDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn,
            this.направлениеDataGridViewTextBoxColumn,
            this.парольDataGridViewTextBoxColumn,
            this.фотоDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.жюриBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 202);
            this.dataGridView1.TabIndex = 4;
            // 
            // коджюриDataGridViewTextBoxColumn
            // 
            this.коджюриDataGridViewTextBoxColumn.DataPropertyName = "Код_жюри";
            this.коджюриDataGridViewTextBoxColumn.HeaderText = "Код_жюри";
            this.коджюриDataGridViewTextBoxColumn.Name = "коджюриDataGridViewTextBoxColumn";
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            // 
            // полDataGridViewTextBoxColumn
            // 
            this.полDataGridViewTextBoxColumn.DataPropertyName = "Пол";
            this.полDataGridViewTextBoxColumn.HeaderText = "Пол";
            this.полDataGridViewTextBoxColumn.Name = "полDataGridViewTextBoxColumn";
            // 
            // рольDataGridViewTextBoxColumn
            // 
            this.рольDataGridViewTextBoxColumn.DataPropertyName = "Роль";
            this.рольDataGridViewTextBoxColumn.HeaderText = "Роль";
            this.рольDataGridViewTextBoxColumn.Name = "рольDataGridViewTextBoxColumn";
            // 
            // почтаDataGridViewTextBoxColumn
            // 
            this.почтаDataGridViewTextBoxColumn.DataPropertyName = "Почта";
            this.почтаDataGridViewTextBoxColumn.HeaderText = "Почта";
            this.почтаDataGridViewTextBoxColumn.Name = "почтаDataGridViewTextBoxColumn";
            // 
            // датарожденияDataGridViewTextBoxColumn
            // 
            this.датарожденияDataGridViewTextBoxColumn.DataPropertyName = "Дата_рождения";
            this.датарожденияDataGridViewTextBoxColumn.HeaderText = "Дата_рождения";
            this.датарожденияDataGridViewTextBoxColumn.Name = "датарожденияDataGridViewTextBoxColumn";
            // 
            // странаDataGridViewTextBoxColumn
            // 
            this.странаDataGridViewTextBoxColumn.DataPropertyName = "Страна";
            this.странаDataGridViewTextBoxColumn.HeaderText = "Страна";
            this.странаDataGridViewTextBoxColumn.Name = "странаDataGridViewTextBoxColumn";
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            // 
            // направлениеDataGridViewTextBoxColumn
            // 
            this.направлениеDataGridViewTextBoxColumn.DataPropertyName = "Направление";
            this.направлениеDataGridViewTextBoxColumn.HeaderText = "Направление";
            this.направлениеDataGridViewTextBoxColumn.Name = "направлениеDataGridViewTextBoxColumn";
            // 
            // парольDataGridViewTextBoxColumn
            // 
            this.парольDataGridViewTextBoxColumn.DataPropertyName = "Пароль";
            this.парольDataGridViewTextBoxColumn.HeaderText = "Пароль";
            this.парольDataGridViewTextBoxColumn.Name = "парольDataGridViewTextBoxColumn";
            // 
            // фотоDataGridViewTextBoxColumn
            // 
            this.фотоDataGridViewTextBoxColumn.DataPropertyName = "Фото";
            this.фотоDataGridViewTextBoxColumn.HeaderText = "Фото";
            this.фотоDataGridViewTextBoxColumn.Name = "фотоDataGridViewTextBoxColumn";
            // 
            // жюриBindingSource
            // 
            this.жюриBindingSource.DataMember = "Жюри";
            this.жюриBindingSource.DataSource = this.a4DataSet;
            // 
            // a4DataSet
            // 
            this.a4DataSet.DataSetName = "a4DataSet";
            this.a4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодмодератораDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn1,
            this.полDataGridViewTextBoxColumn1,
            this.рольDataGridViewTextBoxColumn1,
            this.почтаDataGridViewTextBoxColumn1,
            this.датарожденияDataGridViewTextBoxColumn1,
            this.странаDataGridViewTextBoxColumn1,
            this.телефонDataGridViewTextBoxColumn1,
            this.направлениеDataGridViewTextBoxColumn1,
            this.мероприятиеDataGridViewTextBoxColumn,
            this.парольDataGridViewTextBoxColumn1,
            this.фотоDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.модераторыBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(-1, 271);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(800, 189);
            this.dataGridView2.TabIndex = 5;
            // 
            // кодмодератораDataGridViewTextBoxColumn
            // 
            this.кодмодератораDataGridViewTextBoxColumn.DataPropertyName = "Код_модератора";
            this.кодмодератораDataGridViewTextBoxColumn.HeaderText = "Код_модератора";
            this.кодмодератораDataGridViewTextBoxColumn.Name = "кодмодератораDataGridViewTextBoxColumn";
            // 
            // фИОDataGridViewTextBoxColumn1
            // 
            this.фИОDataGridViewTextBoxColumn1.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn1.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn1.Name = "фИОDataGridViewTextBoxColumn1";
            // 
            // полDataGridViewTextBoxColumn1
            // 
            this.полDataGridViewTextBoxColumn1.DataPropertyName = "Пол";
            this.полDataGridViewTextBoxColumn1.HeaderText = "Пол";
            this.полDataGridViewTextBoxColumn1.Name = "полDataGridViewTextBoxColumn1";
            // 
            // рольDataGridViewTextBoxColumn1
            // 
            this.рольDataGridViewTextBoxColumn1.DataPropertyName = "Роль";
            this.рольDataGridViewTextBoxColumn1.HeaderText = "Роль";
            this.рольDataGridViewTextBoxColumn1.Name = "рольDataGridViewTextBoxColumn1";
            // 
            // почтаDataGridViewTextBoxColumn1
            // 
            this.почтаDataGridViewTextBoxColumn1.DataPropertyName = "Почта";
            this.почтаDataGridViewTextBoxColumn1.HeaderText = "Почта";
            this.почтаDataGridViewTextBoxColumn1.Name = "почтаDataGridViewTextBoxColumn1";
            // 
            // датарожденияDataGridViewTextBoxColumn1
            // 
            this.датарожденияDataGridViewTextBoxColumn1.DataPropertyName = "Дата_рождения";
            this.датарожденияDataGridViewTextBoxColumn1.HeaderText = "Дата_рождения";
            this.датарожденияDataGridViewTextBoxColumn1.Name = "датарожденияDataGridViewTextBoxColumn1";
            // 
            // странаDataGridViewTextBoxColumn1
            // 
            this.странаDataGridViewTextBoxColumn1.DataPropertyName = "Страна";
            this.странаDataGridViewTextBoxColumn1.HeaderText = "Страна";
            this.странаDataGridViewTextBoxColumn1.Name = "странаDataGridViewTextBoxColumn1";
            // 
            // телефонDataGridViewTextBoxColumn1
            // 
            this.телефонDataGridViewTextBoxColumn1.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn1.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn1.Name = "телефонDataGridViewTextBoxColumn1";
            // 
            // направлениеDataGridViewTextBoxColumn1
            // 
            this.направлениеDataGridViewTextBoxColumn1.DataPropertyName = "Направление";
            this.направлениеDataGridViewTextBoxColumn1.HeaderText = "Направление";
            this.направлениеDataGridViewTextBoxColumn1.Name = "направлениеDataGridViewTextBoxColumn1";
            // 
            // мероприятиеDataGridViewTextBoxColumn
            // 
            this.мероприятиеDataGridViewTextBoxColumn.DataPropertyName = "Мероприятие";
            this.мероприятиеDataGridViewTextBoxColumn.HeaderText = "Мероприятие";
            this.мероприятиеDataGridViewTextBoxColumn.Name = "мероприятиеDataGridViewTextBoxColumn";
            // 
            // парольDataGridViewTextBoxColumn1
            // 
            this.парольDataGridViewTextBoxColumn1.DataPropertyName = "Пароль";
            this.парольDataGridViewTextBoxColumn1.HeaderText = "Пароль";
            this.парольDataGridViewTextBoxColumn1.Name = "парольDataGridViewTextBoxColumn1";
            // 
            // фотоDataGridViewTextBoxColumn1
            // 
            this.фотоDataGridViewTextBoxColumn1.DataPropertyName = "Фото";
            this.фотоDataGridViewTextBoxColumn1.HeaderText = "Фото";
            this.фотоDataGridViewTextBoxColumn1.Name = "фотоDataGridViewTextBoxColumn1";
            // 
            // модераторыBindingSource
            // 
            this.модераторыBindingSource.DataMember = "Модераторы";
            this.модераторыBindingSource.DataSource = this.a4DataSet;
            // 
            // жюриTableAdapter
            // 
            this.жюриTableAdapter.ClearBeforeFill = true;
            // 
            // модераторыTableAdapter
            // 
            this.модераторыTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(336, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 56);
            this.button1.TabIndex = 13;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ЖюриМодераторы
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "ЖюриМодераторы";
            this.Text = "ЖюриМодераторы";
            this.Load += new System.EventHandler(this.ЖюриМодераторы_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.жюриBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.модераторыBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private a4DataSet a4DataSet;
        private System.Windows.Forms.BindingSource жюриBindingSource;
        private a4DataSetTableAdapters.ЖюриTableAdapter жюриTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn коджюриDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn полDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn рольDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn почтаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датарожденияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn странаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn направлениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn парольDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фотоDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource модераторыBindingSource;
        private a4DataSetTableAdapters.МодераторыTableAdapter модераторыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодмодератораDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn полDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn рольDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn почтаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn датарожденияDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn странаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn направлениеDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn мероприятиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn парольDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn фотоDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button button1;
    }
}