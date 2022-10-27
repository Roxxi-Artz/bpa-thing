using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace BPA_State_2022
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            #region Sample Read/Write from text file.
            string[] question_list = System.IO.File.ReadAllLines(@"C:\Users\poynter_caleb\source\repos\BPA_State_2022\BPA_State_2022\quizquestion.txt");

            MessageBox.Show(question_list[2]);

            foreach(string line in question_list)
            {
                Trace.WriteLine(line);
            }
            
            #endregion
        }
    }
}
