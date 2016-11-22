using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRM.Project.Infrastructure
{
    public static class Utility
    {
        public static DateTime GetDate()
        {
            return DateTime.Now;
        }
        public static DateTime ConvertStringToDate(string date)
        {
            string[] dateArry = date.Split('-');

            return new DateTime(Convert.ToInt32(dateArry[2]), Convert.ToInt32(dateArry[1]), Convert.ToInt32(dateArry[0]));
        }
    }
}