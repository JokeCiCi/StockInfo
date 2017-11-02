using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class StockInfo
    {
        #region Model
        private int _id;
        private string _stockcode;
        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string stockcode
        {
            set { _stockcode = value; }
            get { return _stockcode; }
        }
        #endregion Model

    }
}
