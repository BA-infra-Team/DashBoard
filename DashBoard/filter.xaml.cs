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

namespace DashBoard
{
    /// <summary>
    /// filter.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class filter : Window
    {
        Data[] Datas = new Data[]
        {
            new Data("Completed", "-", "Informix Onbar Backup", "Full Backup", "testsc_2"),
            new Data("Completed", "-", "Informix Onbar Backup", "Full Backup", "testsc_1"),
            new Data("Completed", "-", "Informix Onbar Backup", "Incremental Backup", "testsc_4"),
            new Data("Completed", "-", "Informix Onbar Backup", "Incremental Backup", "testsc_3"),
            new Data("Completed", "-", "File Backup", "Archive Backup", "testsc_2"),
        };
        public filter()
        {
            InitializeComponent();

            LogList.ItemsSource = Datas;
        }
        /*private void dtp_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            // 시작 날짜가 선택 시
            if (dtp01.SelectedDate.HasValue)
            {
                dtp02.DisplayDateStart = dtp01.SelectedDate.Value;   // datepicker02 에 시작날짜 선택 제한
            }

            // 끝 날짜 선택 시
            if (dtp02.SelectedDate.HasValue)
            {
                dtp01.DisplayDateEnd = dtp02.SelectedDate.Value;   // datepicker01 에 끝 날짜 선택 제한
            }

            // 기간표기(총 일수)
            if (dtp01.SelectedDate.HasValue && dtp02.SelectedDate.HasValue)   // 날짜가 둘다 있는지 여부확인
            {
                lbl.Content = dtp01.SelectedDate.Value.ToString("yyyy-MM-dd");   // 선택 날짜 표기
                lbl.Content += " ~ " + dtp02.SelectedDate.Value.ToString("yyyy-MM-dd") + "\n";   // 선택 날짜 표기
                lbl.Content += "총 기간은" + (dtp02.SelectedDate.Value - dtp01.SelectedDate.Value).Days.ToString() + "일 입니다.";   // days 체크하여 표기
            }
        }*/

        private void btn_close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }

}
