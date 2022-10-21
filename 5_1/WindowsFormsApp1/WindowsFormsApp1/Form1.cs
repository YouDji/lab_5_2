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

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int M = 4, N= 4;
            int[,] matrix = new int[M, M];
            int[,] matrix_two = new int[N, N];
            int sum = 0;
            int sum_two= 0 ;
            int also = 1;
            int also_two = 0;
            for (int j = 0; j < M; j++)
            {
                for (int m = 0; m < M; m++)
                {
                    matrix[j, m] = rand.Next(-10, 10);
                    Console.Write(matrix[j, m] + " ");
                }
                Console.WriteLine();
                {
                    for (int i = 0; i < M; i++)
                    {
                        sum += matrix[j, i];
                    }
                }
            }
            for (int x = 0; x < N; x++)
            {
                for (int y = 0; y < N; y++)
                {
                    matrix_two[x, y] = rand.Next(-10, 10);
                    Console.Write(matrix_two[x, y] + " ");
                }
                Console.WriteLine();
                {
                    for (int z = 0; z < N; z++)
                    {
                        sum_two += matrix_two[x, z];
                    }
                }
            }
            for (int v = 0; v < 4; v++){
            if (sum > sum_two)   {
                   textBox1.Text = also.ToString();                
             }else textBox1.Text = also_two.ToString();}
        }
    }
}
