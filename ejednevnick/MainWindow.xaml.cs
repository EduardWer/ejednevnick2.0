using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
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


namespace ejednevnick
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            dATE_TRANS.SelectedDate = DateTime.Now;
            
            Serializasial serializasial = new Serializasial();
            var info =  Serializasial.DeSerialization<List<data_pro>>(serializasial.path);

            
            for (int i = 0; i <= info.Count; i++) {
                //var data_string = info[i].DueDate.Date.ToString();
                if (info == null)
                {
                    return;
                }
                
                
            }

        }




        private void sAVE_bUTTON_Click(object sender, RoutedEventArgs e)
        {   
            Serializasial serial =  new Serializasial();
            data_pro data_Pro = new data_pro();
           
            

            List<data_pro> notes = new List<data_pro>();
            data_pro data_Pro1 = new data_pro();
            List<data_pro> data_Pros = Serializasial.DeSerialization<List<data_pro>>(serial.path);

            data_Pro1.Title = title_text.Text;
            data_Pro1.Description = description_text.Text;
            data_Pro1.DueDate = Convert.ToDateTime( dATE_TRANS.SelectedDate);

            data_Pros.Add(data_Pro1);
            
            Serializasial.Serialisation(data: data_Pros, serial.path );

             
            if (Zametka.Text == null)
            {
                Zametka.Text =  "Название   " + data_Pro1.Title + "   Описание  " + data_Pro1.Description+ "   Дата создания  "+ data_Pro1.DueDate;
            }
            else
            {
                Zametka.Text = Zametka.Text +"\n" + "Название   " + data_Pro1.Title + "   Описание  " + data_Pro1.Description + "   Дата создания  " + data_Pro1.DueDate;
            }
            



            

           
            
        }

        private void dELL_bUTTON_Click(object sender, RoutedEventArgs e)
        {

        }

        private void dATE_TRANS_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }
    }
}