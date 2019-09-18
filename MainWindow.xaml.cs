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
using NLog;


namespace MuestraLog
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public MainWindow()
        {
            int a = 10;
            InitializeComponent();

            logger.Trace("Hola Mundo {0}", a);
            a = 20;
            logger.Trace("Hola Mundo {0}", a);
            a = 0;
            try
            {
                int b = 10 / a;

            } catch (Exception ex)
            {
                logger.Error("ERROR!! -> {0}", ex.ToString());
            }

        }
    }
}
