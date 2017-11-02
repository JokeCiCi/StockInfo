using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public  class GlobalParams
    {
        #region Model
        public static string _server = "";
        public static string _database = "";
        public static string _uid = "";
        public static string _pwd = "";
        public static string _constr = "server=JOKECICI-PC;database=TEST_StockWork;uid=sa;pwd=123";
        public GlobalParams()
        {
            server = "";//赋值构造
            database = "";
            uid = "";
            pwd = "";
            constr = "server=JOKECICI-PC;database=StockWork;uid=sa;pwd=123";

        }

        /// <summary>
        /// 
        /// </summary>
        public string server
        {
            set { _server = value; }
            get { return _server; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string database
        {
            set { _database = value; }
            get { return _database; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string uid
        {
            set { _uid = value; }
            get { return _uid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pwd
        {
            set { _pwd = value; }
            get { return _pwd; }
        }
        public string constr
        {
            set { _constr = value; }
            get { return _constr; }
        }
        #endregion Model
    }
}
