using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool x_turn = true;

        private void button1_Click(object sender, EventArgs e)
        {
            Button senB = (Button)sender;
            if (x_turn)
            {
                senB.Text= "X";
            }
            else
            {
                senB.Text= "O";
            }
            x_turn = !x_turn;
            senB.Enabled = false;
            CheckWin();
        }
        void CheckWin()
        {
            string[] but = { but1.Text, but2.Text, but3.Text, but4.Text, but5.Text, but6.Text, but7.Text, but8.Text, but9.Text, };
            for (int i = 0; i < 3; i++)
            {
                int n = i * 3;
                if (but[n] == but[n + 1] && but[n + 1] == but[n + 2] && but[n] != "")
                {
                    Win(but[n]);
                }
                if (but[i] == but[i + 3] && but[i + 3] == but[i + 6] && but[i] != "")
                {
                    Win(but[i]);
                }
            }
            if (but[0] == but[4] && but[4] == but[8] && but[4] != "" || but[2] == but[4] && but[4] == but[6] && but[4] != "")
            {
                Win(but[4]);
            }
            bool draw = true;
            foreach (string i in but)
            {
                if (i == "") { draw = false; break; }
            }
            if (draw) { Draw(""); }
        }
        void Win(string mes)
        {
            MessageBox.Show("выйграли " + mes);
            Application.Restart();
        }
        void Draw(string mes)
        {
            MessageBox.Show("ничья" + mes);
            Application.Restart();
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Игроки по очереди ставят на свободные клетки поля 3×3 знаки (один всегда крестики, другой всегда нолики). Первый, выстроивший в ряд 3 своих фигуры по вертикали, горизонтали или диагонали, выигрывает. Первый ход делает игрок, ставящий крестики.",
                "Справка"
                );
        }
    }
    
}
