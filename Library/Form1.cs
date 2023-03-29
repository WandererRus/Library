using System.ComponentModel;
using System.Data;
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable dataTable = new DataTable();
        private Book bufferBook = new Book();
        private void Form1_Load(object sender, EventArgs e)
        {
            dataTable.TableName = "Library";
            dataTable.Columns.Add(new DataColumn("ID", typeof(int)));
            dataTable.Columns.Add(new DataColumn("Name", typeof(string)));
            dataTable.Columns.Add(new DataColumn("Author", typeof(string)));
            dataTable.Columns.Add(new DataColumn("Genre", typeof(string)));
            dataTable.Columns.Add(new DataColumn("Publish Year", typeof(int)));
            dataTable.Columns.Add(new DataColumn("Pages", typeof(int)));
            dataTable.Columns.Add(new DataColumn("Publisher", typeof(string)));
            dataTable.Rows.Add(0, "Война и мир", "Л.Н. Толстой", "роман-эпопея", 1865, 960, "Русский вестник");
            dataTable.Rows.Add(1, "Мертвые души", "Н.В. Гоголь", "комедия", 1875, 360, "Русский вестник");
            dataTable.Rows.Add(2, "Тихий дон", "М.А. Шолохов", "роман", 1925, 560, "Новый мир");
            dataTable.Rows.Add(3, "Евгений Онегин", "А.С. Пушкин", "поэма", 1845, 260, "Огонек");
            //ниже добавление строк в таблице, надо в DataTable
            dgv_library.Columns.Clear();
            dgv_library.DataSource = dataTable;
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_library.SelectedRows[0].Index >= 0)
                dataTable.Rows.RemoveAt(dgv_library.SelectedRows[0].Index);
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_library.SelectedRows.Count > 0)
            {
                //переделать под DataTable
                bufferBook = new Book(
                    Convert.ToInt32(dgv_library.SelectedRows[0].Cells[0].Value.ToString()),
                    dgv_library.SelectedRows[0].Cells[1].Value.ToString(),
                    dgv_library.SelectedRows[0].Cells[2].Value.ToString(),
                    dgv_library.SelectedRows[0].Cells[3].Value.ToString(),
                    Convert.ToInt32(dgv_library.SelectedRows[0].Cells[4].Value.ToString()),
                    Convert.ToInt32(dgv_library.SelectedRows[0].Cells[5].Value.ToString()),
                    dgv_library.SelectedRows[0].Cells[6].Value.ToString());
                EditBook editForm = new EditBook(bufferBook);
                if (editForm.ShowDialog() == DialogResult.OK)
                {

                    bufferBook = editForm.EditableBook;
                    dataTable.Rows[dgv_library.SelectedRows[0].Index][0] = bufferBook.Id;
                    dataTable.Rows[dgv_library.SelectedRows[0].Index][1] = bufferBook.Name;
                    dataTable.Rows[dgv_library.SelectedRows[0].Index][2] = bufferBook.Author;
                    dataTable.Rows[dgv_library.SelectedRows[0].Index][3] = bufferBook.Genre;
                    dataTable.Rows[dgv_library.SelectedRows[0].Index][4] = bufferBook.PublishYear;
                    dataTable.Rows[dgv_library.SelectedRows[0].Index][5] = bufferBook.Pages;
                    dataTable.Rows[dgv_library.SelectedRows[0].Index][6] = bufferBook.Publisher;

                    dataTable.AcceptChanges();

                    editForm.Close();
                }

            }
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBook addForm = new AddBook();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                //переделать под DataTable
                bufferBook = addForm.AddableBook;
                dataTable.Rows.Add(
                bufferBook.Id,
                bufferBook.Name,
                bufferBook.Author,
                bufferBook.Genre,
                bufferBook.PublishYear,
                bufferBook.Pages,
                bufferBook.Publisher);
            }
        }

        private void nameFilterASCToolStripMenuItem_Click(object sender, EventArgs e)
        {

            dgv_library.Sort(dgv_library.Columns[1], ListSortDirection.Ascending);
        }

        private void nameFilterDESCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgv_library.Sort(dgv_library.Columns[1], ListSortDirection.Descending);
        }

        private void сохранитьВXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string path = "D:\\base.xml";
                if (!File.Exists(path))
                    File.Create(path).Close();

                StreamWriter streamWriter = new StreamWriter(path);
                dataTable.WriteXml(streamWriter);
                streamWriter.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void загрузитьИзXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string path = "D:\\base.xml";
                if (!File.Exists(path))
                    File.Create(path).Close();

                StreamReader streamReader = new StreamReader(path);
                dataTable.Rows.Clear();
                dataTable.ReadXml(streamReader);
                streamReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void aSCToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dgv_library.Sort(dgv_library.Columns[2], ListSortDirection.Ascending);
        }

        private void dESCToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dgv_library.Sort(dgv_library.Columns[2], ListSortDirection.Descending);
        }

        private void aSCToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            dgv_library.Sort(dgv_library.Columns[6], ListSortDirection.Ascending);
        }

        private void dESCToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            dgv_library.Sort(dgv_library.Columns[6], ListSortDirection.Descending);
        }
    }
}