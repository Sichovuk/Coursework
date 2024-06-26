using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework_try2
{
    public partial class MainForm : Form
    {
        // Створення колекції параметризованого типу для зберігання абітурієнтів
        List<Applicant> applicants = new List<Applicant>();


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            gvApplicants.AutoGenerateColumns = false;
            DataGridViewColumn column = new DataGridViewColumn();

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "FullName";
            column.Name = "ПІБ";
            column.Width = 250;
            gvApplicants.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Age";
            column.Name = "Повних років на момент подачі документів";
            column.Width = 100;
            gvApplicants.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "PhoneNumber";
            column.Name = "Номер телефону";
            column.Width = 125;
            gvApplicants.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "UkrScore";
            column.Name = "Балів за укр. м.";
            gvApplicants.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "MathScore";
            column.Name = "Балів за матем.";
            gvApplicants.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "HistoryScore";
            column.Name = "Балів за іст. Укр.";
            gvApplicants.Columns.Add(column);

            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "HasPrivilege";
            column.Name = "Пільговик";
            column.Width = 80;
            gvApplicants.Columns.Add(column);

            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "CanPay";
            column.Name = "Згоден вчитися на договірній основі";
            column.Width = 100;
            gvApplicants.Columns.Add(column);

            // Додавання колонок для методів
            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "IsAdult";
            column.Name = "Повнолітній";
            column.Width = 80;
            gvApplicants.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "AverageScore";
            column.Name = "Середній бал";
            column.Width = 122;
            gvApplicants.Columns.Add(column);

            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "PassedNMT";
            column.Name = "Склав НМТ";
            column.Width = 100;
            gvApplicants.Columns.Add(column);

            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "HasPassingScore";
            column.Name = "Набрав прохідний бал";
            column.Width = 100;
            gvApplicants.Columns.Add(column);

            bindSrcApplicants.Add(new Applicant("Янковчук Михайло Ігорович", 16, "+380932216848", 160, 157, 178, false, false));
            bindSrcApplicants.Add(new Applicant("Коваль Дар'я Валеріївна", 17, "+380937412233", 121, 150, 149, false, true));
            bindSrcApplicants.Add(new Applicant("Мельник Микола Маклайович", 19, "+380678419127", 101, 120, 180, true, true));
            bindSrcApplicants.Add(new Applicant("Апанасенко Валерія Віталіївна", 17, "+380671213841", 198, 180, 175, true, false));
            bindSrcApplicants.Add(new Applicant("Пінчук Марія Остапівна", 20, "+380672872578", 98, 110, 105, false, true));
            bindSrcApplicants.Add(new Applicant("Кравчук Генадій Станіславович", 16, "+3804782549", 141, 180, 175, true, false));
            bindSrcApplicants.Add(new Applicant("Карамишев Юрій Микитович", 18, "+380937891873", 120, 140, 128, false, false));
            bindSrcApplicants.Add(new Applicant("Іванова Олена Петрівна", 21, "+380961234567", 175, 160, 158, true, true));
            bindSrcApplicants.Add(new Applicant("Гончарук Олександр Андрійович", 18, "+380501112233", 135, 145, 150, false, true));
            bindSrcApplicants.Add(new Applicant("Шевченко Наталія Василівна", 19, "+380503214567", 155, 148, 172, true, false));
            bindSrcApplicants.Add(new Applicant("Бондаренко Максим Дмитрович", 17, "+380502345678", 125, 135, 140, false, true));
            bindSrcApplicants.Add(new Applicant("Сидоренко Ірина Олексіївна", 20, "+380501234678", 100, 115, 130.5, true, false));
            bindSrcApplicants.Add(new Applicant("Климчук Андрій Сергійович", 22, "+380961231231", 150, 160, 155, true, true));
            bindSrcApplicants.Add(new Applicant("Петренко Юлія Анатоліївна", 18, "+380503216543", 145, 138, 149, false, false));
            bindSrcApplicants.Add(new Applicant("Романенко Василь Ігорович", 16, "+380501231231", 170, 165, 160, false, true));
            bindSrcApplicants.Add(new Applicant("Даниленко Світлана Володимирівна", 19, "+380502315678", 80, 98, 101, true, false));
            bindSrcApplicants.Add(new Applicant("Захаренко Вікторія Романівна", 18, "+380503215432", 180, 175, 170, true, true));
            bindSrcApplicants.Add(new Applicant("Луценко Вадим Олександрович", 20, "+380961232323", 160, 155, 165, false, false));
            bindSrcApplicants.Add(new Applicant("Сергієнко Олег Іванович", 19, "+380501234555", 132, 140, 145, true, true));
            bindSrcApplicants.Add(new Applicant("Кузнєцов Андрій Петрович", 20, "+380501234556", 125, 135, 142, false, false));
            bindSrcApplicants.Add(new Applicant("Зайцева Марія Олександрівна", 18, "+380501234557", 180, 170, 175, true, true));
            bindSrcApplicants.Add(new Applicant("Бондар Сергій Олегович", 21, "+380501234558", 110, 120, 125, false, true));
            bindSrcApplicants.Add(new Applicant("Тимошенко Олена Володимирівна", 17, "+380501234559", 190, 185, 188, true, false));
            bindSrcApplicants.Add(new Applicant("Мороз Віктор Ігорович", 22, "+380501234560", 150, 155, 160, false, false));
            bindSrcApplicants.Add(new Applicant("Мельник Валентина Сергіївна", 16, "+380501234561", 140, 145, 148, true, true));
            bindSrcApplicants.Add(new Applicant("Петренко Олександр Іванович", 18, "+380501234562", 135, 140, 145, false, true));
            bindSrcApplicants.Add(new Applicant("Коваленко Анастасія Ігорівна", 19, "+380501234563", 97, 130, 135, true, false));
            bindSrcApplicants.Add(new Applicant("Романенко Іван Васильович", 17, "+380501234564", 170, 160, 165, false, false));
            bindSrcApplicants.Add(new Applicant("Герасименко Марина Вікторівна", 21, "+380501234565", 155, 150, 152, true, true));
            bindSrcApplicants.Add(new Applicant("Савченко Максим Олександрович", 20, "+380501234566", 145, 140, 138, false, true));
            bindSrcApplicants.Add(new Applicant("Литвиненко Анна Петрівна", 18, "+380501234567", 165, 160, 162, true, false));
            bindSrcApplicants.Add(new Applicant("Шевченко Юрій Дмитрович", 22, "+380501234568", 175, 170, 172, false, false));
            bindSrcApplicants.Add(new Applicant("Зайцева Ольга Олександрівна", 19, "+380501234569", 75, 130, 128, true, true));
            bindSrcApplicants.Add(new Applicant("Сергієнко Наталія Іванівна", 16, "+380501234570", 155, 160, 158, false, true));
            bindSrcApplicants.Add(new Applicant("Бондаренко Ігор Сергійович", 18, "+380501234571", 145, 150, 148, true, false));
            bindSrcApplicants.Add(new Applicant("Кузнєцова Марія Андріївна", 17, "+380501234572", 135, 140, 138, false, false));
            bindSrcApplicants.Add(new Applicant("Мороз Вікторія Ігорівна", 20, "+380501234573", 170, 175, 172, true, true));
            bindSrcApplicants.Add(new Applicant("Тимошенко Олег Володимирович", 21, "+380501234574", 160, 165, 162, false, true));
            bindSrcApplicants.Add(new Applicant("Мельниченко Олександр Сергійович", 22, "+380501234575", 150, 155, 152, true, false));
            bindSrcApplicants.Add(new Applicant("Зайцева Анна Іванівна", 16, "+380501234576", 140, 145, 142, false, false));
            bindSrcApplicants.Add(new Applicant("Сергієнко Дмитро Іванович", 18, "+380501234577", 130, 135, 132, true, true));
            bindSrcApplicants.Add(new Applicant("Бондар Олена Олександрівна", 19, "+380501234578", 155, 160, 158, false, true));
            bindSrcApplicants.Add(new Applicant("Тимошенко Оксана Володимирівна", 17, "+380501234579", 165, 170, 168, true, false));
            bindSrcApplicants.Add(new Applicant("Мороз Олексій Ігорович", 20, "+380501234580", 145, 150, 148, false, false));
            bindSrcApplicants.Add(new Applicant("Кузнєцова Ольга Андріївна", 21, "+380501234581", 135, 140, 138, true, true));
            bindSrcApplicants.Add(new Applicant("Бондаренко Марія Сергіївна", 22, "+380501234582", 120, 125, 123, false, true));
            bindSrcApplicants.Add(new Applicant("Зайцева Наталія Олександрівна", 16, "+380501234583", 130, 135, 132, true, false));
            bindSrcApplicants.Add(new Applicant("Сергієнко Олексій Іванович", 18, "+380501234584", 155, 160, 158, false, false));
            bindSrcApplicants.Add(new Applicant("Бондар Віктор Олександрович", 19, "+380501234585", 165, 170, 168, true, true));
            bindSrcApplicants.Add(new Applicant("Кузнєцов Олександр Петрович", 17, "+380501234586", 145, 150, 148, false, true));
            bindSrcApplicants.Add(new Applicant("Мороз Марія Ігорівна", 20, "+380501234587", 98, 140, 138, true, false));
            bindSrcApplicants.Add(new Applicant("Тимошенко Сергій Володимирович", 21, "+380501234588", 120, 125, 123, false, false));
            bindSrcApplicants.Add(new Applicant("Мельник Олександра Сергіївна", 22, "+380501234589", 130, 135, 132, true, true));
            bindSrcApplicants.Add(new Applicant("Зайцев Олексій Іванович", 16, "+380501234590", 155, 160, 158, false, true));
            bindSrcApplicants.Add(new Applicant("Сергієнко Марина Іванівна", 18, "+380501234591", 165, 170, 168, true, false));
            bindSrcApplicants.Add(new Applicant("Бондаренко Олена Олександрівна", 19, "+380501234592", 145, 150, 148, false, false));
            bindSrcApplicants.Add(new Applicant("Кузнєцова Анна Андріївна", 17, "+380501234593", 135, 140, 138, true, true));
            bindSrcApplicants.Add(new Applicant("Мороз Олександра Ігорівна", 20, "+380501234594", 101, 71, 93, false, true));
            bindSrcApplicants.Add(new Applicant("Тимошенко Олег Володимирович", 21, "+380501234595", 130, 135, 132, true, false));
            bindSrcApplicants.Add(new Applicant("Мельниченко Олександр Сергійович", 22, "+380501234596", 155, 160, 158, false, false));
            bindSrcApplicants.Add(new Applicant("Зайцева Олександра Олександрівна", 16, "+380501234597", 165, 170, 168, true, true));
            bindSrcApplicants.Add(new Applicant("Сергієнко Олексій Іванович", 18, "+380501234598", 145, 150, 148, false, true));
            bindSrcApplicants.Add(new Applicant("Бондар Віктор Олександрович", 19, "+380501234599", 135, 140, 138, true, false));
            bindSrcApplicants.Add(new Applicant("Кузнєцов Марія Андріївна", 17, "+380501234600", 120, 125, 123, false, false));
            bindSrcApplicants.Add(new Applicant("Мороз Олексій Ігорович", 20, "+380501234601", 130, 135, 132, true, true));
            bindSrcApplicants.Add(new Applicant("Тимошенко Сергій Володимирович", 21, "+380501234602", 155, 160, 158, false, true));
            bindSrcApplicants.Add(new Applicant("Мельник Олександра Сергіївна", 22, "+380501234603", 113, 87, 103, true, false));


            // Додаємо варіанти сортування до cbSort
            cbSort.Items.Add("");
            cbSort.Items.Add("Алфавітом");
            cbSort.Items.Add("Зворотним алфавітом");
            cbSort.Items.Add("Наявністю пільги");
            cbSort.Items.Add("Відсутністю пільги");
            cbSort.Items.Add("Згодою вчитися на договірній основі");
            cbSort.Items.Add("Незгодою вчитися на договірній основі");
            cbSort.Items.Add("Повноліттям");
            cbSort.Items.Add("Неповноліттям");
            cbSort.Items.Add("Складеним НМТ");
            cbSort.Items.Add("Нескладеним НМТ");
            cbSort.Items.Add("Набраним прохідним балом");
            cbSort.Items.Add("Ненабраним прохідним балом");
            cbSort.SelectedIndex = 0; // Встановлюємо перший варіант як вибраний за замовчуванням

            // Додаємо варіанти сортування до cbFilter
            cbFilter.Items.Add("");
            cbFilter.Items.Add("Більший за");
            cbFilter.Items.Add("Менший за");
            cbFilter.Items.Add("Дорівнює");
            cbFilter.SelectedIndex = 0; // Встановлюємо перший варіант як вибраний за замовчуванням
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Applicant applicant = new Applicant();

            ApplicantForm AF = new ApplicantForm(applicant);
            if (AF.ShowDialog() == DialogResult.OK)
            {
                bindSrcApplicants.Add(applicant);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Applicant applicant = (Applicant)bindSrcApplicants.List[bindSrcApplicants.Position];

            ApplicantForm AF = new ApplicantForm(applicant);
            if (AF.ShowDialog() == DialogResult.OK)
            {
                bindSrcApplicants.List[bindSrcApplicants.Position] = applicant;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Перевірка наявності вибраних рядків
            if (gvApplicants.SelectedRows.Count > 0)
            {
                // Підтвердження видалення
                if (MessageBox.Show("Видалити вибрані записи?", "Видалення записів",
                                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    // Збереження списку вибраних рядків
                    List<DataGridViewRow> selectedRows = new List<DataGridViewRow>();

                    foreach (DataGridViewRow row in gvApplicants.SelectedRows)
                    {
                        selectedRows.Add(row);
                    }

                    // Видалення кожного вибраного запису
                    foreach (DataGridViewRow row in selectedRows)
                    {
                        bindSrcApplicants.Remove(row.DataBoundItem as Applicant);
                    }
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть записи для видалення.", "Вибір записів",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Очистити таблицю?\n\nВсі дані будуть втрачені", "Очищення даних",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bindSrcApplicants.Clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити застосунок?", "Вихід з програми", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Текстові файли (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.Title = "Зберегти дані у текстовому форматі";
            saveFileDialog.InitialDirectory = Application.StartupPath;
            StreamWriter sw;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                sw = new StreamWriter(saveFileDialog.FileName, false, Encoding.UTF8);
                try
                {
                    foreach (Applicant applicant in bindSrcApplicants.List)
                    {
                        sw.Write(applicant.FullName + "\t" + applicant.Age + "\t" +
                        applicant.PhoneNumber + "\t" + applicant.UkrScore + "\t" +
                        applicant.MathScore + "\t" + applicant.HistoryScore + "\t" +
                        applicant.HasPrivilege + "\t" + applicant.CanPay + "\t\n");
                    }
                }
                catch (Exception ex) 
                {
                    MessageBox.Show("Сталась помилка: \n{0}", ex.Message,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sw.Close();
                }
            }


        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстові файли (*.txt)|*.txt|All files (*.*) | *.*";
            openFileDialog.Title = "Прочитати дані у текстовому форматі";
            openFileDialog.InitialDirectory = Application.StartupPath;
            StreamReader sr;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                bindSrcApplicants.Clear(); sr = new StreamReader(openFileDialog.FileName, Encoding.UTF8);
                string s;
                try
                {
                    while ((s = sr.ReadLine()) !=null)
                    {
                        string[] split = s.Split('\t');
                        Applicant applicant = new Applicant(split[0], int.Parse(split[1]), split[2],
                        double.Parse(split[3]), double.Parse(split[4]), double.Parse(split[5]),
                        bool.Parse(split[6]), bool.Parse(split[7]));
                        bindSrcApplicants.Add(applicant);
                    }
                }
                catch (Exception ex) 
                {
                    MessageBox.Show("Сталась помилка: \n{0}", ex.Message,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sr.Close();
                }
            }
        }

        private void btnSearch1_Click(object sender, EventArgs e)
        {
            string searchTerm = tbSearch.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(searchTerm))
            {
                MessageBox.Show("Введіть прізвище для пошуку.", "Пошук", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var filteredApplicants = bindSrcApplicants.List.Cast<Applicant>().Where(a => a.FullName.ToLower().Contains(searchTerm)).ToList();
            if (filteredApplicants.Any())
            {
                gvApplicants.DataSource = new BindingSource { DataSource = filteredApplicants };
            }
            else
            {
                MessageBox.Show("Абітурієнтів з таким прізвищем не знайдено.", "Пошук", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gvApplicants.DataSource = bindSrcApplicants;
            }
        }

        private void btnCancel1_Click(object sender, EventArgs e)
        {
            // Показати всі записи в базі, скидаючи будь-який фільтр
            gvApplicants.DataSource = bindSrcApplicants;
            tbSearch.Clear();
        }

        private void btnSearch2_Click(object sender, EventArgs e)
        {
            string searchTerm = cbSort.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(searchTerm))
            {
                MessageBox.Show("Оберіть варіант сортування.", "Пошук", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            IEnumerable<Applicant> sortedApplicants = bindSrcApplicants.List.Cast<Applicant>();

            // Сортування відповідно до вибраного варіанту у ComboBox
            switch (cbSort.SelectedItem.ToString())
            {
                case "Алфавітом":
                    sortedApplicants = sortedApplicants.OrderBy(a => a.FullName).ToList();
                    break;
                case "Зворотним алфавітом":
                    sortedApplicants = sortedApplicants.OrderByDescending(a => a.FullName).ToList();
                    break;
                case "Наявністю пільги":
                    sortedApplicants = sortedApplicants.OrderByDescending(a => a.HasPrivilege).ThenBy(a => a.FullName).ToList();
                    break;
                case "Відсутністю пільги":
                    sortedApplicants = sortedApplicants.OrderBy(a => a.HasPrivilege).ThenBy(a => a.FullName).ToList();
                    break;
                case "Згодою вчитися на договірній основі":
                    sortedApplicants = sortedApplicants.OrderByDescending(a => a.CanPay).ThenBy(a => a.FullName).ToList();
                    break;
                case "Незгодою вчитися на договірній основі":
                    sortedApplicants = sortedApplicants.OrderBy(a => a.CanPay).ThenBy(a => a.FullName).ToList();
                    break;
                case "Повноліттям":
                    sortedApplicants = sortedApplicants.OrderByDescending(a => a.IsAdult).ThenBy(a => a.FullName).ToList();
                    break;
                case "Неповноліттям":
                    sortedApplicants = sortedApplicants.OrderBy(a => a.IsAdult).ThenBy(a => a.FullName).ToList();
                    break;
                case "Складеним НМТ":
                    sortedApplicants = sortedApplicants.OrderByDescending(a => a.PassedNMT).ThenBy(a => a.FullName).ToList();
                    break;
                case "Нескладеним НМТ":
                    sortedApplicants = sortedApplicants.OrderBy(a => a.PassedNMT).ThenBy(a => a.FullName).ToList();
                    break;
                case "Набраним прохідним балом":
                    sortedApplicants = sortedApplicants.OrderByDescending(a => a.HasPassingScore).ThenBy(a => a.FullName).ToList();
                    break;
                case "Ненабраним прохідним балом":
                    sortedApplicants = sortedApplicants.OrderBy(a => a.HasPassingScore).ThenBy(a => a.FullName).ToList();
                    break;
                default:
                    MessageBox.Show("Такий вид сортування не знайдено", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    gvApplicants.DataSource = bindSrcApplicants;
                    return; // Вихід з методу у разі невідомого виду сортування
            }
            gvApplicants.DataSource = new BindingSource { DataSource = sortedApplicants };
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            gvApplicants.DataSource = bindSrcApplicants;

            if (cbSort.Items.Count > 0)
            {
                cbSort.SelectedIndex = 0;
            }
        }

        private void btnSearch3_Click(object sender, EventArgs e)
        {
            // Отримуємо значення з TextBox і ComboBox
            if (!double.TryParse(tbMark.Text, out double filterScore))
            {
                MessageBox.Show("Введіть коректну кількість балів.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string filterType = cbFilter.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(filterType))
            {
                MessageBox.Show("Оберіть тип фільтрації.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            IEnumerable<Applicant> filteredApplicants;

            // Фільтрація за обраним типом
            switch (filterType)
            {
                case "Більший за":
                    filteredApplicants = bindSrcApplicants.List.Cast<Applicant>().Where(a => a.AverageScore > filterScore);
                    break;
                case "Менший за":
                    filteredApplicants = bindSrcApplicants.List.Cast<Applicant>().Where(a => a.AverageScore < filterScore);
                    break;
                case "Дорівнює":
                    filteredApplicants = bindSrcApplicants.List.Cast<Applicant>().Where(a => a.AverageScore == filterScore);
                    break;
                default:
                    MessageBox.Show("Невідомий тип фільтрації.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            // Сортування результатів за середнім балом у порядку спадання
            filteredApplicants = filteredApplicants.OrderByDescending(a => a.AverageScore);

            gvApplicants.DataSource = new BindingSource { DataSource = filteredApplicants };
        }

        private void btnCancel3_Click(object sender, EventArgs e)
        {
            gvApplicants.DataSource = bindSrcApplicants;
            tbMark.Clear();

            if (cbFilter.Items.Count > 0)
            {
                cbFilter.SelectedIndex = 0;
            }
        }

        private void btnSearch4_Click(object sender, EventArgs e)
        {
            // Зчитуємо кількість абітурієнтів для зарахування та мінімальну кількість балів
            int enrollmentNumber;
            double mark2;

            if (!int.TryParse(tbEnrollmentNumber.Text, out enrollmentNumber))
            {
                MessageBox.Show("Введіть коректну кількість абітурієнтів.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(tbMark2.Text, out mark2))
            {
                MessageBox.Show("Введіть коректну мінімальну кількість балів.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Сортуємо список абітурієнтів за середнім балом у порядку спадання
            var sortedApplicants = bindSrcApplicants.List.Cast<Applicant>().OrderByDescending(a => a.AverageScore).ToList();

            int removedCount = 0;

            // Видаляємо абітурієнтів з бази
            foreach (var applicant in sortedApplicants)
            {
                if (removedCount >= enrollmentNumber || applicant.AverageScore < mark2)
                {
                    break;
                }

                bindSrcApplicants.Remove(applicant);
                removedCount++;
            }

            // Повідомлення про реальну видалену кількість абітурієнтів
            MessageBox.Show($"Було зараховано та видалено з бази {removedCount} абітурієнтів.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            gvApplicants.DataSource = bindSrcApplicants;
        }

        private void btnCancel4_Click(object sender, EventArgs e)
        {
            tbEnrollmentNumber.Clear();
            tbMark2.Clear();
        }

        private void btnSearch5_Click(object sender, EventArgs e)
        {
            // Отримання списку абітурієнтів, які набрали граничний прохідний бал, але не мають змоги вчитися на договірній основі
            var selectedApplicants = bindSrcApplicants.List.Cast<Applicant>()
                .Where(a => a.AverageScore > 150 && !a.CanPay)
                .OrderByDescending(a => a.AverageScore)
                .ToList();

            // Створення нового BindingList для відображення у DataGridView (або оновлення існуючого)
            var filteredBindingList = new BindingList<Applicant>(selectedApplicants);

            // Припустимо, що у вас є DataGridView з іменем gvSelectedApplicants для відображення відібраних абітурієнтів
            gvApplicants.DataSource = filteredBindingList;

            // Якщо потрібно, можна також відобразити повідомлення з кількістю відібраних абітурієнтів
            MessageBox.Show($"Кількість відібраних абітурієнтів: {selectedApplicants.Count}", "Результати відбору", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancel5_Click(object sender, EventArgs e)
        {
            gvApplicants.DataSource = bindSrcApplicants;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            // Створення екземпляра форми InformationForm
            Information infoForm = new Information();

            // Відображення форми InformationForm як модальної
            infoForm.ShowDialog();
        }
    }
}
