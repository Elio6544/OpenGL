using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace OpenGLLab7
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsFormLoad(object sender, EventArgs e)
        {
            // todo: 002 Загрузить настройки программы-заставки в режиме конфигурации
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\MyScreenSaver"))
            {
                if (key != null)
                {
                    if (key.GetValue("HeartColor") != null)
                        colorHeart_button.BackColor = Color.FromArgb((int)key.GetValue("HeartColor"));

                    if (key.GetValue("BackgroundColor") != null)
                        bgColor_button.BackColor = Color.FromArgb((int)key.GetValue("BackgroundColor"));

                    if (key.GetValue("Heartbeat") != null)
                        heartbeat_numeric.Value = Convert.ToDecimal(key.GetValue("Heartbeat"));

                    if(key.GetValue("HeartSize") != null)
                        sizeHeart_numeric.Value = Convert.ToDecimal(key.GetValue("HeartSize"));
                }
            }

            Debug.WriteLine("Load screen saver's settings.");
        }

        private void SettingsFormClosed(object sender, FormClosedEventArgs e)
        {
            // todo: 001 Сохранить настройки программы-заставки в режиме конфигурации
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Software\MyScreenSaver"))
            {
                if (key != null)
                {
                    key.SetValue("HeartColor", colorHeart_button.BackColor.ToArgb());
                    key.SetValue("Heartbeat", (float)heartbeat_numeric.Value);
                    key.SetValue("HeartSize", (float)sizeHeart_numeric.Value);

                    key.SetValue("BackgroundColor", bgColor_button.BackColor.ToArgb());
                }
            }

            Debug.WriteLine("Save screen saver's settings.");
        }

        private void colorHeart_button_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр диалога выбора цвета
            using (ColorDialog colorDialog = new ColorDialog())
            {
                // Настраиваем диалог, если нужно (например, начальный цвет)
                colorDialog.FullOpen = true; // Показывает всю палитру
                colorDialog.Color = this.BackColor; // Начальный цвет

                // Показываем диалог и проверяем, выбрал ли пользователь цвет
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    // Устанавливаем выбранный цвет, например, как цвет фона формы
                    colorHeart_button.BackColor = colorDialog.Color;
                }
            }
        }

        private void bgColor_button_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр диалога выбора цвета
            using (ColorDialog colorDialog = new ColorDialog())
            {
                // Настраиваем диалог, если нужно (например, начальный цвет)
                colorDialog.FullOpen = true; // Показывает всю палитру
                colorDialog.Color = this.BackColor; // Начальный цвет

                // Показываем диалог и проверяем, выбрал ли пользователь цвет
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    // Устанавливаем выбранный цвет, например, как цвет фона формы
                    bgColor_button.BackColor = colorDialog.Color;
                }
            }
        }
    }
}
