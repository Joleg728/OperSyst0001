using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using static System.Net.WebRequestMethods;
using System.Diagnostics;
using Shell32;
using System.Runtime.InteropServices.ComTypes;
//using Microsoft.SharePoint.Client;

namespace OperSysLab3
{
    public partial class Form1 : Form
    {
        public string fold_path = "";
        public string file_name = "";
        public string fold_new_path = "";
        public string file_new_name = "";

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern IntPtr CreateFile(
        string lpFileName,
        uint dwDesiredAccess,
        uint dwShareMode,
        IntPtr lpSecurityAttributes,
        uint dwCreationDisposition,
        uint dwFlagsAndAttributes,
        IntPtr hTemplateFile);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool CloseHandle(IntPtr hObject);

        private const uint GENERIC_WRITE = 0x40000000;
        private const uint OPEN_ALWAYS = 4;
        private const uint FILE_ATTRIBUTE_NORMAL = 0x80;

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click_dir_sel(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                fold_path = folderBrowserDialog1.SelectedPath;
            }
            else
            {
                return;
            }

            path_textbox1.Text = fold_path;

            //dir_list(treeView1, fold_path);
        }
        private void button_click_file_crt(object sender, EventArgs e)
        {
            if(!((file_name = file_name_textbox_1.Text).Length != 0 & fold_path.Length != 0))
            {
                //MessageBox.Show("Имя файла/путь пустой");

                noNameError();

                return;
            }

            MyFileCrt(fold_path, file_name);
        }

        private void button_click_file_del(object sender, EventArgs e)
        {
            if (!((file_name = file_name_textbox_1.Text).Length != 0 & fold_path.Length != 0))
            {
                //MessageBox.Show("Имя файла/путь пустой");

                noNameError();

                return;
            }

            if (!System.IO.File.Exists(Path.Combine(fold_path, file_name)))
            {
                //MessageBox.Show("Файла не существует");

                MessageBox.Show("Файла не существует",
                                "Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.DefaultDesktopOnly);

                return;
            }

            try
            {
                //System.IO.File.Delete(Path.Combine(fold_path, file_name));
                Delete(Path.Combine(fold_path, file_name));
            }
            catch (DirectoryNotFoundException dirNotFound) // оно не работает (
            {
                MessageBox.Show("Файл не найден");
            }
        }

        private void button_click_file_copy(object sender, EventArgs e)
        {
            if (!((file_name = file_name_textbox_1.Text).Length != 0 & fold_path.Length != 0 & (file_new_name = file_name_textbox_2.Text).Length != 0 & fold_new_path.Length != 0))
            {
                //MessageBox.Show("Имена файлов/пути пустые");

                noNameError();

                return;
            }

            try
            {
                System.IO.File.Copy(Path.Combine(fold_path, file_name), Path.Combine(fold_new_path, file_new_name));
            }
            catch
            {
                MessageBox.Show("Ошибка стоп 00000000000000000");
            }
        }

        private void button1_Click_dir_copy_sel(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                fold_new_path = folderBrowserDialog1.SelectedPath;
            }
            else
            {
                return;
            }

            path_textbox2.Text = fold_new_path;
        }

        private void button_click_file_move(object sender, EventArgs e)
        {
            if (!((file_name = file_name_textbox_1.Text).Length != 0 & fold_path.Length != 0 & fold_new_path.Length != 0))
            {
                //MessageBox.Show("Имена файлов/пути пустые");

                noNameError();

                return;
            }

            try
            {
                System.IO.File.Move(Path.Combine(fold_path, file_name), Path.Combine(fold_new_path, file_name));
            }
            catch
            {
                MessageBox.Show("Ошибка стоп 00000000000000000");
            }
        }

        private void button_click_file_rename(object sender, EventArgs e)
        {
            if (!((file_name = file_name_textbox_1.Text).Length != 0 & fold_path.Length != 0 & (file_new_name = file_name_textbox_2.Text).Length != 0))
            {
                //MessageBox.Show("Имена файлов/пути пустые");

                noNameError();

                return;
            }

            try
            {
                System.IO.File.Move(Path.Combine(fold_path, file_name), Path.Combine(fold_path, file_new_name));
            }
            catch
            {
                MessageBox.Show("Ошибка стоп 00000000000000000");
            }
        }

        private void button_click_file_sizeof(object sender, EventArgs e)
        {
            if (!((file_name = file_name_textbox_1.Text).Length != 0 & fold_path.Length != 0))
            {
                //MessageBox.Show("Имя файла/путь пустой");

                noNameError();

                return;
            }

            if (!System.IO.File.Exists(Path.Combine(fold_path, file_name)))
            {
                //MessageBox.Show("Файла не существует");

                MessageBox.Show("Файла не существует",
                                "Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.DefaultDesktopOnly);

                return;
            }

            System.IO.FileInfo file = new System.IO.FileInfo(Path.Combine(fold_path, file_name));
            MessageBox.Show($"Размер файла: {file.Length} байт"); 
        }

        private void Button_to_file_Click(object sender, EventArgs e)
        {
            //try
            //{
            if(fold_path.Length > 0)
            {
                Process.Start("explorer.exe", fold_path);
            }
            else
            {
                //MessageBox.Show("Имя файла/путь пустой");

                noNameError();

                return;

            }

            //}
            /*catch
            {
                MessageBox.Show("Имя файла/путь не правильный");
            }*/
        }

        private void Trash_button_Click(object sender, EventArgs e)
        {
            
            if (!((file_name = file_name_textbox_1.Text).Length != 0 & fold_path.Length != 0))
            {
                //MessageBox.Show("Имя файла/путь пустой");

                noNameError();

                return;
            }

            /*if (Restore(Path.Combine(fold_path, file_name)))
                MessageBox.Show(Path.Combine(fold_path, file_name) + " has been restored");

            else
                MessageBox.Show("Error");*/

            Shell shell = new Shell();
            Folder recycleBin = shell.NameSpace(10);
            if (recycleBin == null)
            {
                Console.WriteLine("Корзина пуста или не найдена.");
                return;
            }

            //int i = 0;

            bool file_found = false;

            foreach (FolderItem item in recycleBin.Items())
            {
                string originalPath = recycleBin.GetDetailsOf(item, 1);

                if (Path.Combine(originalPath, item.Name) == Path.Combine(fold_path, file_name))
                {
                    file_found = true;
                    MessageBox.Show($"Найден элемент: {Path.Combine(originalPath, item.Name) + "\r\n\r\n" + Path.Combine(fold_path, file_name)}");
                    item.InvokeVerb("restore");
                    break;
                }

                //MessageBox.Show($"Найден элемент: {item.Name + originalPath}");

                //i++;

                //item.InvokeVerb("restore");
                //Console.WriteLine($"Элемент '{item.Name}' успешно восстановлен!");
                //if (i >= 15) { break; }
            }

            if (!file_found)
            {
                MessageBox.Show("Файла не существует",
                                "Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.DefaultDesktopOnly);
            }

            return;
        }

        private void button_for_get_info_Click(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists(Path.Combine(fold_path, file_name)))
            {
                //MessageBox.Show("Файла не существует");

                MessageBox.Show("Файла не существует",
                                "Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.DefaultDesktopOnly);

                return;
            }

            if (!((file_name = file_name_textbox_1.Text).Length != 0 & fold_path.Length != 0))
            {
                MessageBox.Show("Имя файла/путь пустой",
                                "Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.DefaultDesktopOnly);

                return;
            }

            System.IO.FileInfo file = new System.IO.FileInfo(Path.Combine(fold_path, file_name));
            
            /*MessageBox.Show($"Имя файла: {file.Name} байт" +
                            $"Путь файла: {file.FullName} байт" +
                            $"Размер файла: {file.Length} байт" +
                            $"Дата создания файла: {file.CreationTime} байт" +
                            $"Расширение файла: {file.Extension} байт");*/

            MessageBox.Show($"Имя файла: {file.Name}\r\n" +
                            $"Путь файла: {file.FullName}\r\n" +
                            $"Размер файла: {file.Length} байт\r\n" +
                            $"Дата создания файла: {file.CreationTime}\r\n" +
                            $"Расширение файла: {file.Extension}\r\n",
                            "Сообщение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.DefaultDesktopOnly);
        }
    }
}
