using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rnd_game
{
    public partial class FormMainWindow : Form
    {
        public Dictionary<string, string> dict_games = new Dictionary<string, string>();
        public List<string> selectedItems = new List<string>();
        public bool flag_close_program = true;

        public FormMainWindow()
        {
            List<string> list_games_key = new List<string>();
            List<string> list_games_value = new List<string>();
            List<string> list_games_checked = new List<string>();

            using (FileStream myStream = File.Open("list_key.txt", FileMode.OpenOrCreate, FileAccess.Read))
            {
                using (StreamReader myReader = new StreamReader(myStream))
                {
                    string line;
                    while ((line = myReader.ReadLine()) != null)
                    {
                        list_games_key.Add(line);
                    }
                }
            }
            using (FileStream myStream = File.Open("list_value.txt", FileMode.OpenOrCreate, FileAccess.Read))
            {
                using (StreamReader myReader = new StreamReader(myStream))
                {
                    string line;
                    while ((line = myReader.ReadLine()) != null)
                    {
                        list_games_value.Add(line);
                    }
                }
            }
            using (FileStream myStream = File.Open("checked_info.txt", FileMode.OpenOrCreate, FileAccess.Read))
            {
                using (StreamReader myReader = new StreamReader(myStream))
                {
                    string line;
                    while ((line = myReader.ReadLine()) != null)
                    {
                        list_games_checked.Add(line);
                    }
                }
            }

            InitializeComponent();

            for (int i = 0; i < list_games_key.Count && i < list_games_value.Count; i++)
            {
                dict_games.Add(list_games_key[i], list_games_value[i]);
                checkListBox_games.Items.Add(list_games_key[i]);
                foreach (string item in list_games_checked)
                {
                    if (item == list_games_key[i])
                    {
                        try
                        {
                            checkListBox_games.SetItemChecked(i, true);
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            Debug.WriteLine("Нет отмеченных элементов");
                        }
                    }
                }
            }

            list_games_key.Clear();
            list_games_value.Clear();
            list_games_checked.Clear();
        }

        public void AddGame()
        {
            if (textBox_gameName.Text != "")
            {
                string fileName = textBox_gameName.Text;
                if (dict_games.ContainsKey(fileName))
                {
                    MessageBox.Show("Такое название уже существует!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    OpenFileDialog openFileDialog = new OpenFileDialog();
                    openFileDialog.InitialDirectory = "C:\\Users\\Public\\Documents";
                    openFileDialog.Filter = "Все файлы (*.*)|*.*|Исполнительные файлы (*.exe)|*.exe|Ссылки на файлы (*.url)|*.url";
                    openFileDialog.Title = "Выберите файл";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = openFileDialog.FileName;
                        dict_games.Add(fileName, filePath);
                        checkListBox_games.Items.Add(fileName);
                    }
                }

            }
            else
            {
                MessageBox.Show("Напишите название игры!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void bt_addGame_Click(object sender, EventArgs e)
        {
            AddGame();
        }

        private void comboBox_presets_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void bt_addPreset_Click(object sender, EventArgs e)
        {

        }

        private void bt_runRndGame_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            foreach (string item in checkListBox_games.CheckedItems)
            {
                selectedItems.Add(item);
            }

            if (selectedItems.Count != 0)
            {
                int index = rnd.Next(selectedItems.Count);

                try
                {
                    Process.Start(dict_games[selectedItems[index]]);
                    if (flag_close_program == true)
                    {
                        Application.Exit();
                    }
                }
                catch
                {
                    MessageBox.Show($"Путь игры \"{selectedItems[index]}\" неверный\nУдалите игру из списка или восстановите путь", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult result = MessageBox.Show($"Удалить игру \"{selectedItems[index]}\" из списка?", "Оповещение rndGame", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        dict_games.Remove(selectedItems[index]);
                        checkListBox_games.Items.Remove(selectedItems[index]);
                        selectedItems.RemoveAt(index);
                    }
                }
            }
            else
            {
                DialogResult result = MessageBox.Show($"Добавите игру в список!", "Оповещение rndGame", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    AddGame();
                }
            }
        }

        public void SavePreset()
        {
            File.Delete("list_key.txt");
            File.Delete("list_value.txt");
            File.Delete("checked_info.txt");
            selectedItems.Clear();

            foreach (string item in checkListBox_games.CheckedItems)
            {
                selectedItems.Add(item);
            }

            foreach (KeyValuePair<string, string> k in dict_games)
            {
                File.AppendAllText("list_key.txt", $"{k.Key}\n");
                File.AppendAllText("list_value.txt", $"{k.Value}\n");
                foreach (string list_item in selectedItems)
                {
                    if (k.Key == list_item)
                    {
                        File.AppendAllText("checked_info.txt", $"{k.Key}\n");
                    }
                }
            }
        }
        private void bt_savePreset_Click(object sender, EventArgs e)
        {
            SavePreset();
        }

        private void bt_clearList_Click(object sender, EventArgs e)
        {
            dict_games.Clear();
            checkListBox_games.Items.Clear();
        }

        private void bt_delElemInList_Click(object sender, EventArgs e)
        {
            List<string> list_games_key = new List<string>();

            foreach (KeyValuePair<string, string> k in dict_games)
            {
                list_games_key.Add(k.Key);
            }

            if (checkListBox_games.SelectedIndex != -1) // Проверка на то, что элемент выбран
            {
                bt_delElemInList.Enabled = true;
                string selectedItem = checkListBox_games.SelectedItem.ToString();
                dict_games.Remove(list_games_key[checkListBox_games.SelectedIndex]);
                checkListBox_games.Items.RemoveAt(checkListBox_games.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Сначала нужно выбрать какую игру убрать из списка!", "Оповещение rndGame", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void checkBox_closeProgram_CheckedChanged(object sender, EventArgs e)
        {
            if (flag_close_program == true)
            {
                flag_close_program = false;
            }
            else
            {
                flag_close_program = true;
            }
        }

        private void FormMainWindow_Load(object sender, EventArgs e)
        {

        }

        private void bt_openFolder_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", ".");
        }

        private void bt_addGameLink_Click(object sender, EventArgs e)
        {

        }
    }
}
