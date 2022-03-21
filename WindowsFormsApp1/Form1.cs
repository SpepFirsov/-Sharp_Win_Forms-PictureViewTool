using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
       
        }

        private void Show_Button_Click(object sender, EventArgs e)
        {
            //Диалоговое окно выбора файла изображения
            //если пользователь нажал ок то программа загружает выбранный им файл
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            //уборка изображения
            pictureBox1.Image = null;
        }

        private void BckgButton_Click(object sender, EventArgs e)
        {
            // Показать диалоговое окно цвета. Если пользователь нажмет OK, изменяет
            //фон элемента управления PictureBox в выбранный пользователем цвет. 
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            //Закрывает форму
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Если пользователь установит галочку Stretch(Растянуть),
            // меняем в PictureBox
            // Свойство SizeMode в "Растянуть". Если пользователь очищает
            // флажок, изменияет его на "Обычный". 
            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }
    }
}
