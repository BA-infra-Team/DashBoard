using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoard
{
    public class Data
    {
        public string JobStatus { get; set; }
        public string ErrorCode { get; set; }
        public string JobType { get; set; }
        public string BackupMethod { get; set; }
        public string Schedule { get; set; }

        public Data(string jobstatus, string errorcode, string jobtype, string backupmethod, string schedule)
        {
            JobStatus = jobstatus;
            ErrorCode = errorcode;
            JobType = jobtype;
            BackupMethod = backupmethod;
            Schedule = schedule;
        }
    }
}
