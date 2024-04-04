using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App26
{
    public partial class MainPage : ContentPage
    {
        public double watts;
        public double totalcost;

        public String selectedValue;

        public double refWatt;
        public double washWatt;
        public double airWatt;

        public String dropValue;

        public double refPrice;
        public double washPrice;
        public double airPrice;

        public double elecRate;

        public double refFinal;
        public double washFinal;
        public double airFinal;

        public double refHour;
        public double washHour;
        public double airHour;

        public String check1String;
        public String check2String;
        public String check3String;



        public MainPage()
        {
            InitializeComponent();

            radio1.CheckedChanged += RadioButton_CheckedChanged;
            radio2.CheckedChanged += RadioButton_CheckedChanged;


        }
        private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            RadioButton selectedRadioButton = (RadioButton)sender;



            if (e.Value)
            {
                selectedValue = selectedRadioButton.Content.ToString();

                if (selectedValue == "Monthly Usage")
                {
                    selectedValue = "Monthly Usage";
                    refHour = 672;
                    washHour = 12;
                    airHour = 140;

                }
                else if (selectedValue == "Weekly Usage")
                {
                    selectedValue = "Weekly Usage";
                    refHour = 168;
                    washHour = 3;
                    airHour = 35;

                }
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            // FORMULAS
            


            // DISPLAY
            

            //checkbox
            if (check1.IsChecked)
            {

                refWatt = 200;
                refFinal = (200 * refHour) / 1000;
                check1String = "Refrigerator";
                check2String = "";
                check3String = "";

                if (check2.IsChecked)
                {
                    refFinal = (200 * refHour) / 1000;
                    washFinal = (500 * washHour) / 1000;
                    check1String = "Refrigerator";
                    check2String = "Washing Machine";
                    check3String = "";
                    if (check3.IsChecked)
                    {
                        refFinal = (200 * refHour) / 1000;
                        washFinal = (500 * washHour) / 1000;
                        airFinal = (1500 * airHour) / 1000;
                        check1String = "Refrigerator";
                        check2String = "Washing Machine";
                        check3String = "Air Conditioner";
                    }
                }
                
            }


           
           

            if (check2.IsChecked)
            {

                
                
                washFinal = (500 * washHour) / 1000;
                check1String = "";
                check2String = "Washing Machine";
                check3String = "";

                if (check1.IsChecked)
                {
                   
                    washFinal = (500 * washHour) / 1000;
                    refFinal = (200 * refHour) / 1000;
                    check1String = "Refrigerator";
                    check2String = "Washing Machine";
                    check3String = "";
                    if (check3.IsChecked)
                    {
                        refFinal = (200 * refHour) / 1000;
                        washFinal = (500 * washHour) / 1000;
                        airFinal = (1500 * airHour) / 1000;
                        check1String = "Refrigerator";
                        check2String = "Washing Machine";
                        check3String = "Air Conditioner";
                    }
                }
               
            }



            

            if (check3.IsChecked)
            {

                
                airFinal = (1500 * airHour) / 1000;
       
                check3String = "Air Conditioner";
                

                if (check1.IsChecked)
                {
                    refWatt = 200;
                    refFinal = (200 * refHour) / 1000;
                    airFinal = (1500 * airHour) / 1000;
                    check1String = "Refrigerator";
                    check3String = "Air Conditioner";
                    check2String = "";
                    if (check2.IsChecked)
                    {
                        refFinal = (200 * refHour) / 1000;
                        washFinal = (500 * washHour) / 1000;
                        airFinal = (1500 * airHour) / 1000;
                        check1String = "Refrigerator";
                        check2String = "Washing Machine";
                        check3String = "Air Conditioner";

                    }
                }
                
            }



           



            double totalUsage = refFinal + washFinal + airFinal;

            elecRate = double.Parse(dropValue);
            totalcost = totalUsage * elecRate;


            Application.Current.Properties["passRadio"] = selectedValue;
            Application.Current.Properties["passCheck1"] = check1String;
            Application.Current.Properties["passCheck2"] = check2String;
            Application.Current.Properties["passCheck3"] = check3String;
            Application.Current.Properties["passDrop"] = dropValue;
            Application.Current.Properties["passTotal"] = totalcost;
           


            Navigation.PushAsync(new Page1());
        }

        

        private void dropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {
             dropValue = dropdown1.SelectedItem.ToString();
        }
    }
}
