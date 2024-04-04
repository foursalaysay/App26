using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App26
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();


            passUsage.Text = Application.Current.Properties["passRadio"].ToString();
            passed1.Text = Application.Current.Properties["passCheck1"].ToString();
            passed2.Text = Application.Current.Properties["passCheck2"].ToString();
            passed3.Text = Application.Current.Properties["passCheck3"].ToString();
            passed4.Text = Application.Current.Properties["passDrop"].ToString();
            passed5.Text = Application.Current.Properties["passTotal"].ToString();


        }
    }
}