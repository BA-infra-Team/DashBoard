using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
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
using System.Windows.Shapes;
using static DashBoard.MainWindow;

namespace DashBoard
{
    /// <summary>
    /// TotalFile.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class TotalFile : Window
    {
        public TotalFile()
        {
            InitializeComponent();

            SeriesCollection = new SeriesCollection
            {
               
                new PieSeries
                {
                    Title = "Canceled",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(ChartData.Error_Ratio_By_Job_Status_PieChart_Canceled_Error_Count) },
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Failed",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(ChartData.Error_Ratio_By_Job_Status_PieChart_Failed_Error_Count) },
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "partially Completed",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(ChartData.Error_Ratio_By_Job_Status_PieChart_Partially_Completed_Count) },
                    DataLabels = true
                },

                new PieSeries
                {
                    Title = "Suspend",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(ChartData.Error_Ratio_By_Job_Status_PieChart_Suspended_Error_Count) },
                    DataLabels = true
                }
            };

            SeriesCollection1 = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Completed",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(ChartData.Total_Error_Ratio_PieChart_Total_Completed_Count) },
                    DataLabels = true

                },
                new PieSeries
                {
                    Title = "Canceled",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(ChartData.Total_Error_Ratio_PieChart_Total_Error_Count) },
                    DataLabels = true
                },
               
            };
            DataContext = this;
        }

        public SeriesCollection SeriesCollection { get; set; }
        public SeriesCollection SeriesCollection1 { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> Formatter { get; set; }

    }
    
}
