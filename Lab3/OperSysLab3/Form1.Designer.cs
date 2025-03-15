namespace OperSysLab3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button_for_create = new System.Windows.Forms.Button();
            this.file_name_textbox_1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_dir_select = new System.Windows.Forms.Button();
            this.button_for_del = new System.Windows.Forms.Button();
            this.path_textbox1 = new System.Windows.Forms.TextBox();
            this.button_for_copy = new System.Windows.Forms.Button();
            this.button_for_move = new System.Windows.Forms.Button();
            this.button_for_rename = new System.Windows.Forms.Button();
            this.button_for_get_size = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.file_name_textbox_2 = new System.Windows.Forms.TextBox();
            this.path_textbox2 = new System.Windows.Forms.TextBox();
            this.Button_dir_copy_sel = new System.Windows.Forms.Button();
            this.Button_to_file = new System.Windows.Forms.Button();
            this.Trash_button = new System.Windows.Forms.Button();
            this.button_for_get_info = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_for_create
            // 
            this.button_for_create.Location = new System.Drawing.Point(589, 12);
            this.button_for_create.Name = "button_for_create";
            this.button_for_create.Size = new System.Drawing.Size(199, 42);
            this.button_for_create.TabIndex = 0;
            this.button_for_create.Text = "Создать файл";
            this.button_for_create.UseVisualStyleBackColor = true;
            this.button_for_create.Click += new System.EventHandler(this.button_click_file_crt);
            // 
            // file_name_textbox_1
            // 
            this.file_name_textbox_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.file_name_textbox_1.Location = new System.Drawing.Point(284, 63);
            this.file_name_textbox_1.Name = "file_name_textbox_1";
            this.file_name_textbox_1.Size = new System.Drawing.Size(254, 39);
            this.file_name_textbox_1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имя файла с расширением";
            // 
            // Button_dir_select
            // 
            this.Button_dir_select.Location = new System.Drawing.Point(12, 252);
            this.Button_dir_select.Name = "Button_dir_select";
            this.Button_dir_select.Size = new System.Drawing.Size(219, 42);
            this.Button_dir_select.TabIndex = 4;
            this.Button_dir_select.Text = "Выбрать путь файла";
            this.Button_dir_select.UseVisualStyleBackColor = true;
            this.Button_dir_select.Click += new System.EventHandler(this.button1_Click_dir_sel);
            // 
            // button_for_del
            // 
            this.button_for_del.Location = new System.Drawing.Point(589, 60);
            this.button_for_del.Name = "button_for_del";
            this.button_for_del.Size = new System.Drawing.Size(199, 42);
            this.button_for_del.TabIndex = 5;
            this.button_for_del.Text = "Удалить файл";
            this.button_for_del.UseVisualStyleBackColor = true;
            this.button_for_del.Click += new System.EventHandler(this.button_click_file_del);
            // 
            // path_textbox1
            // 
            this.path_textbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.path_textbox1.Location = new System.Drawing.Point(237, 255);
            this.path_textbox1.Name = "path_textbox1";
            this.path_textbox1.ReadOnly = true;
            this.path_textbox1.Size = new System.Drawing.Size(346, 39);
            this.path_textbox1.TabIndex = 6;
            // 
            // button_for_copy
            // 
            this.button_for_copy.Location = new System.Drawing.Point(589, 108);
            this.button_for_copy.Name = "button_for_copy";
            this.button_for_copy.Size = new System.Drawing.Size(199, 42);
            this.button_for_copy.TabIndex = 7;
            this.button_for_copy.Text = "Копировать файл";
            this.button_for_copy.UseVisualStyleBackColor = true;
            this.button_for_copy.Click += new System.EventHandler(this.button_click_file_copy);
            // 
            // button_for_move
            // 
            this.button_for_move.Location = new System.Drawing.Point(589, 156);
            this.button_for_move.Name = "button_for_move";
            this.button_for_move.Size = new System.Drawing.Size(199, 42);
            this.button_for_move.TabIndex = 8;
            this.button_for_move.Text = "Переместить файл";
            this.button_for_move.UseVisualStyleBackColor = true;
            this.button_for_move.Click += new System.EventHandler(this.button_click_file_move);
            // 
            // button_for_rename
            // 
            this.button_for_rename.Location = new System.Drawing.Point(589, 204);
            this.button_for_rename.Name = "button_for_rename";
            this.button_for_rename.Size = new System.Drawing.Size(199, 42);
            this.button_for_rename.TabIndex = 9;
            this.button_for_rename.Text = "Переименовать файл";
            this.button_for_rename.UseVisualStyleBackColor = true;
            this.button_for_rename.Click += new System.EventHandler(this.button_click_file_rename);
            // 
            // button_for_get_size
            // 
            this.button_for_get_size.Location = new System.Drawing.Point(589, 252);
            this.button_for_get_size.Name = "button_for_get_size";
            this.button_for_get_size.Size = new System.Drawing.Size(199, 42);
            this.button_for_get_size.TabIndex = 10;
            this.button_for_get_size.Text = "Опр. размер файла";
            this.button_for_get_size.UseVisualStyleBackColor = true;
            this.button_for_get_size.Click += new System.EventHandler(this.button_click_file_sizeof);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Новое имя файла";
            // 
            // file_name_textbox_2
            // 
            this.file_name_textbox_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.file_name_textbox_2.Location = new System.Drawing.Point(284, 139);
            this.file_name_textbox_2.Name = "file_name_textbox_2";
            this.file_name_textbox_2.Size = new System.Drawing.Size(254, 39);
            this.file_name_textbox_2.TabIndex = 11;
            // 
            // path_textbox2
            // 
            this.path_textbox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.path_textbox2.Location = new System.Drawing.Point(237, 303);
            this.path_textbox2.Name = "path_textbox2";
            this.path_textbox2.ReadOnly = true;
            this.path_textbox2.Size = new System.Drawing.Size(346, 39);
            this.path_textbox2.TabIndex = 14;
            // 
            // Button_dir_copy_sel
            // 
            this.Button_dir_copy_sel.Location = new System.Drawing.Point(12, 300);
            this.Button_dir_copy_sel.Name = "Button_dir_copy_sel";
            this.Button_dir_copy_sel.Size = new System.Drawing.Size(219, 42);
            this.Button_dir_copy_sel.TabIndex = 13;
            this.Button_dir_copy_sel.Text = "Выбрать второй путь";
            this.Button_dir_copy_sel.UseVisualStyleBackColor = true;
            this.Button_dir_copy_sel.Click += new System.EventHandler(this.button1_Click_dir_copy_sel);
            // 
            // Button_to_file
            // 
            this.Button_to_file.Location = new System.Drawing.Point(12, 108);
            this.Button_to_file.Name = "Button_to_file";
            this.Button_to_file.Size = new System.Drawing.Size(219, 42);
            this.Button_to_file.TabIndex = 15;
            this.Button_to_file.Text = "Перейти к файлу";
            this.Button_to_file.UseVisualStyleBackColor = true;
            this.Button_to_file.Click += new System.EventHandler(this.Button_to_file_Click);
            // 
            // Trash_button
            // 
            this.Trash_button.Location = new System.Drawing.Point(12, 12);
            this.Trash_button.Name = "Trash_button";
            this.Trash_button.Size = new System.Drawing.Size(219, 72);
            this.Trash_button.TabIndex = 16;
            this.Trash_button.Text = "Восстановить файл (не работает)";
            this.Trash_button.UseVisualStyleBackColor = true;
            this.Trash_button.Click += new System.EventHandler(this.Trash_button_Click);
            // 
            // button_for_get_info
            // 
            this.button_for_get_info.Location = new System.Drawing.Point(589, 300);
            this.button_for_get_info.Name = "button_for_get_info";
            this.button_for_get_info.Size = new System.Drawing.Size(199, 42);
            this.button_for_get_info.TabIndex = 17;
            this.button_for_get_info.Text = "Получить информацию";
            this.button_for_get_info.UseVisualStyleBackColor = true;
            this.button_for_get_info.Click += new System.EventHandler(this.button_for_get_info_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 355);
            this.Controls.Add(this.button_for_get_info);
            this.Controls.Add(this.Trash_button);
            this.Controls.Add(this.Button_to_file);
            this.Controls.Add(this.path_textbox2);
            this.Controls.Add(this.Button_dir_copy_sel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.file_name_textbox_2);
            this.Controls.Add(this.button_for_get_size);
            this.Controls.Add(this.button_for_rename);
            this.Controls.Add(this.button_for_move);
            this.Controls.Add(this.button_for_copy);
            this.Controls.Add(this.path_textbox1);
            this.Controls.Add(this.button_for_del);
            this.Controls.Add(this.Button_dir_select);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.file_name_textbox_1);
            this.Controls.Add(this.button_for_create);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button_for_create;
        private System.Windows.Forms.TextBox file_name_textbox_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_dir_select;
        private System.Windows.Forms.Button button_for_del;
        private System.Windows.Forms.TextBox path_textbox1;
        private System.Windows.Forms.Button button_for_copy;
        private System.Windows.Forms.Button button_for_move;
        private System.Windows.Forms.Button button_for_rename;
        private System.Windows.Forms.Button button_for_get_size;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox file_name_textbox_2;
        private System.Windows.Forms.TextBox path_textbox2;
        private System.Windows.Forms.Button Button_dir_copy_sel;
        private System.Windows.Forms.Button Button_to_file;
        private System.Windows.Forms.Button Trash_button;
        private System.Windows.Forms.Button button_for_get_info;
    }
}

