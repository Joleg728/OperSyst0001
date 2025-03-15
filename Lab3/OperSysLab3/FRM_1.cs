using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shell32;
using Microsoft.VisualBasic.FileIO;

namespace OperSysLab3
{
    public partial class Form1 : Form
    {
        /*public TreeNode crt_dir_node(DirectoryInfo dir_inf)
        {
            var dir_node = new TreeNode(dir_inf.Name);

            foreach (var dir in dir_inf.GetDirectories())
            {
                dir_node.Nodes.Add(crt_dir_node((dir)));
            }

            foreach (var f in dir_inf.GetFiles())
            {
                dir_node.Nodes.Add(new TreeNode(f.Name));
            }

            return dir_node;
        }
        public void dir_list(TreeView tree, string path)
        {
            tree.Nodes.Clear();

            var root_inf = new DirectoryInfo(path);

            tree.Nodes.Add(crt_dir_node(root_inf));
        }*/


        public void noNameError()
        {
            MessageBox.Show("Имя файла/путь пустой",
                                    "Ошибка",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error,
                                    MessageBoxDefaultButton.Button1,
                                    MessageBoxOptions.DefaultDesktopOnly);

                return;
        }

        public void MyFileCrt(string path, string name)
        {
            IntPtr hFile = CreateFile(
            Path.Combine(path, name),
            GENERIC_WRITE,
            0,
            IntPtr.Zero,
            OPEN_ALWAYS,
            FILE_ATTRIBUTE_NORMAL,
            IntPtr.Zero);

            //File.Create(file_name).Close();

            CloseHandle(hFile);

            return;
        }

        private bool Restore(string Item)
        {
            Shell Shl = new Shell();
            Folder Recycler = Shl.NameSpace(10);
            for (int i = 0; i < Recycler.Items().Count; i++)
            {
                FolderItem FI = Recycler.Items().Item(i);
                string FileName = Recycler.GetDetailsOf(FI, 0);
                if (Path.GetExtension(FileName) == "") FileName += Path.GetExtension(FI.Path);
                //Necessary for systems with hidden file extensions.
                string FilePath = Recycler.GetDetailsOf(FI, 1);
                if (Item == Path.Combine(FilePath, FileName))
                {
                    DoVerb(FI, "ESTORE");
                    return true;
                }
            }
            return false;
        }

        private bool DoVerb(FolderItem Item, string Verb)
        {
            foreach (FolderItemVerb FIVerb in Item.Verbs())
            {
                if (FIVerb.Name.ToUpper().Contains(Verb.ToUpper()))
                {
                    FIVerb.DoIt();
                    return true;
                }
            }
            return false;
        }

        private void Delete(string Item)
        {
            FileSystem.DeleteFile(Item, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
            //Gives the most control of dialogs.
        }
    }
}