using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лабараторная1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // 1.Проверяем, введена ли сумма в рублях
    if (string.IsNullOrWhiteSpace(txtRub.Text))
            {
                MessageBox.Show("Введите сумму в рублях!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Пытаемся преобразовать текст в число (добавил замену точки на запятую на всякий случай)
            if (!double.TryParse(txtRub.Text.Trim().Replace('.', ','), out double rubles))
            {
                MessageBox.Show("Введите корректное числовое значение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. Определяем курс в зависимости от выбранной радиокнопки
            double rateUsd = 0;
            double rateEur = 0;

            if (rbNormal.Checked)
            {
                // Обычный курс
                rateUsd = 81.0;
                rateEur = 91.0;
            }
            else if (rbPreferential.Checked)
            {
                // Льготный курс (пример)
                rateUsd = 76.0;
                rateEur = 89.0;
            }
            else
            {
                MessageBox.Show("Выберите тип курса (обычный или льготный)!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 4. Выполняем расчет
            double resultUsd = rubles / rateUsd;
            double resultEur = rubles / rateEur;

            // 5. Выводим результат (округляем до 2 знаков)
            // ВАЖНО: Здесь Label3 и Label2 меняем на txtUsd и txtEur (твои текстовые поля)
            txtUsd.Text = Math.Round(resultUsd, 2).ToString();
            txtEur.Text = Math.Round(resultEur, 2).ToString();
        }
    }
}
  