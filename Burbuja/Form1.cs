using System;

using System.Windows.Forms;

namespace Burbuja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] Array;

        private void btnN_Click(object sender, EventArgs e)
        {
            int N;

            N = int.Parse(TextBoxN.Text);

            Array= new int[N];

           int i = 0;
            int Number;

            while (i < N)
            {
                Array[i] = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Enter Random Numbers"));
                i++;
            }
            listBox1.Items.Add("Disorganized Array");
            i = 0;
            while (i < N)
            {
                
                listBox1.Items.Add(Array[i]);
                i++;
            }
            i = 0;
            while (i < N)
            {
                int j = 0;
                while (j <( N -1))
                {
                    if (Array[j] > Array[j + 1])
                    {
                        Number = Array[j];
                        Array[j] = Array[j + 1]; 
                        Array[j + 1]= Number;
                    }
                    j++;
                }
                i++;
            }

            listBox1.Items.Add("Organized Array");
            i = 0;
            while (i < N)
            {
                listBox1.Items.Add(Array[i]);
                i++;
            }
            
        }
    }
}
