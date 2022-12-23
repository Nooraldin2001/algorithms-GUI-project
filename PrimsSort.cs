using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algo_Project
{
    class PrimsSort
    {
        public static int Verticies;
        public int insert(MetroFramework.Controls.MetroTextBox metroTextBox)
        {
            // عدد الفيرتكس اللي في الجراف
            Verticies = Convert.ToInt32(metroTextBox.Text);
            return Verticies;
        }

        public void Fill_Graph(MetroFramework.Controls.MetroTextBox metroTextBox)
        {
            //int arrayLength = Convert.ToInt32(Verticies);

            //int[,] tree = new int[arrayLength, arrayLength];

            //for (int i = 0; i < arrayLength; i++)
            //{
            //    for (int j = 0; j < arrayLength; j++)
            //    {
            //        tree[i, j] = Convert.ToInt32(metroTextBox.Text);
            //    }
            //}
        }

        
        static int minKey(int[] key, bool[] mstSet)
        {

            // Initialize min value
            int min = int.MaxValue, min_index = -1;

            for (int v = 0; v < Verticies; v++)
                if (mstSet[v] == false && key[v] < min)
                {
                    min = key[v];
                    min_index = v;
                }

            return min_index;
        }

        
        public void primMST(int[,] graph)
        {

            int[] parent = new int[Verticies];

            int[] key = new int[Verticies];

            bool[] mstSet = new bool[Verticies];

            for (int i = 0; i < Verticies; i++)
            {
                key[i] = int.MaxValue;
                mstSet[i] = false;
            }

            key[0] = 0;
            parent[0] = -1;

            for (int count = 0; count < Verticies - 1; count++)
            {

                int u = minKey(key, mstSet);

                mstSet[u] = true;

                for (int v = 0; v < Verticies; v++)

                    if (graph[u, v] != 0 && mstSet[v] == false
                        && graph[u, v] < key[v])
                    {
                        parent[v] = u;
                        key[v] = graph[u, v];
                    }
            }
            Form1 form1 = new Form1();
            form1.printMST(parent, graph);
        }
    }
}
