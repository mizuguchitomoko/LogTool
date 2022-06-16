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

namespace LogTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //OpenFileDialogを生成
            OpenFileDialog op = new OpenFileDialog();

            //オープンファイルダイアログを表示する
            DialogResult result = op.ShowDialog();

            if (result == DialogResult.OK)
            {
                //「開く」ボタンが選択された時の処理
                string fileName = op.FileName;  //こんな感じで選択されたファイルのパスが取得できる
            }
            else if (result == DialogResult.Cancel)
            {
                //「キャンセル」ボタンまたは「×」ボタンが選択された時の処理
            }
        }
    }
}
