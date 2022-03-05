using System;
using System.Windows.Forms;
using System.Drawing;

namespace Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            foreach (Enum valueEnums in Enum.GetValues(typeof(Enums)))
            {
                EnumsListBox.Items.Add(valueEnums);
            }
            EnumsListBox.SelectedIndex = 0;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {


        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();
            var item = EnumsListBox.SelectedItem;
            var itemType = (Enums)item;

            switch (itemType)
            {
                case Enums.Colors:
                    ValuesListBox.Items.AddRange(Enum.GetNames(typeof(Colors)));
                    break;
                case Enums.Form_of_study:
                    ValuesListBox.Items.AddRange(Enum.GetNames(typeof(Form_of_study)));
                    break;
                case Enums.Genre:
                    ValuesListBox.Items.AddRange(Enum.GetNames(typeof(Genre)));
                    break;
                case Enums.Seasons:
                    ValuesListBox.Items.AddRange(Enum.GetNames(typeof(Seasons)));
                    break;
                case Enums.Smartphone_vendors:
                    ValuesListBox.Items.AddRange(Enum.GetNames(typeof(Smartphone_vendors)));
                    break;
                case Enums.Weekday:
                    ValuesListBox.Items.AddRange(Enum.GetNames(typeof(Weekday)));
                    break;
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = ValuesListBox.SelectedItem;
            textBox1.Text = ((int)item).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Parse_Button_Click(object sender, EventArgs e)
        {
            Weekday day;
            if (Enum.TryParse(WeekDayTextBox.Text, out day))
            {
                output.Text = $"Это день недели ({day.ToString()} = {(int)day + 1}).";
            }
            else
            {
                output.Text = "Нет такого дня недели";
            }

        }

        private void WeekDayTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var item = (Seasons)ComboSeasons.SelectedItem;
            switch (item)
            {
                case Seasons.Autumn:
                    BackColor = ColorTranslator.FromHtml("#e29c45");
                    break;
                case Seasons.Spring:
                    BackColor = ColorTranslator.FromHtml("#559c45");
                    break;
                case Seasons.Summer:
                    MessageBox.Show("Ура! Солнце!", "AlErT", MessageBoxButtons.OKCancel);
                    break;
                case Seasons.Winter:
                    MessageBox.Show("«Бррр! Холодно!", "AlErT", MessageBoxButtons.OKCancel);
                    break;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void output_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}