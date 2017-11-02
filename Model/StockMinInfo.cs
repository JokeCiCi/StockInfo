using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// StockMinInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class StockMinInfo
	{
		public StockMinInfo()
		{}
		#region Model
		private int _id;
		private int? _code;
		private int? _symbol;
		private string _name;
		private string _type;
		private decimal? _open;
		private decimal? _high;
		private decimal? _low;
		private int? _status;
		private decimal? _price;
		private decimal? _yestclose;
		private decimal? _percent;
		private decimal? _updown;
		private string _arrow;
		private string _volume;
		private decimal? _turnover;
		private decimal? _ask1;
		private decimal? _ask2;
		private decimal? _ask3;
		private decimal? _ask4;
		private decimal? _ask5;
		private string _askvol1;
		private string _askvol2;
		private string _askvol3;
		private string _askvol4;
		private string _askvol5;
		private decimal? _bid1;
		private decimal? _bid2;
		private decimal? _bid3;
		private decimal? _bid4;
		private decimal? _bid5;
		private string _bidvol1;
		private string _bidvol2;
		private string _bidvol3;
		private string _bidvol4;
		private string _bidvol5;
		private DateTime? _update;
		private DateTime? _time;
		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 代码
		/// </summary>
		public int? code
		{
			set{ _code=value;}
			get{return _code;}
		}
		/// <summary>
		/// 股票代码
		/// </summary>
		public int? symbol
		{
			set{ _symbol=value;}
			get{return _symbol;}
		}
		/// <summary>
		/// 股票名称（Unicode转码）
		/// </summary>
		public string name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 类型
		/// </summary>
		public string type
		{
			set{ _type=value;}
			get{return _type;}
		}
		/// <summary>
		/// 开盘价
		/// </summary>
		public decimal? open
		{
			set{ _open=value;}
			get{return _open;}
		}
		/// <summary>
		/// 最高价
		/// </summary>
		public decimal? high
		{
			set{ _high=value;}
			get{return _high;}
		}
		/// <summary>
		/// 最低价
		/// </summary>
		public decimal? low
		{
			set{ _low=value;}
			get{return _low;}
		}
		/// <summary>
		/// 股票状态0有效1无效
		/// </summary>
		public int? status
		{
			set{ _status=value;}
			get{return _status;}
		}
		/// <summary>
		/// 当前价格
		/// </summary>
		public decimal? price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 昨日关盘价
		/// </summary>
		public decimal? yestclose
		{
			set{ _yestclose=value;}
			get{return _yestclose;}
		}
		/// <summary>
		/// 涨跌幅百分比
		/// </summary>
		public decimal? percent
		{
			set{ _percent=value;}
			get{return _percent;}
		}
		/// <summary>
		/// 涨跌幅度
		/// </summary>
		public decimal? updown
		{
			set{ _updown=value;}
			get{return _updown;}
		}
		/// <summary>
		/// 箭头（Unicode转码）↓
		/// </summary>
		public string arrow
		{
			set{ _arrow=value;}
			get{return _arrow;}
		}
		/// <summary>
		/// 成交的股票数
		/// </summary>
		public string volume
		{
			set{ _volume=value;}
			get{return _volume;}
		}
		/// <summary>
		/// 成交金额
		/// </summary>
		public decimal? turnover
		{
			set{ _turnover=value;}
			get{return _turnover;}
		}
		/// <summary>
		/// 卖1
		/// </summary>
		public decimal? ask1
		{
			set{ _ask1=value;}
			get{return _ask1;}
		}
		/// <summary>
		/// 卖2
		/// </summary>
		public decimal? ask2
		{
			set{ _ask2=value;}
			get{return _ask2;}
		}
		/// <summary>
		/// 卖3
		/// </summary>
		public decimal? ask3
		{
			set{ _ask3=value;}
			get{return _ask3;}
		}
		/// <summary>
		/// 卖4
		/// </summary>
		public decimal? ask4
		{
			set{ _ask4=value;}
			get{return _ask4;}
		}
		/// <summary>
		/// 卖5
		/// </summary>
		public decimal? ask5
		{
			set{ _ask5=value;}
			get{return _ask5;}
		}
		/// <summary>
		/// 卖1量
		/// </summary>
		public string askvol1
		{
			set{ _askvol1=value;}
			get{return _askvol1;}
		}
		/// <summary>
		/// 卖2量
		/// </summary>
		public string askvol2
		{
			set{ _askvol2=value;}
			get{return _askvol2;}
		}
		/// <summary>
		/// 卖3量
		/// </summary>
		public string askvol3
		{
			set{ _askvol3=value;}
			get{return _askvol3;}
		}
		/// <summary>
		/// 卖4量
		/// </summary>
		public string askvol4
		{
			set{ _askvol4=value;}
			get{return _askvol4;}
		}
		/// <summary>
		/// 卖5量
		/// </summary>
		public string askvol5
		{
			set{ _askvol5=value;}
			get{return _askvol5;}
		}
		/// <summary>
		/// 买1价
		/// </summary>
		public decimal? bid1
		{
			set{ _bid1=value;}
			get{return _bid1;}
		}
		/// <summary>
		/// 买2价
		/// </summary>
		public decimal? bid2
		{
			set{ _bid2=value;}
			get{return _bid2;}
		}
		/// <summary>
		/// 买3价
		/// </summary>
		public decimal? bid3
		{
			set{ _bid3=value;}
			get{return _bid3;}
		}
		/// <summary>
		/// 买4价
		/// </summary>
		public decimal? bid4
		{
			set{ _bid4=value;}
			get{return _bid4;}
		}
		/// <summary>
		/// 买5价
		/// </summary>
		public decimal? bid5
		{
			set{ _bid5=value;}
			get{return _bid5;}
		}
		/// <summary>
		/// 买1量
		/// </summary>
		public string bidvol1
		{
			set{ _bidvol1=value;}
			get{return _bidvol1;}
		}
		/// <summary>
		/// 买2量
		/// </summary>
		public string bidvol2
		{
			set{ _bidvol2=value;}
			get{return _bidvol2;}
		}
		/// <summary>
		/// 买3量
		/// </summary>
		public string bidvol3
		{
			set{ _bidvol3=value;}
			get{return _bidvol3;}
		}
		/// <summary>
		/// 买4量
		/// </summary>
		public string bidvol4
		{
			set{ _bidvol4=value;}
			get{return _bidvol4;}
		}
		/// <summary>
		/// 买5量
		/// </summary>
		public string bidvol5
		{
			set{ _bidvol5=value;}
			get{return _bidvol5;}
		}
		/// <summary>
		/// 更新时间
		/// </summary>
		public DateTime? update
		{
			set{ _update=value;}
			get{return _update;}
		}
		/// <summary>
		/// 返回时间
		/// </summary>
		public DateTime? time
		{
			set{ _time=value;}
			get{return _time;}
		}
		#endregion Model

	}
}

