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
                    Title = "Completed",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(ChartData.Total_Error_Ratio_PieChart_Total_Completed_Count) },
                    DataLabels = true
                    
                },
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

            //adding values or series will update and animate the chart automatically
            //SeriesCollection.Add(new PieSeries());
            //SeriesCollection[0].Values.Add(5);

            DataContext = this;
        }

        public SeriesCollection SeriesCollection { get; set; }

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
