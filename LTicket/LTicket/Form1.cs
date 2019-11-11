using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTicket
{
    public partial class Form1 : Form
    {
        int[] maxnumb = { 9, 9, 9 };
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {            
            int maxSumm=0;
            // Для начала нужно посчитать количество одинаковых сумм для первой 
            // половины шестизначного числа. Т.е. от 0 до 999;
            // Максимально возможная сумма из трех цифр:
            foreach (int value in maxnumb) { maxSumm+=value; };            

            // Т.е. всего возможно 27 различных сумм плюс нулевая сумма.
            // Итого нужен массив на 27 + 1 ячеек.
            uint[] summs = new uint[maxSumm + 1];

            // Цикл крутится по рязрядам. Сумма рязрядов i + j + k будет иднексом для ячейки.
            // Будет происходить обращение к этой ячейке и ее увеличение на еденицу.
            // Т.о. определяется частота определенной суммы (индекс ячейки равен сумме разрядов, значение
            // в ячейке - как часто эта сумма встречалась).
            for (int i = 0; i <= maxnumb[0]; ++i)
            {
                for (int j = 0; j <= maxnumb[1]; ++j)
                {
                    for (int k = 0; k <= maxnumb[2]; ++k)
                    {
                        ++summs[i + j + k];
                    }
                }
            }

            // Теперь в массиве есть частота различных сумм. Остается сложить квадраты
            // этих частот.
            uint happyTickets = 0;
            for (int i = 0; i < maxSumm; ++i)
            {
                happyTickets += summs[i] * summs[i];
            }
            textBoxOutp.Text = Convert.ToString(happyTickets); 
        }       
    }
}
