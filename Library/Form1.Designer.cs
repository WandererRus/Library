namespace Library
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgv_library = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            author = new DataGridViewTextBoxColumn();
            genre = new DataGridViewTextBoxColumn();
            publishYear = new DataGridViewTextBoxColumn();
            countPages = new DataGridViewTextBoxColumn();
            publisher = new DataGridViewTextBoxColumn();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            загрузитьИзБазыToolStripMenuItem = new ToolStripMenuItem();
            загрузитьИзXMLToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            сохранитьВБазуToolStripMenuItem = new ToolStripMenuItem();
            сохранитьВXMLToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            выходToolStripMenuItem = new ToolStripMenuItem();
            создатьToolStripMenuItem = new ToolStripMenuItem();
            редактироватьToolStripMenuItem = new ToolStripMenuItem();
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            фильтрToolStripMenuItem = new ToolStripMenuItem();
            поИмениToolStripMenuItem = new ToolStripMenuItem();
            nameFilterASCToolStripMenuItem = new ToolStripMenuItem();
            nameFilterDESCToolStripMenuItem = new ToolStripMenuItem();
            поАвторуToolStripMenuItem = new ToolStripMenuItem();
            aSCToolStripMenuItem1 = new ToolStripMenuItem();
            dESCToolStripMenuItem1 = new ToolStripMenuItem();
            поИздательствуToolStripMenuItem = new ToolStripMenuItem();
            aSCToolStripMenuItem2 = new ToolStripMenuItem();
            dESCToolStripMenuItem2 = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgv_library).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_library
            // 
            dgv_library.AllowUserToAddRows = false;
            dgv_library.AllowUserToDeleteRows = false;
            dgv_library.AllowUserToResizeColumns = false;
            dgv_library.AllowUserToResizeRows = false;
            dgv_library.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_library.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_library.Columns.AddRange(new DataGridViewColumn[] { id, name, author, genre, publishYear, countPages, publisher });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgv_library.DefaultCellStyle = dataGridViewCellStyle1;
            dgv_library.Dock = DockStyle.Fill;
            dgv_library.Location = new Point(0, 24);
            dgv_library.MultiSelect = false;
            dgv_library.Name = "dgv_library";
            dgv_library.ReadOnly = true;
            dgv_library.RowHeadersVisible = false;
            dgv_library.RowTemplate.Height = 25;
            dgv_library.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_library.Size = new Size(800, 426);
            dgv_library.TabIndex = 0;
            dgv_library.CellContentClick += dgv_library_CellContentClick;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // name
            // 
            name.HeaderText = "Name";
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // author
            // 
            author.HeaderText = "Author";
            author.Name = "author";
            author.ReadOnly = true;
            // 
            // genre
            // 
            genre.HeaderText = "Genre";
            genre.Name = "genre";
            genre.ReadOnly = true;
            // 
            // publishYear
            // 
            publishYear.HeaderText = "Publish Year";
            publishYear.Name = "publishYear";
            publishYear.ReadOnly = true;
            // 
            // countPages
            // 
            countPages.HeaderText = "Pages";
            countPages.Name = "countPages";
            countPages.ReadOnly = true;
            // 
            // publisher
            // 
            publisher.HeaderText = "Publisher";
            publisher.Name = "publisher";
            publisher.ReadOnly = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, создатьToolStripMenuItem, редактироватьToolStripMenuItem, удалитьToolStripMenuItem, фильтрToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { загрузитьИзБазыToolStripMenuItem, загрузитьИзXMLToolStripMenuItem, toolStripSeparator2, сохранитьВБазуToolStripMenuItem, сохранитьВXMLToolStripMenuItem, toolStripSeparator1, выходToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // загрузитьИзБазыToolStripMenuItem
            // 
            загрузитьИзБазыToolStripMenuItem.Name = "загрузитьИзБазыToolStripMenuItem";
            загрузитьИзБазыToolStripMenuItem.Size = new Size(173, 22);
            загрузитьИзБазыToolStripMenuItem.Text = "Загрузить из базы";
            // 
            // загрузитьИзXMLToolStripMenuItem
            // 
            загрузитьИзXMLToolStripMenuItem.Name = "загрузитьИзXMLToolStripMenuItem";
            загрузитьИзXMLToolStripMenuItem.Size = new Size(173, 22);
            загрузитьИзXMLToolStripMenuItem.Text = "Загрузить из XML";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(170, 6);
            // 
            // сохранитьВБазуToolStripMenuItem
            // 
            сохранитьВБазуToolStripMenuItem.Name = "сохранитьВБазуToolStripMenuItem";
            сохранитьВБазуToolStripMenuItem.Size = new Size(173, 22);
            сохранитьВБазуToolStripMenuItem.Text = "Сохранить в базу";
            // 
            // сохранитьВXMLToolStripMenuItem
            // 
            сохранитьВXMLToolStripMenuItem.Name = "сохранитьВXMLToolStripMenuItem";
            сохранитьВXMLToolStripMenuItem.Size = new Size(173, 22);
            сохранитьВXMLToolStripMenuItem.Text = "Сохранить в XML";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(170, 6);
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(173, 22);
            выходToolStripMenuItem.Text = "Выход";
            // 
            // создатьToolStripMenuItem
            // 
            создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            создатьToolStripMenuItem.Size = new Size(62, 20);
            создатьToolStripMenuItem.Text = "Создать";
            создатьToolStripMenuItem.Click += создатьToolStripMenuItem_Click;
            // 
            // редактироватьToolStripMenuItem
            // 
            редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            редактироватьToolStripMenuItem.Size = new Size(99, 20);
            редактироватьToolStripMenuItem.Text = "Редактировать";
            редактироватьToolStripMenuItem.Click += редактироватьToolStripMenuItem_Click;
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(63, 20);
            удалитьToolStripMenuItem.Text = "Удалить";
            удалитьToolStripMenuItem.Click += удалитьToolStripMenuItem_Click;
            // 
            // фильтрToolStripMenuItem
            // 
            фильтрToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { поИмениToolStripMenuItem, поАвторуToolStripMenuItem, поИздательствуToolStripMenuItem });
            фильтрToolStripMenuItem.Name = "фильтрToolStripMenuItem";
            фильтрToolStripMenuItem.Size = new Size(60, 20);
            фильтрToolStripMenuItem.Text = "Фильтр";
            // 
            // поИмениToolStripMenuItem
            // 
            поИмениToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nameFilterASCToolStripMenuItem, nameFilterDESCToolStripMenuItem });
            поИмениToolStripMenuItem.Name = "поИмениToolStripMenuItem";
            поИмениToolStripMenuItem.Size = new Size(180, 22);
            поИмениToolStripMenuItem.Text = "По имени";
            // 
            // nameFilterASCToolStripMenuItem
            // 
            nameFilterASCToolStripMenuItem.Name = "nameFilterASCToolStripMenuItem";
            nameFilterASCToolStripMenuItem.Size = new Size(180, 22);
            nameFilterASCToolStripMenuItem.Text = "ASC";
            nameFilterASCToolStripMenuItem.Click += nameFilterASCToolStripMenuItem_Click;
            // 
            // nameFilterDESCToolStripMenuItem
            // 
            nameFilterDESCToolStripMenuItem.Name = "nameFilterDESCToolStripMenuItem";
            nameFilterDESCToolStripMenuItem.Size = new Size(180, 22);
            nameFilterDESCToolStripMenuItem.Text = "DESC";
            nameFilterDESCToolStripMenuItem.Click += nameFilterDESCToolStripMenuItem_Click;
            // 
            // поАвторуToolStripMenuItem
            // 
            поАвторуToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aSCToolStripMenuItem1, dESCToolStripMenuItem1 });
            поАвторуToolStripMenuItem.Name = "поАвторуToolStripMenuItem";
            поАвторуToolStripMenuItem.Size = new Size(180, 22);
            поАвторуToolStripMenuItem.Text = "По автору";
            // 
            // aSCToolStripMenuItem1
            // 
            aSCToolStripMenuItem1.Name = "aSCToolStripMenuItem1";
            aSCToolStripMenuItem1.Size = new Size(102, 22);
            aSCToolStripMenuItem1.Text = "ASC";
            // 
            // dESCToolStripMenuItem1
            // 
            dESCToolStripMenuItem1.Name = "dESCToolStripMenuItem1";
            dESCToolStripMenuItem1.Size = new Size(102, 22);
            dESCToolStripMenuItem1.Text = "DESC";
            // 
            // поИздательствуToolStripMenuItem
            // 
            поИздательствуToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aSCToolStripMenuItem2, dESCToolStripMenuItem2 });
            поИздательствуToolStripMenuItem.Name = "поИздательствуToolStripMenuItem";
            поИздательствуToolStripMenuItem.Size = new Size(180, 22);
            поИздательствуToolStripMenuItem.Text = "По издательству";
            // 
            // aSCToolStripMenuItem2
            // 
            aSCToolStripMenuItem2.Name = "aSCToolStripMenuItem2";
            aSCToolStripMenuItem2.Size = new Size(102, 22);
            aSCToolStripMenuItem2.Text = "ASC";
            // 
            // dESCToolStripMenuItem2
            // 
            dESCToolStripMenuItem2.Name = "dESCToolStripMenuItem2";
            dESCToolStripMenuItem2.Size = new Size(102, 22);
            dESCToolStripMenuItem2.Text = "DESC";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgv_library);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_library).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_library;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn author;
        private DataGridViewTextBoxColumn genre;
        private DataGridViewTextBoxColumn publishYear;
        private DataGridViewTextBoxColumn countPages;
        private DataGridViewTextBoxColumn publisher;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem создатьToolStripMenuItem;
        private ToolStripMenuItem редактироватьToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private ToolStripMenuItem загрузитьИзБазыToolStripMenuItem;
        private ToolStripMenuItem загрузитьИзXMLToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem сохранитьВБазуToolStripMenuItem;
        private ToolStripMenuItem сохранитьВXMLToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem фильтрToolStripMenuItem;
        private ToolStripMenuItem поИмениToolStripMenuItem;
        private ToolStripMenuItem nameFilterASCToolStripMenuItem;
        private ToolStripMenuItem nameFilterDESCToolStripMenuItem;
        private ToolStripMenuItem поАвторуToolStripMenuItem;
        private ToolStripMenuItem aSCToolStripMenuItem1;
        private ToolStripMenuItem dESCToolStripMenuItem1;
        private ToolStripMenuItem поИздательствуToolStripMenuItem;
        private ToolStripMenuItem aSCToolStripMenuItem2;
        private ToolStripMenuItem dESCToolStripMenuItem2;
    }
}