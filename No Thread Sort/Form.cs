using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
namespace No_Thread_Sort
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }
        private static int s = 1;

        private List<int> Sort_Array = new List<int>();

        private void browse_button_Click(object sender, EventArgs e)
        {
            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {
                this.path.Text = openfiledialog.FileName;
            }
        }

        private void ok_button_Click(object sender, EventArgs e)
        {

            if (!File.Exists(path.Text))
                MessageBox.Show("Wrong!! Select The Right File Path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                textBox.Clear();
                Sort_Array.Clear();
                progressBar.Style = ProgressBarStyle.Marquee;
                ok_button.Enabled = false;
                browse_button.Enabled = false;
                path.Enabled = false;
                generate_checkBox.Enabled = false;
                Sort_button.Enabled = false;
                int line;
                int counter = 0;
                StreamReader file = new StreamReader(path.Text);
                while (int.TryParse(file.ReadLine(), out line))
                {
                    Sort_Array.Add(line);
                    textBox.AppendText(Sort_Array[counter].ToString() + Environment.NewLine);
                    Counter.Text = counter++.ToString();
                }
                file.Close();
                Counter.Text = counter.ToString();
                progressBar.Style = ProgressBarStyle.Blocks;
                ok_button.Enabled = true;
                browse_button.Enabled = true;
                path.Enabled = true;
                generate_checkBox.Enabled = true;
                Sort_button.Enabled = true;
            }
        }

        private void generate_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (generate_checkBox.Checked)
            {
                path.Enabled = false;
                ok_button.Enabled = false;
                browse_button.Enabled = false;
                label.Enabled = false;
                Generate_button.Enabled = true;
                max_label.Enabled = true;
                min_label.Enabled = true;
                length_label.Enabled = true;
                max_textBox.Enabled = true;
                min_textBox.Enabled = true;
                length_textBox.Enabled = true;
            }
            else
            {
                path.Enabled = true;
                ok_button.Enabled = true;
                browse_button.Enabled = true;
                label.Enabled = true;
                Generate_button.Enabled = false;
                max_label.Enabled = false;
                min_label.Enabled = false;
                length_label.Enabled = false;
                max_textBox.Enabled = false;
                min_textBox.Enabled = false;
                length_textBox.Enabled = false;
            }
        }

        private void Generate_button_Click(object sender, EventArgs e)
        {
            if (max_textBox.Text.Length == 0 || min_textBox.Text.Length == 0 || length_textBox.Text.Length == 0)
            {
                MessageBox.Show("All Fields are Required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int length, min, max;
            if (int.TryParse(max_textBox.Text, out max) && int.TryParse(min_textBox.Text, out min) && int.TryParse(length_textBox.Text, out length)) ;
            else
            {
                MessageBox.Show("Input Must be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            textBox.Clear();
            Sort_Array.Clear();
            progressBar.Style = ProgressBarStyle.Marquee;
            min_textBox.Enabled = false;
            max_textBox.Enabled = false;
            length_textBox.Enabled = false;
            Generate_button.Enabled = false;
            generate_checkBox.Enabled = false;
            Sort_button.Enabled = false;
            Random Rand = new Random();
            int i;
            for (i = 0; i < length; i++)
            {
                Sort_Array.Add(Rand.Next(min, max));
                textBox.AppendText(Sort_Array[i].ToString() + Environment.NewLine);
                Counter.Text = i.ToString();
            }
            Counter.Text = i.ToString();
            progressBar.Style = ProgressBarStyle.Blocks;
            min_textBox.Enabled = true;
            max_textBox.Enabled = true;
            length_textBox.Enabled = true;
            Generate_button.Enabled = true;
            generate_checkBox.Enabled = true;
            Sort_button.Enabled = true;
        }

        private void Sort_button_Click(object sender, EventArgs e)
        {
            Sort_button.Enabled = false;
            progressBar.Style = ProgressBarStyle.Marquee;
            if (Bubble_radioButton.Checked)
                Bubble_Sort();
            else if (insertion_radioButton.Checked)
                Insert_Sort();
            else if (Quick_radioButton.Checked)
                Quick_Sort();
            else if (Selection_radioButton.Checked)
                Selection_Sort();
        }

        /////////////////////////Algorithms///////////////////////////////

        public static void exchange(int[] data, int m, int n)
        {
            int temporary;

            temporary = data[m];
            data[m] = data[n];
            data[n] = temporary;
        }

        //
        //Bubble Sort
        //

        private void Bubble_Sort()
        {
            int[] barray = Sort_Array.ToArray();
            IntArrayBubbleSort(barray);
            textBox.Invoke((MethodInvoker)delegate { textBox.Clear(); });
            for (int i = 0; i < barray.Length; i++)
            {
                textBox.Invoke((MethodInvoker)delegate { textBox.AppendText(barray[i].ToString() + Environment.NewLine); });
            }
            Sort_button.Enabled = true;
            progressBar.Style = ProgressBarStyle.Blocks;
            result_textBox.Text = "Using : Bubble Sort";
        }
        public static void IntArrayBubbleSort(int[] data)
        {
            int i, j;
            int N = data.Length;

            for (j = N - 1; j > 0; j--)
            {
                for (i = 0; i < j; i++)
                {
                    if (data[i] > data[i + 1])
                        exchange(data, i, i + 1);
                }
            }
        }

        //
        //Selection Sort
        //

        private void Selection_Sort()
        {
            //Thread.Sleep(1);
            int[] sarray = Sort_Array.ToArray();
            IntArraySelectionSort(sarray);
            textBox.Clear();
            for (int i = 0; i < sarray.Length; i++)
            {
                textBox.AppendText(sarray[i].ToString() + Environment.NewLine);
            }
            Sort_button.Enabled = true;
            progressBar.Style = ProgressBarStyle.Blocks;
            result_textBox.Text = "Using : Selection Sort";
        }
        public static int IntArrayMin(int[] data, int start)
        {
            int minPos = start;
            for (int pos = start + 1; pos < data.Length; pos++)
                if (data[pos] < data[minPos])
                    minPos = pos;
            return minPos;
        }
        public static void IntArraySelectionSort(int[] data)
        {
            int i;
            int N = data.Length;

            for (i = 0; i < N - 1; i++)
            {
                int k = IntArrayMin(data, i);
                if (i != k)
                    exchange(data, i, k);
            }
        }

        //
        //Insert Sort
        //

        private void Insert_Sort()
        {
            int[] iarray = Sort_Array.ToArray();
            IntArrayInsertionSort(iarray);
            textBox.Clear();
            for (int i = 0; i < iarray.Length; i++)
            {
                textBox.AppendText(iarray[i].ToString() + Environment.NewLine);
            }
            Sort_button.Enabled = true;
            progressBar.Style = ProgressBarStyle.Blocks;
            result_textBox.Text = "Using : Insert Sort";
        }
        //public static T[] PerformInsertionSort<T>(T[] inputarray, Comparer<T> comparer = null)
        //{
        //    var equalityComparer = comparer ?? Comparer<T>.Default;
        //    for (var counter = 0; counter < inputarray.Length - 1; counter++)
        //    {
        //        var index = counter + 1;
        //        while (index > 0)
        //        {
        //            if (equalityComparer.Compare(inputarray[index - 1], inputarray[index]) > 0)
        //            {
        //                var temp = inputarray[index - 1];
        //                inputarray[index - 1] = inputarray[index];
        //                inputarray[index] = temp;
        //            }
        //            index--;
        //        }
        //    }
        //    return inputarray;
        //}
        public static void IntArrayInsertionSort(int[] data)
        {
            int i, j;
            int N = data.Length;

            for (j = 1; j < N; j++)
            {
                for (i = j; i > 0 && data[i] < data[i - 1]; i--)
                {
                    exchange(data, i, i - 1);
                }
            }
        }

        //
        //Quick Sort
        //

        private void Quick_Sort()
        {
            int[] qarray = Sort_Array.ToArray();
            IntArrayQuickSort(qarray);
            textBox.Clear();
            for (int i = 0; i < qarray.Length; i++)
            {
                textBox.AppendText(qarray[i].ToString() + Environment.NewLine);
            }
            Sort_button.Enabled = true;
            progressBar.Style = ProgressBarStyle.Blocks;
            result_textBox.Text = "Using : Quick Sort";
        }
        public static void IntArrayQuickSort(int[] data, int l, int r)
        {
            int i, j;
            int x;

            i = l;
            j = r;

            x = data[(l + r) / 2]; /* find pivot item */
            while (true)
            {
                while (data[i] < x)
                    i++;
                while (x < data[j])
                    j--;
                if (i <= j)
                {
                    exchange(data, i, j);
                    i++;
                    j--;
                }
                if (i > j)
                    break;
            }
            if (l < j)
                IntArrayQuickSort(data, l, j);
            if (i < r)
                IntArrayQuickSort(data, i, r);
        }
        public static void IntArrayQuickSort(int[] data)
        {
            IntArrayQuickSort(data, 0, data.Length - 1);
        }
    }
}
