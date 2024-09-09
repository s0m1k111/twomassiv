namespace twomassiv
{
    public partial class Form1 : Form
    {

        private Button[] cell;
        public Form1()
        {
            InitializeComponent();
            cell = new[]
            {
                button1,
                button2,
                button3,
                button4,
                button5,
                button6,
                button7,
                button8,
                button9,
                button10,
                button11,
                button12,
                button13,
                button14,
                button15,
                button16
            };
        }
        private int[,] arr = new int[4, 4]
        {
            {1,2,3,4 },
            {5,6,7,8 },
            {9,10,11,12,},
            {13,14,15,16},
        };

        private void button17_Click(object sender, EventArgs e)
        {
            show();
        }
        private void show()
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    cell[i * 4 + j].Text = arr[i, j].ToString();
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    int iRnd1 = new Random().Next(arr.GetLength(0));
                    int iRnd2 = new Random().Next(arr.GetLength(1));
                    int iRnd3 = new Random().Next(arr.GetLength(0));
                    int iRnd4 = new Random().Next(arr.GetLength(1));
                    (arr[iRnd1, iRnd2], arr[iRnd3, iRnd4]) = (arr[iRnd3, iRnd4], arr[iRnd1, iRnd2]);

                    show();
                }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            for(int  k = 0;k<arr.Length;k++)
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (j < arr.GetLength(1) - 1)
                    {
                        if (arr[i, j] > arr[i, j + 1])
                            (arr[i, j], arr[i, j+1]) = (arr[i, j+1], arr[i, j]);
                        }
                    else
                    {
                        if (i < arr.GetLength(0) - 1)
                            if (arr[i, j] > arr[i + 1, 0])
                                (arr[i,j], arr[i + 1, 0]) = (arr[i+1, 0], arr[i, j]);
                    }
                            
                }
            }
            show();
        }
    }
}

/*
 *          for (int i = 0; i < arr.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < arr.GetLength(1) - 1; j++)
                {
                    if (arr[i, j] > arr[i, j + 1])
                    {
                        (arr[i, j], arr[i, j + 1]) = (arr[i, j + 1], arr[i, j]);
                    }
                }
            }
            for (int j = 0; j < arr.GetLength(1) - 1; j++)
            {
                for (int i = 0; i < arr.GetLength(0) - 1; i++)
                {
                    if (arr[i, j] > arr[i + 1, j])
                    {
                        (arr[i, j], arr[i + 1, j]) = (arr[i + 1, j], arr[i, j]);
                    }
                }
            }
 */
