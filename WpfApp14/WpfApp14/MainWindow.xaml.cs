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

namespace WpfApp14
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            using(ApplicationContext db = new ApplicationContext())
            {
                User tom = new User { Name="Tom", Age =23,Surname="qwfqwfqf"/*,Email="gmail.com"*/};
                db.Users.Add(tom);
                db.SaveChanges();
                var users = db.Users.ToList();
                foreach(var user in users) 
                {
                    Box.Text += $"{user.Name} - {user.Age} \n";
                }
            }
        }
    }
}
