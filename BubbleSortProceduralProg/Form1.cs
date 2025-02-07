namespace BubbleSortProceduralProg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int[] bubbleSort(int[] arr)
        {
            int n = arr.Length;    
            for (int i = 0; i < n - 1; i++)
            {    
                for (int j = 0; j < n - i - 1; j++)
                {   
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }

            }
            return arr;
        }        

        private void button1_Click(object sender, EventArgs e)
        {
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
            int[] sortNumbers = bubbleSort(arr);
            listBoxResults.DataSource = sortNumbers;
        }
    }
}
