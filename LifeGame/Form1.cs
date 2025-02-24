namespace LifeGame
{
    public partial class Form1 : Form
    {
        private const int WIDTH = 50;
        private const int HEIGHT = 50;

        private int[,] field = new int[HEIGHT, WIDTH];

        public Form1()
        {
            InitializeComponent();

            ClearField(field);

            PresetField(field);

            pictureBox1.Refresh();
        }

        private void ClearField(int[,] f)
        {
            for (int i = 0; i < HEIGHT; i++)
            {
                for (int j = 0; j < WIDTH; j++)
                {
                    f[i, j] = 0;
                }
            }
        }

        private void PresetField(int[,] f)
        {
            // === 固定物体 ===

            // ブロック
            f[5, 9] = 1;
            f[6, 9] = 1;
            f[5, 10] = 1;
            f[6, 10] = 1;

            // 蜂の巣
            f[5, 14] = 1;
            f[4, 15] = 1;
            f[4, 16] = 1;
            f[6, 15] = 1;
            f[6, 16] = 1;
            f[5, 17] = 1;

            // ボート
            f[5, 21] = 1;
            f[5, 22] = 1;
            f[6, 21] = 1;
            f[7, 22] = 1;
            f[6, 23] = 1;

            // 船
            f[5, 27] = 1;
            f[5, 28] = 1;
            f[6, 28] = 1;
            f[7, 27] = 1;
            f[7, 26] = 1;
            f[6, 26] = 1;

            // 池
            f[5, 32] = 1;
            f[5, 33] = 1;
            f[6, 34] = 1;
            f[7, 34] = 1;
            f[8, 33] = 1;
            f[8, 32] = 1;
            f[7, 31] = 1;
            f[6, 31] = 1;

            // === 振動子 ===

            // ブリンカー
            f[10, 10] = 1;
            f[11, 10] = 1;
            f[12, 10] = 1;

            // ヒキガエル
            f[10, 15] = 1;
            f[11, 15] = 1;
            f[12, 15] = 1;
            f[11, 16] = 1;
            f[12, 16] = 1;
            f[13, 16] = 1;

            // ビーコン
            f[10, 20] = 1;
            f[10, 21] = 1;
            f[11, 20] = 1;
            f[11, 21] = 1;
            f[12, 22] = 1;
            f[12, 23] = 1;
            f[13, 22] = 1;
            f[13, 23] = 1;

            // 時計
            f[11, 27] = 1;
            f[11, 28] = 1;
            f[10, 29] = 1;
            f[13, 28] = 1;
            f[12, 29] = 1;
            f[12, 30] = 1;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.Black);

            for (int i = 0; i < HEIGHT; i++)
            {
                for (int j = 0; j < WIDTH; j++)
                {
                    if (field[i, j] == 1)
                    {
                        e.Graphics.FillRectangle(Brushes.White, j * 8, i * 8, 8, 8);
                    }
                }
            }
        }

        private void timNextGeneration_Tick(object sender, EventArgs e)
        {
            DoNextGeneration();
        }

        private void DoNextGeneration()
        {
            int[,] field2 = new int[HEIGHT, WIDTH];
            ClearField(field2);

            for (int i = 0; i < HEIGHT; i++)
            {
                for (int j = 0; j < WIDTH; j++)
                {
                    int count = CountNeighbor(i, j);
                    if (field[i, j] == 0 && count == 3
                        || field[i, j] == 1 && count >= 2 && count <= 3) field2[i, j] = 1;
                    else field2[i, j] = 0;
                }
            }

            for (int i = 0; i < HEIGHT; i++)
            {
                for (int j = 0; j < WIDTH; j++)
                {
                    field[i, j] = field2[i, j];
                }
            }

            pictureBox1.Refresh();
        }

        private int CountNeighbor(int i, int j)
        {
            int count = 0;

            for (int x = -1; x <= 1; x++)
            {
                for (int y = -1; y <= 1; y++)
                {
                    if (x == 0 && y == 0) continue;
                    int x1 = j + x;
                    int y1 = i + y;
                    if (y1 >= 0 && y1 < HEIGHT && x1 >= 0 && x1 < WIDTH && field[y1, x1] > 0) count++;
                }
            }

            return count;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timNextGeneration.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timNextGeneration.Stop();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearField(field);
            pictureBox1.Refresh();
        }

        private void btnPreset01_Click(object sender, EventArgs e)
        {
            ClearField(field);
            PresetField(field);
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int i = (int)(e.Y / 8.0);
            int j = (int)(e.X / 8.0);
            field[i, j] = 1 - field[i, j];
            pictureBox1.Invalidate();
        }

        private void btnPreset02_Click(object sender, EventArgs e)
        {
            PresetField2(field);
            pictureBox1.Refresh();
        }

        private void PresetField2(int[,] f)
        {
            ClearField(f);

            int x = 10;
            int y = 1;
            long[] data = { 0b001, 0b101, 0b011 };
            SetField(f, x, y, data);

            x = 10;
            y = 12;
            data = new long[] { 0b10010, 0b00001, 0b10001, 0b01111 };
            SetField(f, x, y, data);

            x = 10;
            y = 20;
            data = new long[] { 0b000110, 0b111011, 0b111110, 0b011100 };
            SetField(f, x, y, data);

            x = 10;
            y = 30;
            data = new long[] { 0b0000110, 0b1111011, 0b1111110, 0b0111100 };
            SetField(f, x, y, data);
        }

        private void SetField(int[,] f, int x, int y, long[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                int j = 0;
                long a = data[i];
                while (a > 0)
                {
                    f[y + i, x - j] = (int)(a & 1);
                    a >>= 1;
                    j++;
                }
            }
        }

        private void btnPreset03_Click(object sender, EventArgs e)
        {
            PresetField3(field);
            pictureBox1.Refresh();
        }

        private void PresetField3(int[,] f)
        {
            ClearField(f);

            int x = 40;
            int y = 1;
            long[] data = {
                0B0000000000000000000000000100000000000,
                0B0000000000000000000000010100000000000,
                0B0000000000000110000001100000000000011,
                0B0000000000001000100001100000000000011,
                0B0110000000010000010001100000000000000,
                0B0110000000010001011000010100000000000,
                0B0000000000010000010000000100000000000,
                0B0000000000001000100000000000000000000,
                0B0000000000000110000000000000000000000,
            };
            SetField(f, x, y, data);
        }

        private void btnPreset04_Click(object sender, EventArgs e)
        {
            PresetField4(field);
            pictureBox1.Refresh();
        }

        private void PresetField4(int[,] f)
        {
            ClearField(f);

            int x = 35;
            int y = 20;
            long[] data = {
                0B0011100111101111010001,
                0B0100000100001000001010,
                0B0101110111001110000100,
                0B0100010100001000001010,
                0B0011100111101111010001,
            };
            SetField(f, x, y, data);
        }
    }
}