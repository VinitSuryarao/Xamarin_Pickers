using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Pickers
{
    public partial class MainPage 
    {
        public MainPage()
        {
            InitializeComponent();
            // Add Dynamic Values to Drop Down
            var countryList = new List<string>();
            countryList.Add("India");
            countryList.Add("US");
            countryList.Add("Germany");
            countryPicker.ItemsSource = countryList;
        }

        private void Submit_Clicked(object sender, EventArgs e)
        {
            try
            {
                var date = datePicker.Date; // Date
                var time = timePicker.Time; // Time
                var city = cityPicker.SelectedItem.ToString(); //Dropdwn With Dard Code Value
                var country = countryPicker.SelectedItem.ToString(); // Dynamic Drop Values
                lblText.Text = string.Format("Date : {0} \n Time : {1} \n City : {2} \n Country : {3}"
                                            , date, time, city, country);
            }
            catch(Exception ex)
            {
                DisplayAlert("Error", ex.Message, "Ok");
            }
            
        }
    }
}
