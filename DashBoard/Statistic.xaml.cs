using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using LiveCharts;
using LiveCharts.Wpf;
using static DashBoard.MainWindow;

namespace DashBoard
{
    /// <summary>
    /// Statistic.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Statistic : Window
    {
        
        public Statistic() 
        { 

        InitializeComponent();

            SeriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Total Backup",
                    Values = new ChartValues<double> { ChartData.Total_Backup_Count_LineChart_2022_02_08_Completed_Count,
                                                        ChartData.Total_Backup_Count_LineChart_2022_02_09_Completed_Count,
                                                        ChartData.Total_Backup_Count_LineChart_2022_02_10_Completed_Count,
                                                        ChartData.Total_Backup_Count_LineChart_2022_02_11_Completed_Count,
                                                        ChartData.Total_Backup_Count_LineChart_2022_02_12_Completed_Count,
                                                        ChartData.Total_Backup_Count_LineChart_2022_02_13_Completed_Count,
                                                        ChartData.Total_Backup_Count_LineChart_2022_02_14_Completed_Count,
                                                        ChartData.Total_Backup_Count_LineChart_2022_02_15_Completed_Count}
                },
                new LineSeries
                {
                    Title = "Avg Elapsed Time",
                    Values = new ChartValues<double> { ChartData.Avg_Elapsed_Time_LineChart_2022_02_08_Avg_Elapsed_Times,
                                                        ChartData.Avg_Elapsed_Time_LineChart_2022_02_09_Avg_Elapsed_Times,
                                                        ChartData.Avg_Elapsed_Time_LineChart_2022_02_10_Avg_Elapsed_Times,
                                                        ChartData.Avg_Elapsed_Time_LineChart_2022_02_11_Avg_Elapsed_Times,
                                                        ChartData.Avg_Elapsed_Time_LineChart_2022_02_12_Avg_Elapsed_Times,
                                                        ChartData.Avg_Elapsed_Time_LineChart_2022_02_13_Avg_Elapsed_Times,
                                                        ChartData.Avg_Elapsed_Time_LineChart_2022_02_14_Avg_Elapsed_Times,
                                                        ChartData.Avg_Elapsed_Time_LineChart_2022_02_15_Avg_Elapsed_Times}
                    
                },
                /*new LineSeries
                {
                    Title = "Series 3",
                    Values = new ChartValues<double> { 4,2,7,2,7 },
                    PointGeometry = DefaultGeometries.Square,
                    PointGeometrySize = 15
                }*/
            };

            Labels = new[] { "22.02.08", "22.02.09", "22.02.10", "22.02.11", "22.02.12", "22.02.13", "22.02.14", "22.02.15" };
            YFormatter = value => value.ToString("N");

            //modifying the series collection will animate and update the chart
            /*SeriesCollection.Add(new LineSeries
            {
                Title = "Series 4",
                Values = new ChartValues<double> { 5, 3, 2, 4 },
                LineSmoothness = 0, //0: straight lines, 1: really smooth lines
                PointGeometry = Geometry.Parse("m 25 70.36218 20 -28 -20 22 -8 -6 z"),
                PointGeometrySize = 50,
                PointForeground = Brushes.Gray
            });

            //modifying any series values will also animate and update the chart
            SeriesCollection[3].Values.Add(5d);*/

            DataContext = this;
        }

        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> YFormatter { get; set; }

    }
}
