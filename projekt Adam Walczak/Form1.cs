using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace projekt_Adam_Walczak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
            else
            {
                if(checkBox1.Checked == false && checkBox2.Checked == false)
                {
                    checkBox3.Checked = true;
                }
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
            }
            else
            {
                if (checkBox1.Checked == false && checkBox2.Checked == false)
                {
                    checkBox3.Checked = true;
                }
            }

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
            }
            else
            {
                if (checkBox1.Checked == false && checkBox2.Checked == false)
                {
                    checkBox3.Checked = true;
                }
            }

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if((checkBox4.Checked == true) || (checkBox5.Checked == true) || (checkBox6.Checked == true) || (checkBox7.Checked == true)
               || (checkBox8.Checked == true))
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if ((checkBox4.Checked == true) || (checkBox5.Checked == true) || (checkBox6.Checked == true) || (checkBox7.Checked == true)
               || (checkBox8.Checked == true))
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if ((checkBox4.Checked == true) || (checkBox5.Checked == true) || (checkBox6.Checked == true) || (checkBox7.Checked == true)
               || (checkBox8.Checked == true))
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if ((checkBox4.Checked == true) || (checkBox5.Checked == true) || (checkBox6.Checked == true) || (checkBox7.Checked == true)
               || (checkBox8.Checked == true))
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if ((checkBox4.Checked == true) || (checkBox5.Checked == true) || (checkBox6.Checked == true) || (checkBox7.Checked == true)
               || (checkBox8.Checked == true))
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            int count = 0;
            int ilosc = (int)numericUpDown1.Value;
            int[] tab = new int[ilosc];
            int[] kopia = new int[ilosc];

            if(checkBox1.Checked == true)
            {
                for(int i=0; i<tab.Length; i++)
                {
                    tab[i] = i;
                    kopia[i] = tab[i];
                }
            }
            else if(checkBox2.Checked == true)
            {
                for(int i=tab.Length-1; i>=0;i--)
                {
                    tab[i] = i;
                    kopia[i] = tab[i];
                }
            }
            else
            {
                Random r = new Random();
                for(int i=0;i<tab.Length;i++)
                {
                    tab[i] = r.Next(1,tab.Length);
                    kopia[i] = tab[i];
                }
            }

            Series s = new Series("SortowanieBąbelkowe");
            s.BorderWidth = 3; // Ustaw grubość linii
            s.BorderDashStyle = ChartDashStyle.Solid; // Ustaw solidny styl linii

            int lol;
            if (checkBox4.Checked)
            {
                SortowanieBabelkowe sort = new SortowanieBabelkowe();
                int var = sort.Sortuj(tab, ref count);
                s.Points.AddXY((double)numericUpDown1.Value, var);
                for (int i = 0; i < tab.Length; i++)
                {
                    tab[i] = kopia[i];
                }
                lol = var;

                
                chart1.Series.Add(s);
                chart1.ChartAreas[0].RecalculateAxesScale();
                
            }


            s = new Series("SortowaniePrzezWybór");
            s.BorderWidth = 3; // Ustaw grubość linii
            s.BorderDashStyle = ChartDashStyle.Solid;

           
            if (checkBox5.Checked == true)
            {
                SortowaniePrzezWybor sort = new SortowaniePrzezWybor();
                int var = sort.Sortuj(tab, ref count);
                s.Points.AddXY((double)numericUpDown1.Value, var);
                for (int i = 0; i < tab.Length; i++)
                {
                    tab[i] = kopia[i];
                }
                lol = var;

                chart1.Series.Add(s);
                chart1.ChartAreas[0].RecalculateAxesScale();



            }

            s = new Series("SortowanieSzybkie");
            s.BorderWidth = 3; // Ustaw grubość linii
            s.BorderDashStyle = ChartDashStyle.Solid;

            if (checkBox6.Checked == true)
            {
                SortowanieSzybkie sort = new SortowanieSzybkie();
                int var = sort.Sortuj(tab, ref count);
                s.Points.AddXY((double)numericUpDown1.Value, var);
                for (int i = 0; i < tab.Length; i++)
                {
                    tab[i] = kopia[i];
                }
                lol = var;

                chart1.Series.Add(s);
                chart1.ChartAreas[0].RecalculateAxesScale();



            }

            s = new Series("SortowaniePrzezScalanie");
            s.BorderWidth = 3; // Ustaw grubość linii
            s.BorderDashStyle = ChartDashStyle.Solid;

            if (checkBox7.Checked == true)
            {
                SortowaniePrzezScalanie sort = new SortowaniePrzezScalanie();
                int var = sort.Sortuj(tab, ref count);
                s.Points.AddXY((double)numericUpDown1.Value, var);
                for (int i = 0; i < tab.Length; i++)
                {
                    tab[i] = kopia[i];
                }
                lol = var;

                chart1.Series.Add(s);
                chart1.ChartAreas[0].RecalculateAxesScale();



            }


            s = new Series("SortowaniePrzezWstawianie");
            s.BorderWidth = 3; // Ustaw grubość linii
            s.BorderDashStyle = ChartDashStyle.Solid;

            if (checkBox8.Checked == true)
            {
                SortowaniePrzezWstawianie sort = new SortowaniePrzezWstawianie();
                int var = sort.Sortuj(tab, ref count);
                s.Points.AddXY((double)numericUpDown1.Value, var);
                for (int i = 0; i < tab.Length; i++)
                {
                    tab[i] = kopia[i];
                }
                lol = var;

                chart1.Series.Add(s);
                chart1.ChartAreas[0].RecalculateAxesScale();



            }










        }
    }




    public interface ISortowanie
    {
        int Sortuj(int[] tablica,ref int count);
    }

   

public class SortowanieBabelkowe : ISortowanie
    {
        public int Sortuj(int[] tablica,ref int count)
        {
            for (int i = 0; i < tablica.Length - 1; i++)
                for (int j = 0; j < tablica.Length - i - 1; j++)
                {
                    if (tablica[j] > tablica[j + 1])
                    {
                        int temp = tablica[j];
                        tablica[j] = tablica[j + 1];
                        tablica[j + 1] = temp;
                    }
                    count++;
                }
            int var = count;
            count = 0;
            return var;

        }
    }


    

public class SortowaniePrzezWybor : ISortowanie
    {
        public int Sortuj(int[] tablica,ref int count)
        {
            int n = tablica.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIdx = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (tablica[j] < tablica[minIdx])
                        minIdx = j;

                    count++;
                }

                int temp = tablica[minIdx];
                tablica[minIdx] = tablica[i];
                tablica[i] = temp;
            }

            int var = count;
            count = 0;
            return var;

        }
    }


    

public class SortowanieSzybkie : ISortowanie
    {
        public int Sortuj(int[] tablica,ref int count)
        {
            QuickSort(tablica, 0, tablica.Length - 1,ref count);
            int var = count;
            count = 0;
            return var;
        }

        private void QuickSort(int[] tablica, int low, int high,ref int count)
        {
            if (low < high)
            {
                int pi = Partition(tablica, low, high,ref count);

                QuickSort(tablica, low, pi - 1,ref count);
                QuickSort(tablica, pi + 1, high,ref count);
            }
        }

        private int Partition(int[] tablica, int low, int high,ref int count)
        {
            int pivot = tablica[high];
            int i = (low - 1);

            for (int j = low; j < high; j++)
            {
                if (tablica[j] < pivot)
                {
                    i++;

                    int temp = tablica[i];
                    tablica[i] = tablica[j];
                    tablica[j] = temp;
                }
                count++;
                
            }

            int temp1 = tablica[i + 1];
            tablica[i + 1] = tablica[high];
            tablica[high] = temp1;

            return i + 1;
        }
    }


    

public class SortowaniePrzezWstawianie : ISortowanie
    {
        public int Sortuj(int[] tablica,ref int count)
        {
            for (int i = 1; i < tablica.Length; ++i)
            {
                int klucz = tablica[i];
                int j = i - 1;

                while (j >= 0 && tablica[j] > klucz)
                {
                    tablica[j + 1] = tablica[j];
                    j--;
                    count++;
                }
                tablica[j + 1] = klucz;
            }
            int var = count;
            count = 0;
            return var;
        }
    }


public class SortowaniePrzezScalanie : ISortowanie
    {
        public int Sortuj(int[] tablica, ref int count)
        {
            MergeSort(tablica, 0, tablica.Length - 1,ref count);
            int var = count;
            count = 0;
            return var;
        }

        private void MergeSort(int[] tablica, int left, int right,ref int count)
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;

                MergeSort(tablica, left, middle,ref count);
                MergeSort(tablica, middle + 1, right,ref count);

                Merge(tablica, left, middle, right, ref count);
            }
        }

        private void Merge(int[] tablica, int left, int middle, int right,ref int count)
        {
            int n1 = middle - left + 1;
            int n2 = right - middle;

            int[] L = new int[n1];
            int[] R = new int[n2];
            for (int b = 0; b < n1; ++b)
            {
                L[b] = tablica[left + b];
            }
            for (int y = 0; y < n2; ++y)
            {
                R[y] = tablica[middle + 1 + y];
            }

            int i = 0, j = 0;

            int k = left;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    tablica[k] = L[i];
                    i++;
                }
                else
                {
                    tablica[k] = R[j];
                    j++;
                }
                k++;
                count++;
            }

            while (i < n1)
            {
                tablica[k] = L[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                tablica[k] = R[j];
                j++;
                k++;
            }
        }
    }

}
