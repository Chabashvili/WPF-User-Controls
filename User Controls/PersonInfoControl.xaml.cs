using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace User_Controls
{
    public partial class PersonInfoControl : UserControl
    {

        public static readonly DependencyProperty PersonNameProperty = DependencyProperty.Register(nameof(PersonName), typeof(string),
            typeof(PersonInfoControl));

        public static readonly DependencyProperty PersonAgeProperty = DependencyProperty.Register(nameof(PersonAge), typeof(int),
            typeof(PersonInfoControl));

        public static readonly DependencyProperty PersonCountryProperty = DependencyProperty.Register(nameof(PersonCountry), typeof(string),
            typeof(PersonInfoControl));

        public string PersonName
        {
            get { return (string)GetValue(PersonAgeProperty); }
            set { SetValue(PersonNameProperty, value); }
        }

        public string PersonCountry
        {
            get { return (string)(GetValue(PersonCountryProperty)); }
            set { SetValue(PersonCountryProperty, value); }
        }

        public int PersonAge
        {
            get { return (int)GetValue(PersonAgeProperty); }
            set { SetValue(PersonAgeProperty, value);}
        }
        public PersonInfoControl()
        {
            InitializeComponent();
            DataContext = this;
        }
    }
}
