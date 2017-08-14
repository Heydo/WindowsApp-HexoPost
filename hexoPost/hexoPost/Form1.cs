using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace hexoPost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string file_name = text_fileName.Text;
            string post_name = text_postName.Text;
            string categories = text_catName.Text;
            string tags = text_tagsName.Text;
            string path = filePath.Text;

            // 创建文件
            //可以指定盘符，也可以指定任意文件名，还可以为word等文件
            FileStream fs = new FileStream(path + "/"+ file_name +".md", FileMode.OpenOrCreate, FileAccess.ReadWrite); 
            
            // 创建写入流
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("---");
            sw.WriteLine("title: " + post_name);
            sw.WriteLine("date: " + DateTime.Now.ToString("yyyy-MM-dd ")+ DateTime.Now.ToLongTimeString().ToString());
            sw.WriteLine("categories: ");
            string[] categorie_Arr = categories.Split('，');
            foreach(string c in categorie_Arr)
            {
                sw.WriteLine("- " + c);
            }

            sw.WriteLine("tags: ");
            string[] tags_Arr = tags.Split('，');
            foreach (string t in tags_Arr)
            {
                sw.WriteLine("- " + t);
            }
            sw.WriteLine("---");
            //关闭文件
            sw.Close();
            MessageBox.Show("文件生成完毕！");
            this.Close();

            //Console.WriteLine(categories);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog folder = new System.Windows.Forms.FolderBrowserDialog();

            if (folder.ShowDialog() == DialogResult.OK)
            {
                this.filePath.Text = folder.SelectedPath;
            }

            //OpenFileDialog ofp = new OpenFileDialog();
            //if (ofp.ShowDialog() == DialogResult.OK)
            //{
            //    filePath.Text = ofp.FileName.Replace(ofp.SafeFileName, "");
            //}
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Heydo");
        }
    }
}
