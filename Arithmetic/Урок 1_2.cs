﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arithmetic
{
    public partial class Урок_1_2 : Form
    {
        private const string CorrectAnswer = "4";
        public Урок_1_2()
        {
            InitializeComponent();
            labelUserName.Text = $"Пользователь: {AuthInfo.UserName} {AuthInfo.UserSurname} {AuthInfo.UserClass}";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SoundPlayer ss = new SoundPlayer(Properties.Resources._31);
            // Load the sound
            ss.Load();
            // Play the sound synchronously
            ss.PlaySync();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Получаем ответ из текстового поля
            string userAnswer = textBox1.Text.Trim();

            // Проверяем, является ли ответ правильным
            if (userAnswer.Equals(CorrectAnswer, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Правильный ответ!", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form2 form2 = new Form2();
                this.Hide();
               form2.ShowDialog();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Неправильный ответ. Хотите посмотреть решение?", "Результат", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                // Если пользователь выбрал "Да", показываем решение
                if (dialogResult == DialogResult.Yes)
                {
                    Урок_1_п урок_1_П = new Урок_1_п();
                    this.Hide();
                    урок_1_П.ShowDialog();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Урок_1 урок_1 = new Урок_1();
            this.Hide();
            урок_1.ShowDialog();
        }
    }
}
