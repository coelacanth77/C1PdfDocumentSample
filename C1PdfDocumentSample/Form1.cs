using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C1PdfDocumentSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label1.Text = "「PDFを保存する」をクリックすると\n画像付きのPDFを\n" + System.Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\sample.pdf\nに保存します";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // PDFに文字を表示する
            this.c1PdfDocument1.DrawString("PDF Sample", new Font(FontFamily.GenericSerif, 16), Brushes.Black, PointF.Empty);


            // 画像を表示する
            RectangleF rect = c1PdfDocument1.PageRectangle;
            rect.Inflate(-120, -240);

            this.c1PdfDocument1.DrawImage(pictureBox1.Image, rect);

            // 保存する
            this.c1PdfDocument1.Save(System.Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\sample.pdf");
        }
    }
}
