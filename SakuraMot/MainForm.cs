using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SakuraMot
{
    public partial class MainForm : Form
    {
        #region //              プログラムの開始と終了         //
        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //コマンドライン引数があるかどうか調べます
            string[] cmds = Environment.GetCommandLineArgs();

            if (cmds.Length > 1)
            {
                //mot生成します
                CreateMot(cmds[1]);

                this.Close();
                this.Dispose();
            }

        }
        #endregion

        /// <summary>
        /// motファイルを生成します
        /// </summary>
        /// <param name="filename"></param>
        private void CreateMot(string filename)
        {
            //Gr_sakura_fw_rev1データ読み込み
            Gr_sakura_fw_rev1.Setfwrev1();

            string ext = Path.GetExtension(filename).ToLower();
            if (ext != ".mot")
            {
                return;
            }

            string pathname = Path.GetDirectoryName(filename);
            string fname = Path.GetFileNameWithoutExtension(filename);
            fname = string.Concat(pathname, "\\", fname, "_bin.mot");

            List<string> txtData = new List<string>();

            try
            {
                using (StreamWriter sw = new StreamWriter(fname,
                                          false,  // 上書き （ true = 追加 ）
                                          Encoding.ASCII))
                {
                    using (StreamReader sr = new StreamReader(filename, Encoding.ASCII))
                    {
                        //txtData = sr.ReadToEnd();
                        //ストリームの末端まで繰り返す
                        while (sr.Peek() > -1)
                        {
                            //一行読み込む
                            txtData.Add(sr.ReadLine());
                        }
                        sr.Close();
                        sr.Dispose();
                    }

                    for (int i = 0; i < txtData.Count - 1; i++)
                    {
                        sw.WriteLine(txtData[i]);
                    }

                    sw.Write(Gr_sakura_fw_rev1.Fw_rev1);
                    sw.Close();
                    sw.Dispose();
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }


        #region //          ドラッグドロップ        //
        private void lblMotfile_DragDrop(object sender, DragEventArgs e)
        {
            // ドラッグ＆ドロップされたファイル
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            CreateMot(files[0]);
        }

        private void lblMotfile_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            // ドラッグ＆ドロップされたファイル
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            CreateMot(files[0]);
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }
        #endregion
    }
}
