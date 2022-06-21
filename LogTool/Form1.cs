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

        private void Form1_Load(object sender, EventArgs e)
        {
            Create_gvLog();
        }

        private void Create_gvLog()
        {
            DataGridViewTextBoxColumn colDate = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn colType = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn colLog = new DataGridViewTextBoxColumn();

            // カラム名
            colDate.HeaderText = "日付";
            colType.HeaderText = "種別";
            colLog.HeaderText = "ログ";

            // カラム幅
            colDate.Width = 120;
            colType.Width = 120;
            colLog.Width = 720;

            // グリッドビューにカラムを追加
            gvLog.Columns.Add(colDate);
            gvLog.Columns.Add(colType);
            gvLog.Columns.Add(colLog);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //OpenFileDialogを生成
            OpenFileDialog op = new OpenFileDialog();

            //オープンファイルダイアログを表示する
            DialogResult result = op.ShowDialog();
            op.Filter = "Text File(*.txt;*.log)|*.txt;*.log"; //拡張子.logと.txt形式のファイルのみ許容する

            if (result == DialogResult.OK)
            {
                //「開く」ボタンが選択された時の処理
                string fileName = op.FileName;  //選択されたファイルのパスが取得できる
                StreamReader sr = new StreamReader(fileName, System.Text.Encoding.Default);//StreamReaderクラスでファイルの読み込み
                string str = sr.ReadToEnd();//ファイルを最後まで読み込むメソッド
                sr.Close();
            }
            //else if (result == DialogResult.Cancel)
            //{
            //    //「キャンセル」ボタンまたは「×」ボタンが選択された時の処理
            //}
        }

        
    }
}
