using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algo_Project
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        public int size;
        public int[] arr;
        public int indexInput = 0; 

        private void SortBTN_Click(object sender, EventArgs e)
        {
            InsertionSort insertionSort = new InsertionSort(); 
            insertionSort.Sort(arr, arr.Length);
            viewArray();
        }

        private void insertArr_Click(object sender, EventArgs e)
        {
            if (indexInput < size)
            {
                arr[indexInput] = Convert.ToInt32(arrTb.Text);
                indexInput++;
            }
            viewArray();
        }
       
        private void viewArray()
        {
            label1.Text = "";

            for (int num = 1; num < size; num++)
            {
                label1.Text += arr[num].ToString() + "\n";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            viewArray();
        }

        private void insertArraySize_Click(object sender, EventArgs e)
        {
            size = Convert.ToInt32(arraySize.Text);
            arr = new int[size];
            viewArray();
        }

        private void mergeSortBtn_Click(object sender, EventArgs e)
        {
            Merge_Sort merge_Sort = new Merge_Sort();
           merge_Sort.Sort(arr, 0, arr.Length - 1);
            viewArray();
        }

        PrimsSort primsSort = new PrimsSort();

        private void V_num_insert_Click(object sender, EventArgs e)
        {
            primsSort.insert(Verticies_Tb);
            int[,] graph = new int[,] { { 0, 2, 0, 6, 0 },
                                      { 2, 0, 3, 8, 5 },
                                      { 0, 3, 0, 0, 7 },
                                      { 6, 8, 0, 0, 9 },
                                      { 0, 5, 7, 9, 0 } };

            // Print the solution
            primsSort.primMST(graph);
        }

        public void printMST(int[] parent, int[,] graph)
        {
            Graph_tb.Text = ("Edge \tWeight");
            for (int i = 1; i < 5;  i++)
                Graph_tb.Text = (parent[i] + " - " + i + "\t"
                                  + graph[i, parent[i]]);
        }

        private void Graph_insert_Click(object sender, EventArgs e)
        {
           primsSort.Fill_Graph(Graph_tb);
        }
    }
}
