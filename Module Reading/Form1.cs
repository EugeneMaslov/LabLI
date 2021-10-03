using System;
using System.Drawing;
using System.Windows.Forms;

namespace Module_Reading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int k = -16, l = 0;

        Bitmap finalImage;
        Graphics grafic;

        Bitmap graf = new Bitmap(@"small_icons\0.bmp");
        Bitmap weel = new Bitmap(@"small_icons\1.bmp");
        Bitmap start = new Bitmap(@"small_icons\2.bmp");
        Bitmap end = new Bitmap(@"small_icons\3.bmp");

        Bitmap graf1 = new Bitmap(@"big_icons\0.bmp");
        Bitmap weel1 = new Bitmap(@"big_icons\1.bmp");
        Bitmap start1 = new Bitmap(@"big_icons\2.bmp");
        Bitmap end1 = new Bitmap(@"big_icons\3.bmp");
        Bitmap road1 = new Bitmap(@"big_icons\road.bmp");
        Bitmap roadafter1 = new Bitmap(@"big_icons\road_after.bmp");

        int[,] labirint;

        int startX;
        int startY;
        int targetX;
        int targetY;

        public int n, m;
        public bool add = true;

        bool labirint_out_flag;
        bool labirint_in_flag;
        bool indeeg;

        private void ToStandart()
        {
            pictureBox1.Height = 346;
            pictureBox1.Width = 743;
            ActiveForm.Width = 816;
            ActiveForm.Height = 489;
            label2.Show();
            label4.Show();
        }
        private void download_Click(object sender, EventArgs e)
        {
            labirint_out_flag = false;
            labirint_in_flag = false;
            indeeg = false;
            string waiter = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                waiter = openFileDialog1.FileName;
            }
            if (openFileDialog1.FileName == String.Empty || openFileDialog1.FileName == "openFileDialog1") return;
            label2.Hide();
            label4.Hide();
            pictureBox1.Image = null;
            try
            {
                Bitmap general_image = new Bitmap(waiter);
                waiter = null;
                pictureBox1.Width = general_image.Width * 16;
                pictureBox1.Height = general_image.Height * 16;
                finalImage = new Bitmap(general_image.Width * 16, general_image.Height * 16);
                n = general_image.Width;
                m = general_image.Height;
                grafic = Graphics.FromImage(finalImage);
                int result;
                labirint = new int[general_image.Width, general_image.Height];
                for (int y = 0; y < general_image.Height; y++)
                {
                    for (int x = 0; x < general_image.Width; x++)
                    {
                        result = CompareImage(general_image, x, y);
                        if (result != -3) labirint[x, y] = result;
                        else
                        {
                            indeeg = true;
                        }
                    }
                }
                k = -16;
                l = 0;
                if (indeeg == false && labirint_in_flag == true && labirint_out_flag == true)
                {
                    ActiveForm.Width = general_image.Width * 16 + 350;
                    ActiveForm.Height = general_image.Height * 16 + 200;
                    pictureBox1.Image = finalImage;
                    finalImage = null;
                }
                else
                {
                    ToStandart();
                    MessageBox.Show("\nЛабиринт имеет более одного входа/выхода или не имеет их вообще!",
"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (System.IO.FileNotFoundException situation)
            {
                ToStandart();

                MessageBox.Show(situation.Message + "\nНет такого файла",
"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception situation)
            { // отчет о других ошибках
                MessageBox.Show(situation.Message,
                     "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ToStandart();
            }
        }
        private int CompareImage(Bitmap Image, int i, int j)
        {
            if (k != Image.Width * 16 && k + 16 < Image.Width * 16)
            {
                k += 16;
            }
            else
            {
                k = 0;
                l += 16;
            }
            if (Image.GetPixel(i, j) == graf.GetPixel(0, 0))
            {
                grafic.DrawImage(graf1, k, l);
                return -2;
            }
            else if (Image.GetPixel(i, j) == weel.GetPixel(0, 0))
            {
                grafic.DrawImage(weel1, k, l);
                return -1;
            }
            else if (Image.GetPixel(i, j) == start.GetPixel(0, 0))
            {
                grafic.DrawImage(start1, k, l);
                startX = i;
                startY = j;
                if (labirint_in_flag == false)
                {
                    labirint_in_flag = true;
                }
                else
                {
                    return -3;
                }
                return -2;
            }
            else if (Image.GetPixel(i, j) == end.GetPixel(0, 0))
            {
                grafic.DrawImage(end1, k, l);
                targetX = i;
                targetY = j;
                if (labirint_out_flag == false)
                {
                    labirint_out_flag = true;
                }
                else
                {
                    return -3;
                }
                return -2;
            }
            else
            {
                return -3;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данная программа предназначена для вычисления пути в загружаемом пользователем лабиринте\n\n\t\tРУКОВОДСТВО\n" +
                "\nРуководство по загрузке файла:\nИспользуйте точечный bmp файл исходя образцу: " + "\nКаждый пиксель - отдельная клетка, " +
                "\nОт цвета пикселя зависит назначение: " + "\nКрасный(#ed1c24) пиксель отвечает за вход, зеленый(#22b14c) за выход, могут " +
                "быть представлены всего один раз " + "\nСерым(#7f7f7f) цветом отмечается " + "\nпроходимая клетка, чёрным(#000000) - непроходимая.",
"Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //
        }


        private void Dothis_Click(object sender, EventArgs e)
        {
            LabirintClass lab = new LabirintClass(labirint);
            if (pictureBox1.Image != null)
                if (lab.GetLabirint(startX, startY, targetX, targetY, n, m))
                {
                    pictureBox1.Image = null;
                    int[,] final_road = lab.GetData();
                    int[] px = lab.GetPX();
                    int[] py = lab.GetPY();
                    finalImage = new Bitmap(n * 16, m * 16);
                    grafic = Graphics.FromImage(finalImage);
                    Font drawFont = new Font("Arial", 6);
                    Font drawFont2 = new Font("Arial", 8);
                    SolidBrush drawBrush = new SolidBrush(Color.Black);
                    StringFormat drawFormat = new StringFormat();
                    drawFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;
                    for (int y = 0; y < m; y++)
                    {
                        for (int x = 0; x < n; x++)
                        {
                            if (k != n * 16 && k + 16 < n * 16)
                            {
                                k += 16;
                            }
                            else
                            {
                                k = 0;
                                l += 16;
                            }

                            if (final_road[x, y] == -2)
                            {
                                grafic.DrawImage(graf1, k, l);
                            }
                            else if (final_road[x, y] == -1)
                            {
                                grafic.DrawImage(weel1, k, l);
                            }
                            else
                            {
                                grafic.DrawImage(road1, k, l);
                                if (final_road[x,y] < 100)
                                {
                                    grafic.DrawString(final_road[x, y].ToString(), drawFont2, drawBrush, k + 16, l, drawFormat);
                                }
                                else
                                {
                                    grafic.DrawString(final_road[x, y].ToString(), drawFont, drawBrush, k + 16, l, drawFormat);
                                }
                            }


                            if (x == startX && y == startY)
                            {
                                grafic.DrawImage(start1, k, l);
                            }
                            else if (x == targetX && y == targetY)
                            {
                                grafic.DrawImage(end1, k, l);
                            }
                        }
                    }
                    for (int i = 0; i < px.Length; i++)
                    {
                        if (px[i] != 0 && py[i] != 0 && final_road[px[i], py[i]] != lab.GetLen() && final_road[px[i], py[i]] != 0)
                        {
                            grafic.DrawImage(roadafter1, px[i] * 16, py[i] * 16);
                        }
                        if (final_road[px[i], py[i]] < 100)
                        {
                            grafic.DrawString(final_road[px[i], py[i]].ToString(), drawFont2, drawBrush, px[i] * 16 + 16, py[i] * 16, drawFormat);
                        }
                        else
                        {
                            grafic.DrawString(final_road[px[i], py[i]].ToString(), drawFont, drawBrush, px[i] * 16 + 16, py[i] * 16, drawFormat);
                        }
                        
                    }
                    pictureBox1.Image = finalImage;
                    k = -16;
                    l = 0;
                }
                else
                {
                    MessageBox.Show("\nПуть не найден либо рабочее поле пустое!",
    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
        }

    }

    public partial class LabirintClass
    {
        int[,] labirint { get; set; }
        int[,] work_labirint { get; set; }

        int[] px { get; set; }
        int[] py { get; set; }

        int len { get; set; }

        public LabirintClass(int[,] labirint)
        {
            this.labirint = labirint;
        }

        public bool GetLabirint(int ax, int ay, int bx, int by, int n, int m)
        {
            int W = n;         // ширина рабочего поля
            int H = m;         // высота рабочего поля
            const int WALL = -1;         // непроходимая ячейка
            const int BLANK = -2;         // свободная непомеченная ячейка

            int[] px = new int[W * H];
            int[] py = new int[W * H];      // координаты ячеек, входящих  путь
            int[,] grid = labirint;

            int[] dx = new int[4] { 1, 0, -1, 0 };   // смещения, соответствующие соседям ячейки
            int[] dy = new int[4] { 0, 1, 0, -1 };   // справа, снизу, слева и сверху
            int d, x, y, k;
            bool stop;

            if (grid[ax, ay] == WALL || grid[bx, by] == WALL) return false;  // ячейка (ax, ay) или (bx, by) - стена

            // распространение волны
            d = 0;
            grid[ax, ay] = 0;            // стартовая ячейка помечена 0
            do
            {
                stop = true;               // предполагаем, что все свободные клетки уже помечены
                for (y = 0; y < H; ++y)
                    for (x = 0; x < W; ++x)
                        if (grid[x, y] == d)                         // ячейка (x, y) помечена числом d
                        {
                            for (k = 0; k < 4; ++k)                    // проходим по всем непомеченным соседям
                            {
                                int iy = y + dy[k], ix = x + dx[k];
                                if (iy >= 0 && iy < H && ix >= 0 && ix < W &&
                                     grid[ix, iy] == BLANK)
                                {
                                    stop = false;              // найдены непомеченные клетки
                                    grid[ix, iy] = d + 1;      // распространяем волну
                                }
                            }
                        }
                d++;
            } while (!stop && grid[bx, by] == BLANK);

            if (grid[bx, by] == BLANK) return false;  // путь не найден

            // восстановление пути
            len = grid[bx, by];            // длина кратчайшего пути из (ax, ay) в (bx, by)
            x = bx;
            y = by;
            d = len;
            while (d > 0)
            {
                px[d] = x;
                py[d] = y;                   // записываем ячейку (x, y) в путь
                d--;
                for (k = 0; k < 4; ++k)
                {
                    int iy = y + dy[k], ix = x + dx[k];
                    if (iy >= 0 && iy < H && ix >= 0 && ix < W &&
                         grid[ix, iy] == d)
                    {
                        x = x + dx[k];
                        y = y + dy[k];           // переходим в ячейку, которая на 1 ближе к старту
                        break;
                    }
                }
            }
            px[0] = ax;
            py[0] = ay;                    // теперь px[0..len] и py[0..len] - координаты ячеек пути
            this.px = px;
            this.py = py;
            work_labirint = grid;
            return true;
        }

        public int[,] GetData()
        {
            return work_labirint;
        }
        public int[] GetPX()
        {
            return px;
        }
        public int[] GetPY()
        {
            return py;
        }
        public int GetLen()
        {
            return len;
        }

    }
}
