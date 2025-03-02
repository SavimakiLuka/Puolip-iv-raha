using Microsoft.Maui.Controls;

namespace puolipaivaraha
{
    public partial class MainPage : ContentPage
    {
        private int _count = 0;
        string lisattyTunti = "";

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            _count++;
            //CounterLabel.Text = _count.ToString();
            CounterLabel.Text = lisattyTunti;
        }

        private void HoursAdded(object sender, EventArgs e)
        {
            Entry entry = new Entry { Placeholder = "Enter text" };
            lisattyTunti = entry.Text;
            CounterLabel.Text = entry.Text;
        }
    }
}
