namespace Algo_Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SortBTN = new MetroFramework.Controls.MetroButton();
            this.arrTb = new MetroFramework.Controls.MetroTextBox();
            this.insertArr = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.arraySize = new MetroFramework.Controls.MetroTextBox();
            this.insertArraySize = new MetroFramework.Controls.MetroButton();
            this.mergeSortBtn = new MetroFramework.Controls.MetroButton();
            this.Verticies_Tb = new MetroFramework.Controls.MetroTextBox();
            this.V_num_insert = new MetroFramework.Controls.MetroButton();
            this.Graph_tb = new MetroFramework.Controls.MetroTextBox();
            this.Graph_insert = new MetroFramework.Controls.MetroButton();
            this.Prims_Algo_Btn = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // SortBTN
            // 
            this.SortBTN.Location = new System.Drawing.Point(201, 384);
            this.SortBTN.Name = "SortBTN";
            this.SortBTN.Size = new System.Drawing.Size(93, 32);
            this.SortBTN.TabIndex = 0;
            this.SortBTN.Text = "insertion Sort";
            this.SortBTN.UseSelectable = true;
            this.SortBTN.Click += new System.EventHandler(this.SortBTN_Click);
            // 
            // arrTb
            // 
            // 
            // 
            // 
            this.arrTb.CustomButton.Image = null;
            this.arrTb.CustomButton.Location = new System.Drawing.Point(256, 1);
            this.arrTb.CustomButton.Name = "";
            this.arrTb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.arrTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.arrTb.CustomButton.TabIndex = 1;
            this.arrTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.arrTb.CustomButton.UseSelectable = true;
            this.arrTb.CustomButton.Visible = false;
            this.arrTb.Lines = new string[0];
            this.arrTb.Location = new System.Drawing.Point(94, 158);
            this.arrTb.MaxLength = 32767;
            this.arrTb.Name = "arrTb";
            this.arrTb.PasswordChar = '\0';
            this.arrTb.PromptText = "Insert your array Items";
            this.arrTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.arrTb.SelectedText = "";
            this.arrTb.SelectionLength = 0;
            this.arrTb.SelectionStart = 0;
            this.arrTb.ShortcutsEnabled = true;
            this.arrTb.Size = new System.Drawing.Size(278, 23);
            this.arrTb.TabIndex = 3;
            this.arrTb.UseSelectable = true;
            this.arrTb.WaterMark = "Insert your array Items";
            this.arrTb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.arrTb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // insertArr
            // 
            this.insertArr.Location = new System.Drawing.Point(378, 158);
            this.insertArr.Name = "insertArr";
            this.insertArr.Size = new System.Drawing.Size(93, 23);
            this.insertArr.TabIndex = 4;
            this.insertArr.Text = "Insert";
            this.insertArr.UseSelectable = true;
            this.insertArr.Click += new System.EventHandler(this.insertArr_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(649, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "array";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // arraySize
            // 
            // 
            // 
            // 
            this.arraySize.CustomButton.Image = null;
            this.arraySize.CustomButton.Location = new System.Drawing.Point(256, 1);
            this.arraySize.CustomButton.Name = "";
            this.arraySize.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.arraySize.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.arraySize.CustomButton.TabIndex = 1;
            this.arraySize.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.arraySize.CustomButton.UseSelectable = true;
            this.arraySize.CustomButton.Visible = false;
            this.arraySize.Lines = new string[0];
            this.arraySize.Location = new System.Drawing.Point(94, 120);
            this.arraySize.MaxLength = 32767;
            this.arraySize.Name = "arraySize";
            this.arraySize.PasswordChar = '\0';
            this.arraySize.PromptText = "Insert your array size";
            this.arraySize.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.arraySize.SelectedText = "";
            this.arraySize.SelectionLength = 0;
            this.arraySize.SelectionStart = 0;
            this.arraySize.ShortcutsEnabled = true;
            this.arraySize.Size = new System.Drawing.Size(278, 23);
            this.arraySize.TabIndex = 6;
            this.arraySize.UseSelectable = true;
            this.arraySize.WaterMark = "Insert your array size";
            this.arraySize.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.arraySize.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // insertArraySize
            // 
            this.insertArraySize.Location = new System.Drawing.Point(378, 120);
            this.insertArraySize.Name = "insertArraySize";
            this.insertArraySize.Size = new System.Drawing.Size(93, 23);
            this.insertArraySize.TabIndex = 7;
            this.insertArraySize.Text = "Insert size";
            this.insertArraySize.UseSelectable = true;
            this.insertArraySize.Click += new System.EventHandler(this.insertArraySize_Click);
            // 
            // mergeSortBtn
            // 
            this.mergeSortBtn.Location = new System.Drawing.Point(300, 384);
            this.mergeSortBtn.Name = "mergeSortBtn";
            this.mergeSortBtn.Size = new System.Drawing.Size(93, 32);
            this.mergeSortBtn.TabIndex = 8;
            this.mergeSortBtn.Text = "merge Sort";
            this.mergeSortBtn.UseSelectable = true;
            this.mergeSortBtn.Click += new System.EventHandler(this.mergeSortBtn_Click);
            // 
            // Verticies_Tb
            // 
            // 
            // 
            // 
            this.Verticies_Tb.CustomButton.Image = null;
            this.Verticies_Tb.CustomButton.Location = new System.Drawing.Point(256, 1);
            this.Verticies_Tb.CustomButton.Name = "";
            this.Verticies_Tb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Verticies_Tb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Verticies_Tb.CustomButton.TabIndex = 1;
            this.Verticies_Tb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Verticies_Tb.CustomButton.UseSelectable = true;
            this.Verticies_Tb.CustomButton.Visible = false;
            this.Verticies_Tb.Lines = new string[0];
            this.Verticies_Tb.Location = new System.Drawing.Point(94, 197);
            this.Verticies_Tb.MaxLength = 32767;
            this.Verticies_Tb.Name = "Verticies_Tb";
            this.Verticies_Tb.PasswordChar = '\0';
            this.Verticies_Tb.PromptText = "Number of vertices in the graph";
            this.Verticies_Tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Verticies_Tb.SelectedText = "";
            this.Verticies_Tb.SelectionLength = 0;
            this.Verticies_Tb.SelectionStart = 0;
            this.Verticies_Tb.ShortcutsEnabled = true;
            this.Verticies_Tb.Size = new System.Drawing.Size(278, 23);
            this.Verticies_Tb.TabIndex = 9;
            this.Verticies_Tb.UseSelectable = true;
            this.Verticies_Tb.WaterMark = "Number of vertices in the graph";
            this.Verticies_Tb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Verticies_Tb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // V_num_insert
            // 
            this.V_num_insert.Location = new System.Drawing.Point(378, 197);
            this.V_num_insert.Name = "V_num_insert";
            this.V_num_insert.Size = new System.Drawing.Size(93, 23);
            this.V_num_insert.TabIndex = 10;
            this.V_num_insert.Text = "Insert";
            this.V_num_insert.UseSelectable = true;
            this.V_num_insert.Click += new System.EventHandler(this.V_num_insert_Click);
            // 
            // Graph_tb
            // 
            // 
            // 
            // 
            this.Graph_tb.CustomButton.Image = null;
            this.Graph_tb.CustomButton.Location = new System.Drawing.Point(216, 2);
            this.Graph_tb.CustomButton.Name = "";
            this.Graph_tb.CustomButton.Size = new System.Drawing.Size(59, 59);
            this.Graph_tb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Graph_tb.CustomButton.TabIndex = 1;
            this.Graph_tb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Graph_tb.CustomButton.UseSelectable = true;
            this.Graph_tb.CustomButton.Visible = false;
            this.Graph_tb.Lines = new string[0];
            this.Graph_tb.Location = new System.Drawing.Point(94, 253);
            this.Graph_tb.MaxLength = 32767;
            this.Graph_tb.Multiline = true;
            this.Graph_tb.Name = "Graph_tb";
            this.Graph_tb.PasswordChar = '\0';
            this.Graph_tb.PromptText = "graph points";
            this.Graph_tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Graph_tb.SelectedText = "";
            this.Graph_tb.SelectionLength = 0;
            this.Graph_tb.SelectionStart = 0;
            this.Graph_tb.ShortcutsEnabled = true;
            this.Graph_tb.Size = new System.Drawing.Size(278, 64);
            this.Graph_tb.TabIndex = 11;
            this.Graph_tb.UseSelectable = true;
            this.Graph_tb.WaterMark = "graph points";
            this.Graph_tb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Graph_tb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Graph_insert
            // 
            this.Graph_insert.Location = new System.Drawing.Point(378, 253);
            this.Graph_insert.Name = "Graph_insert";
            this.Graph_insert.Size = new System.Drawing.Size(93, 23);
            this.Graph_insert.TabIndex = 12;
            this.Graph_insert.Text = "Insert";
            this.Graph_insert.UseSelectable = true;
            this.Graph_insert.Click += new System.EventHandler(this.Graph_insert_Click);
            // 
            // Prims_Algo_Btn
            // 
            this.Prims_Algo_Btn.Location = new System.Drawing.Point(102, 384);
            this.Prims_Algo_Btn.Name = "Prims_Algo_Btn";
            this.Prims_Algo_Btn.Size = new System.Drawing.Size(93, 32);
            this.Prims_Algo_Btn.TabIndex = 13;
            this.Prims_Algo_Btn.Text = "Prims Algo";
            this.Prims_Algo_Btn.UseSelectable = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Prims_Algo_Btn);
            this.Controls.Add(this.Graph_insert);
            this.Controls.Add(this.Graph_tb);
            this.Controls.Add(this.V_num_insert);
            this.Controls.Add(this.Verticies_Tb);
            this.Controls.Add(this.mergeSortBtn);
            this.Controls.Add(this.insertArraySize);
            this.Controls.Add(this.arraySize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.insertArr);
            this.Controls.Add(this.arrTb);
            this.Controls.Add(this.SortBTN);
            this.Name = "Form1";
            this.Text = "Algorithms";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton SortBTN;
        private MetroFramework.Controls.MetroTextBox arrTb;
        private MetroFramework.Controls.MetroButton insertArr;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox arraySize;
        private MetroFramework.Controls.MetroButton insertArraySize;
        private MetroFramework.Controls.MetroButton mergeSortBtn;
        public MetroFramework.Controls.MetroTextBox Verticies_Tb;
        public MetroFramework.Controls.MetroButton V_num_insert;
        public MetroFramework.Controls.MetroTextBox Graph_tb;
        public MetroFramework.Controls.MetroButton Graph_insert;
        private MetroFramework.Controls.MetroButton Prims_Algo_Btn;
    }
}

