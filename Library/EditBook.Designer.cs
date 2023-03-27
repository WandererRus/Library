namespace Library
{
    partial class EditBook
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
            label8 = new Label();
            tb_name = new TextBox();
            label5 = new Label();
            tb_pages = new TextBox();
            label6 = new Label();
            tb_publishYear = new TextBox();
            label3 = new Label();
            tb_author = new TextBox();
            label4 = new Label();
            tb_genre = new TextBox();
            label2 = new Label();
            tb_publisher = new TextBox();
            label1 = new Label();
            tb_id = new TextBox();
            btn_cancel = new Button();
            btn_edit = new Button();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(63, 248);
            label8.Name = "label8";
            label8.Size = new Size(56, 15);
            label8.TabIndex = 31;
            label8.Text = "Publisher";
            // 
            // tb_name
            // 
            tb_name.Location = new Point(474, 195);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(263, 23);
            tb_name.TabIndex = 30;
            tb_name.TextChanged += tb_name_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(63, 177);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 29;
            label5.Text = "Pages";
            // 
            // tb_pages
            // 
            tb_pages.Location = new Point(63, 195);
            tb_pages.Name = "tb_pages";
            tb_pages.Size = new Size(263, 23);
            tb_pages.TabIndex = 28;
            tb_pages.TextChanged += tb_pages_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(63, 104);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 27;
            label6.Text = "Publish year";
            // 
            // tb_publishYear
            // 
            tb_publishYear.Location = new Point(63, 122);
            tb_publishYear.Name = "tb_publishYear";
            tb_publishYear.Size = new Size(263, 23);
            tb_publishYear.TabIndex = 26;
            tb_publishYear.TextChanged += tb_publishYear_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(474, 40);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 25;
            label3.Text = "genre";
            // 
            // tb_author
            // 
            tb_author.Location = new Point(474, 122);
            tb_author.Name = "tb_author";
            tb_author.Size = new Size(263, 23);
            tb_author.TabIndex = 24;
            tb_author.TextChanged += tb_author_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(474, 104);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 23;
            label4.Text = "author";
            // 
            // tb_genre
            // 
            tb_genre.Location = new Point(472, 58);
            tb_genre.Name = "tb_genre";
            tb_genre.Size = new Size(263, 23);
            tb_genre.TabIndex = 22;
            tb_genre.TextChanged += tb_genre_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(474, 177);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 21;
            label2.Text = "name";
            // 
            // tb_publisher
            // 
            tb_publisher.Location = new Point(63, 266);
            tb_publisher.Name = "tb_publisher";
            tb_publisher.Size = new Size(263, 23);
            tb_publisher.TabIndex = 20;
            tb_publisher.TextChanged += tb_publisher_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 40);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 19;
            label1.Text = "id";
            // 
            // tb_id
            // 
            tb_id.Location = new Point(63, 58);
            tb_id.Name = "tb_id";
            tb_id.Size = new Size(263, 23);
            tb_id.TabIndex = 18;
            tb_id.TextChanged += tb_id_TextChanged;
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(472, 387);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(75, 23);
            btn_cancel.TabIndex = 17;
            btn_cancel.Text = "Отмена";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(174, 388);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(75, 23);
            btn_edit.TabIndex = 16;
            btn_edit.Text = "Сохранить";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // EditBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(tb_name);
            Controls.Add(label5);
            Controls.Add(tb_pages);
            Controls.Add(label6);
            Controls.Add(tb_publishYear);
            Controls.Add(label3);
            Controls.Add(tb_author);
            Controls.Add(label4);
            Controls.Add(tb_genre);
            Controls.Add(label2);
            Controls.Add(tb_publisher);
            Controls.Add(label1);
            Controls.Add(tb_id);
            Controls.Add(btn_cancel);
            Controls.Add(btn_edit);
            Name = "EditBook";
            Text = "EditBook";
            Load += EditBook_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Label label5;
        private Label label6;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private Button btn_cancel;
        private Button btn_edit;
        public TextBox tb_name;
        public TextBox tb_pages;
        public TextBox tb_publishYear;
        public TextBox tb_author;
        public TextBox tb_genre;
        public TextBox tb_publisher;
        public TextBox tb_id;
    }
}