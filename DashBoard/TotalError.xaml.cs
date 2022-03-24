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
    /// Piechart.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class TotalError : Window
    {
        
        public TotalError()
        {
           
            InitializeComponent();

            SeriesCollection = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "File Backup",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(ChartData.JobType_PieChart_File_Backup_Count) },
                    DataLabels = true,
                    Fill=System.Windows.Media.Brushes.Red

                },
                new PieSeries
                {
                    Title = "Informix Onbar Backup",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(ChartData.JobType_PieChart_Informix_Onbar_Backup_Count) },
                    DataLabels = true,
                    Fill=System.Windows.Media.Brushes.Orange
                },
                new PieSeries
                {
                    Title = "Mysql Backup",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(ChartData.JobType_PieChart_Mysql_Backup_Count) },
                    DataLabels = true,
                    Fill=System.Windows.Media.Brushes.Yellow
                },
                new PieSeries
                {
                    Title = "Oracle RMAN Backup",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(ChartData.JobType_PieChart_Oracle_RMAN_Backup_Count) },
                    DataLabels = true,
                    Fill=System.Windows.Media.Brushes.Green
                },

                new PieSeries
                {
                    Title = "Physical Backup",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(ChartData.JobType_PieChart_Physical_Backup_Count) },
                    DataLabels = true,
                    Fill=System.Windows.Media.Brushes.Blue
                },

                new PieSeries
                {
                    Title = "VmWare Backup",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(ChartData.JobType_PieChart_Vm_Ware_Backup_Count) },
                    DataLabels = true,
                    Fill=System.Windows.Media.Brushes.Purple
                }
            };

            

            SeriesCollection1 = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Archive Backup",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(ChartData.Backup_Method_Ratio_Pie_Chart_Archive_Backup_Count) },
                    DataLabels = true

                },
                new PieSeries
                {
                    Title = "Differential Backup",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(ChartData.Backup_Method_Ratio_Pie_Chart_Differential_Backup_Count) },
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Dump Backup",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(ChartData.Backup_Method_Ratio_Pie_Chart_Dump_Backup_Count) },
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Full Backup",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(ChartData.Backup_Method_Ratio_Pie_Chart_Full_Backup_Count) },
                    DataLabels = true
                },

                new PieSeries
                {
                    Title = "Increamental Backup",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(ChartData.Backup_Method_Ratio_Pie_Chart_Incremental_Backup_Count) },
                    DataLabels = true
                },

                new PieSeries
                {
                    Title = "Synthetic Backup",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(ChartData.Backup_Method_Ratio_Pie_Chart_Synthetic_Count) },
                    DataLabels = true
                }
            };

            

            //adding values or series will update and animate the chart automatically
            //SeriesCollection.Add(new PieSeries());
            //SeriesCollection[0].Values.Add(5);
          
            DataContext = this;
            

            
        }

        public SeriesCollection SeriesCollection { get; set; }
        public SeriesCollection SeriesCollection1 { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> Formatter { get; set; }



        /*private void UpdateAllOnClick(object sender, RoutedEventArgs e)
        {
            var r = new Random();

            foreach (var series in SeriesCollection)
            {
                foreach (var observable in series.Values.Cast<ObservableValue>())
                {
                    observable.Value = r.Next(0, 10);
                }
            }
        }

        private void AddSeriesOnClick(object sender, RoutedEventArgs e)
        {
            var r = new Random();
            var c = SeriesCollection.Count > 0 ? SeriesCollection[0].Values.Count : 5;

            var vals = new ChartValues<ObservableValue>();

            for (var i = 0; i < c; i++)
            {
                vals.Add(new ObservableValue(r.Next(0, 10)));
            }

            SeriesCollection.Add(new PieSeries
            {
                Values = vals
            });
        }

        private void RemoveSeriesOnClick(object sender, RoutedEventArgs e)
        {
            if (SeriesCollection.Count > 0)
                SeriesCollection.RemoveAt(0);
        }

        private void AddValueOnClick(object sender, RoutedEventArgs e)
        {
            var r = new Random();
            foreach (var series in SeriesCollection)
            {
                series.Values.Add(new ObservableValue(r.Next(0, 10)));
            }
        }

        private void RemoveValueOnClick(object sender, RoutedEventArgs e)
        {
            foreach (var series in SeriesCollection)
            {
                if (series.Values.Count > 0)
                    series.Values.RemoveAt(0);
            }
        }

        private void RestartOnClick(object sender, RoutedEventArgs e)
        {
            Chart.Update(true, true);
        }*/
    }
}
