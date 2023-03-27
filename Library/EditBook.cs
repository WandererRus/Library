using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class EditBook : Form
    {
        public Book EditableBook { get; set; }
        public EditBook(Book book)
        {
            InitializeComponent();
            EditableBook = book;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (tb_id.Text.Length > 0 && tb_name.Text.Length > 0 && tb_author.Text.Length > 0 && tb_genre.Text.Length > 0 && tb_publishYear.Text.Length > 0 && tb_pages.Text.Length > 0 && tb_publisher.Text.Length > 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Простите, но все поля должны быть заполнены. Невозможно сохранить книгу.");
            }
        }

        private void EditBook_Load(object sender, EventArgs e)
        {
            tb_author.Text = EditableBook.Author;
            tb_genre.Text = EditableBook.Genre;
            tb_id.Text = EditableBook.Id.ToString();
            tb_pages.Text = EditableBook.Pages.ToString();
            tb_publisher.Text = EditableBook.Publisher;
            tb_publishYear.Text = EditableBook.PublishYear.ToString();
            tb_name.Text = EditableBook.Name;
        }

        private void tb_id_TextChanged(object sender, EventArgs e)
        {
            if (tb_id.Text.Length > 0)
            {
                EditableBook.Id = Convert.ToInt32(tb_id.Text);
            }
            else
            {
                MessageBox.Show("Поле не может быть пустым!");
            }
        }

        private void tb_publishYear_TextChanged(object sender, EventArgs e)
        {
            if (tb_publishYear.Text.Length > 0)
            {
                EditableBook.PublishYear = Convert.ToInt32(tb_publishYear.Text);
            }
            else
            {
                MessageBox.Show("Поле не может быть пустым!");
            }
        }

        private void tb_pages_TextChanged(object sender, EventArgs e)
        {
            if (tb_pages.Text.Length > 0)
            {
                EditableBook.Pages = Convert.ToInt32(tb_pages.Text);
            }
            else
            {
                MessageBox.Show("Поле не может быть пустым!");
            }
        }

        private void tb_genre_TextChanged(object sender, EventArgs e)
        {
            if (tb_genre.Text.Length > 0)
            {
                EditableBook.Genre = tb_genre.Text;
            }
            else
            {
                MessageBox.Show("Поле не может быть пустым!");
            }
        }

        private void tb_author_TextChanged(object sender, EventArgs e)
        {
            if (tb_author.Text.Length > 0)
            {
                EditableBook.Author = tb_author.Text;
            }
            else
            {
                MessageBox.Show("Поле не может быть пустым!");
            }
        }

        private void tb_name_TextChanged(object sender, EventArgs e)
        {
            if (tb_name.Text.Length > 0)
            {
                EditableBook.Name = tb_name.Text;
            }
            else
            {
                MessageBox.Show("Поле не может быть пустым!");
            }
        }

        private void tb_publisher_TextChanged(object sender, EventArgs e)
        {
            if (tb_publisher.Text.Length > 0)
            {
                EditableBook.Publisher = tb_publisher.Text;
            }
            else
            {
                MessageBox.Show("Поле не может быть пустым!");
            }
        }
    }
}
