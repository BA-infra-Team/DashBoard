using HandyControl.Tools;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
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

namespace DashBoard
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public class ChartData
        {
            // 홈 UI, 백업-메소드 비율을 보여주기 위한 데이터 구조체 선언 
            public static int Backup_Method_Ratio_Pie_Chart_Total_Count;
            public static int Backup_Method_Ratio_Pie_Chart_Archive_Backup_Count;
            public static int Backup_Method_Ratio_Pie_Chart_Differential_Backup_Count;
            public static int Backup_Method_Ratio_Pie_Chart_Dump_Backup_Count;
            public static int Backup_Method_Ratio_Pie_Chart_Full_Backup_Count;
            public static int Backup_Method_Ratio_Pie_Chart_Incremental_Backup_Count;
            public static int Backup_Method_Ratio_Pie_Chart_Synthetic_Count;

            // 홈 UI, 일별 총 백업 수를 보여주 데이터 구조체 선언
            public static int Total_Backup_Count_LineChart_2022_02_08_Completed_Count;
            public static int Total_Backup_Count_LineChart_2022_02_09_Completed_Count;
            public static int Total_Backup_Count_LineChart_2022_02_10_Completed_Count;
            public static int Total_Backup_Count_LineChart_2022_02_11_Completed_Count;
            public static int Total_Backup_Count_LineChart_2022_02_12_Completed_Count;
            public static int Total_Backup_Count_LineChart_2022_02_13_Completed_Count;
            public static int Total_Backup_Count_LineChart_2022_02_14_Completed_Count;
            public static int Total_Backup_Count_LineChart_2022_02_15_Completed_Count;

          
            
            // 파일통계화면 UI, 파일 관련 통계를 보여줄 데이터 구조체 선언 
            public static int File_Statistics_PieChart_Data_Transferred;
            public static int File_Statistics_PieChart_Total_File_Size;
            public static int File_Statistics_PieChart_Total_Write_Size;

            // 파일통계화면 UI, 평균 경과시간을 보여주는 데이터 구조체 선언 
            public static int Avg_Elapsed_Time_LineChart_2022_02_08_Avg_Elapsed_Times;
            public static int Avg_Elapsed_Time_LineChart_2022_02_09_Avg_Elapsed_Times;
            public static int Avg_Elapsed_Time_LineChart_2022_02_10_Avg_Elapsed_Times;
            public static int Avg_Elapsed_Time_LineChart_2022_02_11_Avg_Elapsed_Times;
            public static int Avg_Elapsed_Time_LineChart_2022_02_12_Avg_Elapsed_Times;
            public static int Avg_Elapsed_Time_LineChart_2022_02_13_Avg_Elapsed_Times;
            public static int Avg_Elapsed_Time_LineChart_2022_02_14_Avg_Elapsed_Times;
            public static int Avg_Elapsed_Time_LineChart_2022_02_15_Avg_Elapsed_Times;

            // 파일통계화면 UI, 작업 종류를 보여주는 데이터 구조체 선언
            public static int JobType_PieChart_Total_Count;
            public static int JobType_PieChart_File_Backup_Count;
            public static int JobType_PieChart_Informix_Onbar_Backup_Count;
            public static int JobType_PieChart_Mysql_Backup_Count;
            public static int JobType_PieChart_Oracle_RMAN_Backup_Count;
            public static int JobType_PieChart_Physical_Backup_Count;
            public static int JobType_PieChart_Vm_Ware_Backup_Count;
            
     // 에러 UI, 에러 비율을 보여주는 데이터 구조체 선언
            public static int Total_Error_Ratio_PieChart_Total_Count;
            public static int Total_Error_Ratio_PieChart_Total_Completed_Count;
            public static int Total_Error_Ratio_PieChart_Total_Error_Count;

            // 에러 UI, 작업 종류별 에러타입을 위한 데이터 구조체 선언 
            public static int Error_Ratio_By_Job_Status_PieChart_Total_Error_Count;
            public static int Error_Ratio_By_Job_Status_PieChart_Partially_Completed_Count;
            public static int Error_Ratio_By_Job_Status_PieChart_Suspended_Error_Count;
            public static int Error_Ratio_By_Job_Status_PieChart_Failed_Error_Count;
            public static int Error_Ratio_By_Job_Status_PieChart_Canceled_Error_Count;

            // 스케줄 별 개수 표시 
            public int Schedule_testsc1_Count;
            public int Schedule_testsc2_Count;
            public int Schedule_testsc3_Count;
            public int Schedule_testsc4_Count;

            // 파일 총 개수
            public int Total_Files_Count;

            // 일별 파일 사이즈 (2022-03-24 추가)
            public static int Total_File_Size_LineChart_2022_02_08_Count;
            public static int Total_File_Size_LineChart_2022_02_09_Count;
            public static int Total_File_Size_LineChart_2022_02_10_Count;
            public static int Total_File_Size_LineChart_2022_02_11_Count;
            public static int Total_File_Size_LineChart_2022_02_12_Count;
            public static int Total_File_Size_LineChart_2022_02_13_Count;
            public static int Total_File_Size_LineChart_2022_02_14_Count;
            public static int Total_File_Size_LineChart_2022_02_15_Count;

            // 일별 저장 사이즈 (2022-03-24 추가)
            public static int Total_Write_Size_LineChart_2022_02_08_Count;
            public static int Total_Write_Size_LineChart_2022_02_09_Count;
            public static int Total_Write_Size_LineChart_2022_02_10_Count;
            public static int Total_Write_Size_LineChart_2022_02_11_Count;
            public static int Total_Write_Size_LineChart_2022_02_12_Count;
            public static int Total_Write_Size_LineChart_2022_02_13_Count;
            public static int Total_Write_Size_LineChart_2022_02_14_Count;
            public static int Total_Write_Size_LineChart_2022_02_15_Count;

            // 일별 전송 사이즈 (2022-03-24 추가)
            public static int Total_Data_Transferred_LineChart_2022_02_08_Count;
            public static int Total_Data_Transferred_LineChart_2022_02_09_Count;
            public static int Total_Data_Transferred_LineChart_2022_02_10_Count;
            public static int Total_Data_Transferred_LineChart_2022_02_11_Count;
            public static int Total_Data_Transferred_LineChart_2022_02_12_Count;
            public static int Total_Data_Transferred_LineChart_2022_02_13_Count;
            public static int Total_Data_Transferred_LineChart_2022_02_14_Count;
            public static int Total_Data_Transferred_LineChart_2022_02_15_Count;

            public void Read_Chart_Data(BinaryReader bRead)
            {
                // 홈 UI, 백업-메소드 비율을 보여주기 위한 데이터 구조체 선언 
                Backup_Method_Ratio_Pie_Chart_Total_Count = bRead.ReadInt32();
                Backup_Method_Ratio_Pie_Chart_Archive_Backup_Count = bRead.ReadInt32();
                Backup_Method_Ratio_Pie_Chart_Differential_Backup_Count = bRead.ReadInt32();
                Backup_Method_Ratio_Pie_Chart_Dump_Backup_Count = bRead.ReadInt32();
                Backup_Method_Ratio_Pie_Chart_Full_Backup_Count = bRead.ReadInt32();
                Backup_Method_Ratio_Pie_Chart_Incremental_Backup_Count = bRead.ReadInt32();
                Backup_Method_Ratio_Pie_Chart_Synthetic_Count = bRead.ReadInt32();

                // 홈 UI, 일별 총 백업 수를 보여주 데이터 구조체 선언
                Total_Backup_Count_LineChart_2022_02_08_Completed_Count = bRead.ReadInt32();
                Total_Backup_Count_LineChart_2022_02_09_Completed_Count = bRead.ReadInt32();
                Total_Backup_Count_LineChart_2022_02_10_Completed_Count = bRead.ReadInt32();
                Total_Backup_Count_LineChart_2022_02_11_Completed_Count = bRead.ReadInt32();
                Total_Backup_Count_LineChart_2022_02_12_Completed_Count = bRead.ReadInt32();
                Total_Backup_Count_LineChart_2022_02_13_Completed_Count = bRead.ReadInt32();
                Total_Backup_Count_LineChart_2022_02_14_Completed_Count = bRead.ReadInt32();
                Total_Backup_Count_LineChart_2022_02_15_Completed_Count = bRead.ReadInt32();

                
                // 파일통계화면 UI, 파일 관련 통계를 보여줄 데이터 구조체 선언 
                File_Statistics_PieChart_Data_Transferred = bRead.ReadInt32();
                File_Statistics_PieChart_Total_File_Size = bRead.ReadInt32();
                File_Statistics_PieChart_Total_Write_Size = bRead.ReadInt32();

                // 파일통계화면 UI, 평균 경과시간을 보여주는 데이터 구조체 선언 
                Avg_Elapsed_Time_LineChart_2022_02_08_Avg_Elapsed_Times = bRead.ReadInt32();
                Avg_Elapsed_Time_LineChart_2022_02_09_Avg_Elapsed_Times = bRead.ReadInt32();
                Avg_Elapsed_Time_LineChart_2022_02_10_Avg_Elapsed_Times = bRead.ReadInt32();
                Avg_Elapsed_Time_LineChart_2022_02_11_Avg_Elapsed_Times = bRead.ReadInt32();
                Avg_Elapsed_Time_LineChart_2022_02_12_Avg_Elapsed_Times = bRead.ReadInt32();
                Avg_Elapsed_Time_LineChart_2022_02_13_Avg_Elapsed_Times = bRead.ReadInt32();
                Avg_Elapsed_Time_LineChart_2022_02_14_Avg_Elapsed_Times = bRead.ReadInt32();
                Avg_Elapsed_Time_LineChart_2022_02_15_Avg_Elapsed_Times = bRead.ReadInt32();

                // 파일통계화면 UI, 작업 종류를 보여주는 데이터 구조체 선언 
                JobType_PieChart_Total_Count = bRead.ReadInt32();
                JobType_PieChart_File_Backup_Count = bRead.ReadInt32();
                JobType_PieChart_Informix_Onbar_Backup_Count = bRead.ReadInt32();
                JobType_PieChart_Mysql_Backup_Count = bRead.ReadInt32();
                JobType_PieChart_Oracle_RMAN_Backup_Count = bRead.ReadInt32();
                JobType_PieChart_Physical_Backup_Count = bRead.ReadInt32();
                JobType_PieChart_Vm_Ware_Backup_Count = bRead.ReadInt32();

                // 에러 UI, 에러 비율을 보여주는 데이터 구조체 선언
                Total_Error_Ratio_PieChart_Total_Count = bRead.ReadInt32();
                Total_Error_Ratio_PieChart_Total_Completed_Count = bRead.ReadInt32();
                Total_Error_Ratio_PieChart_Total_Error_Count = bRead.ReadInt32();

                // 에러 UI, 작업 종류별 에러타입을 위한 데이터 구조체 선언 
                Error_Ratio_By_Job_Status_PieChart_Total_Error_Count = bRead.ReadInt32();
                Error_Ratio_By_Job_Status_PieChart_Partially_Completed_Count = bRead.ReadInt32();
                Error_Ratio_By_Job_Status_PieChart_Suspended_Error_Count = bRead.ReadInt32();
                Error_Ratio_By_Job_Status_PieChart_Failed_Error_Count = bRead.ReadInt32();
                Error_Ratio_By_Job_Status_PieChart_Canceled_Error_Count = bRead.ReadInt32();

                // 스케줄 별 개수 표시 
                Schedule_testsc1_Count = bRead.ReadInt32();
                Schedule_testsc2_Count = bRead.ReadInt32();
                Schedule_testsc3_Count = bRead.ReadInt32();
                Schedule_testsc4_Count = bRead.ReadInt32();

                // 파일 총 개수 
                Total_Files_Count = bRead.ReadInt32();

                // 일별 파일 사이즈 (2022-03-24 추가)
                Total_File_Size_LineChart_2022_02_08_Count = bRead.ReadInt32();
                Total_File_Size_LineChart_2022_02_09_Count = bRead.ReadInt32();
                Total_File_Size_LineChart_2022_02_10_Count = bRead.ReadInt32();
                Total_File_Size_LineChart_2022_02_11_Count = bRead.ReadInt32();
                Total_File_Size_LineChart_2022_02_12_Count = bRead.ReadInt32();
                Total_File_Size_LineChart_2022_02_13_Count = bRead.ReadInt32();
                Total_File_Size_LineChart_2022_02_14_Count = bRead.ReadInt32();
                Total_File_Size_LineChart_2022_02_15_Count = bRead.ReadInt32();



                // 일별 저장 사이즈 (2022-03-24 추가)
                Total_Write_Size_LineChart_2022_02_08_Count = bRead.ReadInt32();
                Total_Write_Size_LineChart_2022_02_09_Count = bRead.ReadInt32();
                Total_Write_Size_LineChart_2022_02_10_Count = bRead.ReadInt32();
                Total_Write_Size_LineChart_2022_02_11_Count = bRead.ReadInt32();
                Total_Write_Size_LineChart_2022_02_12_Count = bRead.ReadInt32();
                Total_Write_Size_LineChart_2022_02_13_Count = bRead.ReadInt32();
                Total_Write_Size_LineChart_2022_02_14_Count = bRead.ReadInt32();
                Total_Write_Size_LineChart_2022_02_15_Count = bRead.ReadInt32();

                // 일별 전송 사이즈 (2022-03-24 추가)
                Total_Data_Transferred_LineChart_2022_02_08_Count = bRead.ReadInt32();
                Total_Data_Transferred_LineChart_2022_02_09_Count = bRead.ReadInt32();
                Total_Data_Transferred_LineChart_2022_02_10_Count = bRead.ReadInt32();
                Total_Data_Transferred_LineChart_2022_02_11_Count = bRead.ReadInt32();
                Total_Data_Transferred_LineChart_2022_02_12_Count = bRead.ReadInt32();
                Total_Data_Transferred_LineChart_2022_02_13_Count = bRead.ReadInt32();
                Total_Data_Transferred_LineChart_2022_02_14_Count = bRead.ReadInt32();
                Total_Data_Transferred_LineChart_2022_02_15_Count = bRead.ReadInt32();

            }
        }
        public MainWindow()
        {
            InitializeComponent();

            //파일 읽기
            string filepath = "C:\\Users\\BIT\\Desktop\\DownloadFromServer\\";
            IPAddress ipAddress = IPAddress.Parse("192.168.0.12");
            int port = 7754;
            IPEndPoint iPEndPoint = new IPEndPoint(ipAddress, port);
            Socket ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            ClientSocket.Connect(iPEndPoint);

            // 버퍼 
            byte[] Buffer = new byte[1024];

            // 클라이언트측에서 서버에게 "접속완료" 문구보냄.
            string message = "Connect With Client";
            byte[] data = System.Text.Encoding.ASCII.GetBytes(message);
            ClientSocket.Send(data);

            // String to store the response ASCII representation.
            String responseData = String.Empty;
            // Read the first batch of the TcpServer response bytes.
            // 서버로부터 처음에 환영인사 문구 메세지 받음

            int rev = ClientSocket.Receive(Buffer);
            responseData = System.Text.Encoding.ASCII.GetString(Buffer, 0, rev);

            MessageBox.Show("Received: {responseData}", responseData);

            // 첫 파일 구조체 정보 
            rev = ClientSocket.Receive(Buffer);
            int fileNameLen = BitConverter.ToInt32(Buffer, 0);
            string fileName = Encoding.ASCII.GetString(Buffer, 4, fileNameLen);

            // 첫 파일 저장 
            BinaryWriter bWrite = new BinaryWriter(File.Open(filepath + fileName, FileMode.Create, FileAccess.Write));
            bWrite.Write(Buffer, 4 + fileNameLen + 1, rev - 4 - fileNameLen - 1);
            bWrite.Close();

            // 파일 읽기 
            BinaryReader bRead = new BinaryReader(File.Open(filepath + fileName, FileMode.Open, FileAccess.Read));

            ChartData ChartDatas = new ChartData();
            ChartDatas.Read_Chart_Data(bRead);
            bRead.Close();                      
                        

            ConfigHelper.Instance.SetLang("en");
            }


            private void Window_MouseDown(object sender, MouseButtonEventArgs e)
            {
                if (e.ChangedButton == MouseButton.Left)
                    this.DragMove();
            }

            //필터 창으로 이동
            private void Button_Click(object sender, RoutedEventArgs e)
            {
                filter filtering = new filter();

                filtering.Show();
            }

            //Statistic 창으로 이동
            private void Button_Click_1(object sender, RoutedEventArgs e)
            {
                Statistic statistic = new Statistic();

                statistic.Show();
            }

            //파이차트 창으로 이동
            private void Button_Click_2(object sender, RoutedEventArgs e)
            {
            TotalFile totalfile = new TotalFile();

            totalfile.Show();
        }

        private void ToT_Backup_Avg_Time_Click(object sender, RoutedEventArgs e)
        {
           
            TotalError totalerror = new TotalError();

            totalerror.Show();
        }
    }
}
