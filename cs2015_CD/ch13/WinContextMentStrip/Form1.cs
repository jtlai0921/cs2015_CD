﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinContextMentStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // ===  表單載入時執行
        private void Form1_Load(object sender, EventArgs e)
        {
            // 豐富文字方塊填滿整個表單
            richTextBox1.Dock = DockStyle.Fill;
        }
        // ===  執行功能表的 [檔案/開檔] 指令執行
        private void 開檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 使用try{...}catch{...}來補捉沒有檔案可能發生的例外
            try
            {
                // 將test.rtf檔的內容載入到richTextBox1豐富文字方塊內
                richTextBox1.LoadFile("GOTOP.rtf", RichTextBoxStreamType.RichText);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // ===  執行功能表的 [檔案/存檔] 指令執行
        private void 存檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 將richTextBox1豐富文字方塊內的資料儲存到test.rtf檔
            richTextBox1.SaveFile("GOTOP.rtf", RichTextBoxStreamType.RichText);
        }
        // ===  執行功能表的 [清除] 指令執行
        private void 清除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }
        // ===  執行功能表的 [結束] 指令執行
        private void 結束ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 項目符號ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBullet = !richTextBox1.SelectionBullet;
        }

        private void cboSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 設定選取字型的樣式
            richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily.ToString(), float.Parse(cboSize.Text), richTextBox1.Font.Style);
        }
        //  ===  執行功能表的 [字型色彩] 指令執行
        private void cboFontColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFontColor.Text == "黑")
            {
                richTextBox1.SelectionColor = Color.Black;
            }
            else if (cboFontColor.Text == "紅")
            {
                richTextBox1.SelectionColor = Color.Red;
            }
            else if (cboFontColor.Text == "綠")
            {
                richTextBox1.SelectionColor = Color.Green;
            }
            else if (cboFontColor.Text == "藍")
            {
                richTextBox1.SelectionColor = Color.Blue;
            }
        }
        // === 執行快顯功能表 [複製] 指令
        private void 複製ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }
        // === 執行快顯功能表 [貼上] 指令
        private void 貼上ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }
        // === 執行快顯功能表 [剪下] 指令
        private void 剪下ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }
    }
}
