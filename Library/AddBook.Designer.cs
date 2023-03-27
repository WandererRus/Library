namespace Library
{
    partial class AddBook
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
            btn_add = new Button();
            btn_cancel = new Button();
            tb_id = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tb_publisher = new TextBox();
            label3 = new Label();
            tb_author = new TextBox();
            label4 = new Label();
            tb_genre = new TextBox();
            label5 = new Label();
            tb_pages = new TextBox();
            label6 = new Label();
            tb_publishYear = new TextBox();
            label8 = new Label();
            tb_name = new TextBox();
            SuspendLayout();
            // 
            // btn_add
            // 
            btn_add.Location = new Point(155, 372);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(75, 23);
            btn_add.TabIndex = 0;
            btn_add.Text = "Добавить";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(453, 371);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(75, 23);
            btn_cancel.TabIndex = 1;
            btn_cancel.Text = "Отмена";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // tb_id
            // 
            tb_id.Location = new Point(44, 42);
            tb_id.Name = "tb_id";
            tb_id.Size = new Size(263, 23);
            tb_id.TabIndex = 2;
            tb_id.TextChanged += tb_id_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 24);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 3;
            label1.Text = "id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(455, 161);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 5;
            label2.Text = "name";
            // 
            // tb_publisher
            // 
            tb_publisher.Location = new Point(44, 250);
            tb_publisher.Name = "tb_publisher";
            tb_publisher.Size = new Size(263, 23);
            tb_publisher.TabIndex = 4;
            tb_publisher.TextChanged += tb_publisher_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(455, 24);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 9;
            label3.Text = "genre";
            // 
            // tb_author
            // 
            tb_author.Location = new Point(455, 106);
            tb_author.Name = "tb_author";
            tb_author.Size = new Size(263, 23);
            tb_author.TabIndex = 8;
            tb_author.TextChanged += tb_author_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(455, 88);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 7;
            label4.Text = "author";
            // 
            // tb_genre
            // 
            tb_genre.Location = new Point(453, 42);
            tb_genre.Name = "tb_genre";
            tb_genre.Size = new Size(263, 23);
            tb_genre.TabIndex = 6;
            tb_genre.TextChanged += tb_genre_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 161);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 13;
            label5.Text = "Pages";
            // 
            // tb_pages
            // 
            tb_pages.Location = new Point(44, 179);
            tb_pages.Name = "tb_pages";
            tb_pages.Size = new Size(263, 23);
            tb_pages.TabIndex = 12;
            tb_pages.TextChanged += tb_pages_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 88);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 11;
            label6.Text = "Publish year";
            // 
            // tb_publishYear
            // 
            tb_publishYear.Location = new Point(44, 106);
            tb_publishYear.Name = "tb_publishYear";
            tb_publishYear.Size = new Size(263, 23);
            tb_publishYear.TabIndex = 10;
            tb_publishYear.TextChanged += tb_publishYear_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(44, 232);
            label8.Name = "label8";
            label8.Size = new Size(56, 15);
            label8.TabIndex = 15;
            label8.Text = "Publisher";
            // 
            // tb_name
            // 
            tb_name.Location = new Point(455, 179);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(263, 23);
            tb_name.TabIndex = 14;
            tb_name.TextChanged += tb_name_TextChanged;
            // 
            // AddBook
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
            Controls.Add(btn_add);
            Name = "AddBook";
            Text = "AddBook";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_add;
        private Button btn_cancel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        public TextBox tb_id;
        public TextBox tb_publisher;
        public TextBox tb_author;
        public TextBox tb_genre;
        public TextBox tb_pages;
        public TextBox tb_publishYear;
        public TextBox tb_name;
    }
}