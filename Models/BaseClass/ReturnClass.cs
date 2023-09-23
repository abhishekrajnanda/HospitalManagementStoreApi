﻿using System.Data;

namespace BaseClass
{
    /// <summary>
    /// Summary description for ReturnClass
    /// </summary>
    public class ReturnClass
    {
        public class ReturnDataTable
        {
            public string type { get; set; }
            public bool status { get; set; }
            public string json { get; set; }
            public string message { get; set; }
            public DataTable table { get; set; }
            public string file_name { get; set; }
            public string value { get; set; }
            public ReturnDataTable()
            {
                status = false;
                message = "";
                file_name = "";
                json = "[]";
                table = new DataTable();
                value = "";
                type = "";
            }
        }

        public class ReturnDataSet
        {
            public bool status { get; set; }
            public string message { get; set; }
            public DataSet dataset { get; set; }
            public string file_name { get; set; }
            public string json { get; set; }
            public string value { get; set; }
            public ReturnDataSet()
            {
                status = false;
                message = "";
                file_name = "";
                json = "[]";
                dataset = new DataSet();
                value = "";
            }
        }
        public class ReturnBool
        {
            public bool status { get; set; }
            public string message { get; set; }
            public string error { get; set; }
            public string? remark { get; set; }
            public ReturnBool()
            {
                status = false;
                message = "";
                error = "";
            }
        }
        public class ReturnString
        {
            public bool status { get; set; }
            public string message { get; set; }
            public string value { get; set; }
            public string msg_id { get; set; }
            public string email_msg { get; set; }
            public string any_id { get; set; } // you can pass any user_id or office_id as you want
            public ReturnString()
            {
                status = false;
                message = "";
                value = "";
                msg_id = "";
                email_msg = "";
                any_id = "";
            }
        }
        public class ReturnReportName
        {
            public bool status { get; set; }
            public string message { get; set; }
            public string file_name { get; set; }
            public ReturnReportName()
            {
                status = false;
                message = "";
                file_name = "";
            }
        }
        public class ReturnDocumentDetail
        {
            public bool status { get; set; }
            public string? filePath { get; set; }
            public string? mimeType { get; set; }
            public string? message { get; set; }
            public Int16 dptTableId { get; set; }
            public Int16 documentNumber { get; set; }

            public ReturnDocumentDetail()
            {
                status = false;
                filePath = "";
                mimeType = "";
                message = "";
                dptTableId = 0;
            }
        }
    }
}