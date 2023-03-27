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
    public partial class AddBook : Form
    {
        public Book AddableBook { get; set; }
        public AddBook()
        {
            InitializeComponent();
            AddableBook = new Book();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (tb_id.Text.Length > 0 && tb_name.Text.Length > 0 && tb_author.Text.Length > 0 && tb_genre.Text.Length > 0 && tb_publishYear.Text.Length > 0 && tb_pages.Text.Length > 0 && tb_publisher.Text.Length > 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Простите, но все поля должны быть заполнены. Невозможно создать книгу.");
            }
        }

        private void tb_id_TextChanged(object sender, EventArgs e)
        {
            if (tb_id.Text.Length > 0)
            {
                AddableBook.Id = Convert.ToInt32(tb_id.Text);
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
                AddableBook.Genre = tb_genre.Text;
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
                AddableBook.PublishYear = Convert.ToInt32(tb_publishYear.Text);
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
                AddableBook.Author = tb_author.Text;
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
                AddableBook.Pages = Convert.ToInt32(tb_pages.Text);
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
                AddableBook.Name = tb_name.Text;
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
                AddableBook.Publisher = tb_publisher.Text;
            }
            else
            {
                MessageBox.Show("Поле не может быть пустым!");
            }
        }
    }
}
