namespace AnotherOne1
{
    public partial class Form1 : Form
    {
        private July july;
        public Form1()
        {
            july = new July();
            InitializeComponent();
        }

       

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int age = int.Parse(txtAge.Text);
            int height = int.Parse(txtHeight.Text);
            double[] times = new double[] {
            double.Parse(txtTime1.Text),
            double.Parse(txtTime2.Text),
            double.Parse(txtTime3.Text) };

            Horse horse = new Horse(name, age, height, times);
            july.AddHorse(horse);
            //DisplayRoster();

        }

        private void BtnPredict_Click(object sender, EventArgs e)
        {
            Horse favourite = july.Favourite();
            MessageBox.Show($"Favourite Horse: {favourite.Name} with average time {favourite.AverageTime()}");
        }
    }

    
}
