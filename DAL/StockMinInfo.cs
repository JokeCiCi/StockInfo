using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:StockMinInfo
	/// </summary>
	public partial class StockMinInfo
	{
		public StockMinInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "StockMinInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from StockMinInfo");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.StockMinInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into StockMinInfo(");
			strSql.Append("code,symbol,name,type,open,high,low,status,price,yestclose,percent,updown,arrow,volume,turnover,ask1,ask2,ask3,ask4,ask5,askvol1,askvol2,askvol3,askvol4,askvol5,bid1,bid2,bid3,bid4,bid5,bidvol1,bidvol2,bidvol3,bidvol4,bidvol5,update,time)");
			strSql.Append(" values (");
			strSql.Append("@code,@symbol,@name,@type,@open,@high,@low,@status,@price,@yestclose,@percent,@updown,@arrow,@volume,@turnover,@ask1,@ask2,@ask3,@ask4,@ask5,@askvol1,@askvol2,@askvol3,@askvol4,@askvol5,@bid1,@bid2,@bid3,@bid4,@bid5,@bidvol1,@bidvol2,@bidvol3,@bidvol4,@bidvol5,@update,@time)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@code", SqlDbType.Int,4),
					new SqlParameter("@symbol", SqlDbType.Int,4),
					new SqlParameter("@name", SqlDbType.VarChar,-1),
					new SqlParameter("@type", SqlDbType.NChar,10),
					new SqlParameter("@open", SqlDbType.Decimal,9),
					new SqlParameter("@high", SqlDbType.Decimal,9),
					new SqlParameter("@low", SqlDbType.Decimal,9),
					new SqlParameter("@status", SqlDbType.Int,4),
					new SqlParameter("@price", SqlDbType.Decimal,9),
					new SqlParameter("@yestclose", SqlDbType.Decimal,9),
					new SqlParameter("@percent", SqlDbType.Float,8),
					new SqlParameter("@updown", SqlDbType.Float,8),
					new SqlParameter("@arrow", SqlDbType.NChar,10),
					new SqlParameter("@volume", SqlDbType.NVarChar,50),
					new SqlParameter("@turnover", SqlDbType.Decimal,9),
					new SqlParameter("@ask1", SqlDbType.Decimal,9),
					new SqlParameter("@ask2", SqlDbType.Decimal,9),
					new SqlParameter("@ask3", SqlDbType.Decimal,9),
					new SqlParameter("@ask4", SqlDbType.Decimal,9),
					new SqlParameter("@ask5", SqlDbType.Decimal,9),
					new SqlParameter("@askvol1", SqlDbType.NVarChar,50),
					new SqlParameter("@askvol2", SqlDbType.NVarChar,50),
					new SqlParameter("@askvol3", SqlDbType.NVarChar,50),
					new SqlParameter("@askvol4", SqlDbType.NVarChar,50),
					new SqlParameter("@askvol5", SqlDbType.NVarChar,50),
					new SqlParameter("@bid1", SqlDbType.Decimal,9),
					new SqlParameter("@bid2", SqlDbType.Decimal,9),
					new SqlParameter("@bid3", SqlDbType.Decimal,9),
					new SqlParameter("@bid4", SqlDbType.Decimal,9),
					new SqlParameter("@bid5", SqlDbType.Decimal,9),
					new SqlParameter("@bidvol1", SqlDbType.NVarChar,50),
					new SqlParameter("@bidvol2", SqlDbType.NVarChar,50),
					new SqlParameter("@bidvol3", SqlDbType.NVarChar,50),
					new SqlParameter("@bidvol4", SqlDbType.NVarChar,50),
					new SqlParameter("@bidvol5", SqlDbType.NVarChar,50),
					new SqlParameter("@update", SqlDbType.DateTime),
					new SqlParameter("@time", SqlDbType.DateTime)};
			parameters[0].Value = model.code;
			parameters[1].Value = model.symbol;
			parameters[2].Value = model.name;
			parameters[3].Value = model.type;
			parameters[4].Value = model.open;
			parameters[5].Value = model.high;
			parameters[6].Value = model.low;
			parameters[7].Value = model.status;
			parameters[8].Value = model.price;
			parameters[9].Value = model.yestclose;
			parameters[10].Value = model.percent;
			parameters[11].Value = model.updown;
			parameters[12].Value = model.arrow;
			parameters[13].Value = model.volume;
			parameters[14].Value = model.turnover;
			parameters[15].Value = model.ask1;
			parameters[16].Value = model.ask2;
			parameters[17].Value = model.ask3;
			parameters[18].Value = model.ask4;
			parameters[19].Value = model.ask5;
			parameters[20].Value = model.askvol1;
			parameters[21].Value = model.askvol2;
			parameters[22].Value = model.askvol3;
			parameters[23].Value = model.askvol4;
			parameters[24].Value = model.askvol5;
			parameters[25].Value = model.bid1;
			parameters[26].Value = model.bid2;
			parameters[27].Value = model.bid3;
			parameters[28].Value = model.bid4;
			parameters[29].Value = model.bid5;
			parameters[30].Value = model.bidvol1;
			parameters[31].Value = model.bidvol2;
			parameters[32].Value = model.bidvol3;
			parameters[33].Value = model.bidvol4;
			parameters[34].Value = model.bidvol5;
			parameters[35].Value = model.update;
			parameters[36].Value = model.time;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.StockMinInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update StockMinInfo set ");
			strSql.Append("code=@code,");
			strSql.Append("symbol=@symbol,");
			strSql.Append("name=@name,");
			strSql.Append("type=@type,");
			strSql.Append("open=@open,");
			strSql.Append("high=@high,");
			strSql.Append("low=@low,");
			strSql.Append("status=@status,");
			strSql.Append("price=@price,");
			strSql.Append("yestclose=@yestclose,");
			strSql.Append("percent=@percent,");
			strSql.Append("updown=@updown,");
			strSql.Append("arrow=@arrow,");
			strSql.Append("volume=@volume,");
			strSql.Append("turnover=@turnover,");
			strSql.Append("ask1=@ask1,");
			strSql.Append("ask2=@ask2,");
			strSql.Append("ask3=@ask3,");
			strSql.Append("ask4=@ask4,");
			strSql.Append("ask5=@ask5,");
			strSql.Append("askvol1=@askvol1,");
			strSql.Append("askvol2=@askvol2,");
			strSql.Append("askvol3=@askvol3,");
			strSql.Append("askvol4=@askvol4,");
			strSql.Append("askvol5=@askvol5,");
			strSql.Append("bid1=@bid1,");
			strSql.Append("bid2=@bid2,");
			strSql.Append("bid3=@bid3,");
			strSql.Append("bid4=@bid4,");
			strSql.Append("bid5=@bid5,");
			strSql.Append("bidvol1=@bidvol1,");
			strSql.Append("bidvol2=@bidvol2,");
			strSql.Append("bidvol3=@bidvol3,");
			strSql.Append("bidvol4=@bidvol4,");
			strSql.Append("bidvol5=@bidvol5,");
			strSql.Append("update=@update,");
			strSql.Append("time=@time");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@code", SqlDbType.Int,4),
					new SqlParameter("@symbol", SqlDbType.Int,4),
					new SqlParameter("@name", SqlDbType.VarChar,-1),
					new SqlParameter("@type", SqlDbType.NChar,10),
					new SqlParameter("@open", SqlDbType.Decimal,9),
					new SqlParameter("@high", SqlDbType.Decimal,9),
					new SqlParameter("@low", SqlDbType.Decimal,9),
					new SqlParameter("@status", SqlDbType.Int,4),
					new SqlParameter("@price", SqlDbType.Decimal,9),
					new SqlParameter("@yestclose", SqlDbType.Decimal,9),
					new SqlParameter("@percent", SqlDbType.Float,8),
					new SqlParameter("@updown", SqlDbType.Float,8),
					new SqlParameter("@arrow", SqlDbType.NChar,10),
					new SqlParameter("@volume", SqlDbType.NVarChar,50),
					new SqlParameter("@turnover", SqlDbType.Decimal,9),
					new SqlParameter("@ask1", SqlDbType.Decimal,9),
					new SqlParameter("@ask2", SqlDbType.Decimal,9),
					new SqlParameter("@ask3", SqlDbType.Decimal,9),
					new SqlParameter("@ask4", SqlDbType.Decimal,9),
					new SqlParameter("@ask5", SqlDbType.Decimal,9),
					new SqlParameter("@askvol1", SqlDbType.NVarChar,50),
					new SqlParameter("@askvol2", SqlDbType.NVarChar,50),
					new SqlParameter("@askvol3", SqlDbType.NVarChar,50),
					new SqlParameter("@askvol4", SqlDbType.NVarChar,50),
					new SqlParameter("@askvol5", SqlDbType.NVarChar,50),
					new SqlParameter("@bid1", SqlDbType.Decimal,9),
					new SqlParameter("@bid2", SqlDbType.Decimal,9),
					new SqlParameter("@bid3", SqlDbType.Decimal,9),
					new SqlParameter("@bid4", SqlDbType.Decimal,9),
					new SqlParameter("@bid5", SqlDbType.Decimal,9),
					new SqlParameter("@bidvol1", SqlDbType.NVarChar,50),
					new SqlParameter("@bidvol2", SqlDbType.NVarChar,50),
					new SqlParameter("@bidvol3", SqlDbType.NVarChar,50),
					new SqlParameter("@bidvol4", SqlDbType.NVarChar,50),
					new SqlParameter("@bidvol5", SqlDbType.NVarChar,50),
					new SqlParameter("@update", SqlDbType.DateTime),
					new SqlParameter("@time", SqlDbType.DateTime),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.code;
			parameters[1].Value = model.symbol;
			parameters[2].Value = model.name;
			parameters[3].Value = model.type;
			parameters[4].Value = model.open;
			parameters[5].Value = model.high;
			parameters[6].Value = model.low;
			parameters[7].Value = model.status;
			parameters[8].Value = model.price;
			parameters[9].Value = model.yestclose;
			parameters[10].Value = model.percent;
			parameters[11].Value = model.updown;
			parameters[12].Value = model.arrow;
			parameters[13].Value = model.volume;
			parameters[14].Value = model.turnover;
			parameters[15].Value = model.ask1;
			parameters[16].Value = model.ask2;
			parameters[17].Value = model.ask3;
			parameters[18].Value = model.ask4;
			parameters[19].Value = model.ask5;
			parameters[20].Value = model.askvol1;
			parameters[21].Value = model.askvol2;
			parameters[22].Value = model.askvol3;
			parameters[23].Value = model.askvol4;
			parameters[24].Value = model.askvol5;
			parameters[25].Value = model.bid1;
			parameters[26].Value = model.bid2;
			parameters[27].Value = model.bid3;
			parameters[28].Value = model.bid4;
			parameters[29].Value = model.bid5;
			parameters[30].Value = model.bidvol1;
			parameters[31].Value = model.bidvol2;
			parameters[32].Value = model.bidvol3;
			parameters[33].Value = model.bidvol4;
			parameters[34].Value = model.bidvol5;
			parameters[35].Value = model.update;
			parameters[36].Value = model.time;
			parameters[37].Value = model.id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from StockMinInfo ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from StockMinInfo ");
			strSql.Append(" where id in ("+idlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.StockMinInfo GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,code,symbol,name,type,open,high,low,status,price,yestclose,percent,updown,arrow,volume,turnover,ask1,ask2,ask3,ask4,ask5,askvol1,askvol2,askvol3,askvol4,askvol5,bid1,bid2,bid3,bid4,bid5,bidvol1,bidvol2,bidvol3,bidvol4,bidvol5,update,time from StockMinInfo ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			Maticsoft.Model.StockMinInfo model=new Maticsoft.Model.StockMinInfo();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.StockMinInfo DataRowToModel(DataRow row)
		{
			Maticsoft.Model.StockMinInfo model=new Maticsoft.Model.StockMinInfo();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["code"]!=null && row["code"].ToString()!="")
				{
					model.code=int.Parse(row["code"].ToString());
				}
				if(row["symbol"]!=null && row["symbol"].ToString()!="")
				{
					model.symbol=int.Parse(row["symbol"].ToString());
				}
				if(row["name"]!=null)
				{
					model.name=row["name"].ToString();
				}
				if(row["type"]!=null)
				{
					model.type=row["type"].ToString();
				}
				if(row["open"]!=null && row["open"].ToString()!="")
				{
					model.open=decimal.Parse(row["open"].ToString());
				}
				if(row["high"]!=null && row["high"].ToString()!="")
				{
					model.high=decimal.Parse(row["high"].ToString());
				}
				if(row["low"]!=null && row["low"].ToString()!="")
				{
					model.low=decimal.Parse(row["low"].ToString());
				}
				if(row["status"]!=null && row["status"].ToString()!="")
				{
					model.status=int.Parse(row["status"].ToString());
				}
				if(row["price"]!=null && row["price"].ToString()!="")
				{
					model.price=decimal.Parse(row["price"].ToString());
				}
				if(row["yestclose"]!=null && row["yestclose"].ToString()!="")
				{
					model.yestclose=decimal.Parse(row["yestclose"].ToString());
				}
				if(row["percent"]!=null && row["percent"].ToString()!="")
				{
					model.percent=decimal.Parse(row["percent"].ToString());
				}
				if(row["updown"]!=null && row["updown"].ToString()!="")
				{
					model.updown=decimal.Parse(row["updown"].ToString());
				}
				if(row["arrow"]!=null)
				{
					model.arrow=row["arrow"].ToString();
				}
				if(row["volume"]!=null)
				{
					model.volume=row["volume"].ToString();
				}
				if(row["turnover"]!=null && row["turnover"].ToString()!="")
				{
					model.turnover=decimal.Parse(row["turnover"].ToString());
				}
				if(row["ask1"]!=null && row["ask1"].ToString()!="")
				{
					model.ask1=decimal.Parse(row["ask1"].ToString());
				}
				if(row["ask2"]!=null && row["ask2"].ToString()!="")
				{
					model.ask2=decimal.Parse(row["ask2"].ToString());
				}
				if(row["ask3"]!=null && row["ask3"].ToString()!="")
				{
					model.ask3=decimal.Parse(row["ask3"].ToString());
				}
				if(row["ask4"]!=null && row["ask4"].ToString()!="")
				{
					model.ask4=decimal.Parse(row["ask4"].ToString());
				}
				if(row["ask5"]!=null && row["ask5"].ToString()!="")
				{
					model.ask5=decimal.Parse(row["ask5"].ToString());
				}
				if(row["askvol1"]!=null)
				{
					model.askvol1=row["askvol1"].ToString();
				}
				if(row["askvol2"]!=null)
				{
					model.askvol2=row["askvol2"].ToString();
				}
				if(row["askvol3"]!=null)
				{
					model.askvol3=row["askvol3"].ToString();
				}
				if(row["askvol4"]!=null)
				{
					model.askvol4=row["askvol4"].ToString();
				}
				if(row["askvol5"]!=null)
				{
					model.askvol5=row["askvol5"].ToString();
				}
				if(row["bid1"]!=null && row["bid1"].ToString()!="")
				{
					model.bid1=decimal.Parse(row["bid1"].ToString());
				}
				if(row["bid2"]!=null && row["bid2"].ToString()!="")
				{
					model.bid2=decimal.Parse(row["bid2"].ToString());
				}
				if(row["bid3"]!=null && row["bid3"].ToString()!="")
				{
					model.bid3=decimal.Parse(row["bid3"].ToString());
				}
				if(row["bid4"]!=null && row["bid4"].ToString()!="")
				{
					model.bid4=decimal.Parse(row["bid4"].ToString());
				}
				if(row["bid5"]!=null && row["bid5"].ToString()!="")
				{
					model.bid5=decimal.Parse(row["bid5"].ToString());
				}
				if(row["bidvol1"]!=null)
				{
					model.bidvol1=row["bidvol1"].ToString();
				}
				if(row["bidvol2"]!=null)
				{
					model.bidvol2=row["bidvol2"].ToString();
				}
				if(row["bidvol3"]!=null)
				{
					model.bidvol3=row["bidvol3"].ToString();
				}
				if(row["bidvol4"]!=null)
				{
					model.bidvol4=row["bidvol4"].ToString();
				}
				if(row["bidvol5"]!=null)
				{
					model.bidvol5=row["bidvol5"].ToString();
				}
				if(row["update"]!=null && row["update"].ToString()!="")
				{
					model.update=DateTime.Parse(row["update"].ToString());
				}
				if(row["time"]!=null && row["time"].ToString()!="")
				{
					model.time=DateTime.Parse(row["time"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,code,symbol,name,type,open,high,low,status,price,yestclose,percent,updown,arrow,volume,turnover,ask1,ask2,ask3,ask4,ask5,askvol1,askvol2,askvol3,askvol4,askvol5,bid1,bid2,bid3,bid4,bid5,bidvol1,bidvol2,bidvol3,bidvol4,bidvol5,update,time ");
			strSql.Append(" FROM StockMinInfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" id,code,symbol,name,type,open,high,low,status,price,yestclose,percent,updown,arrow,volume,turnover,ask1,ask2,ask3,ask4,ask5,askvol1,askvol2,askvol3,askvol4,askvol5,bid1,bid2,bid3,bid4,bid5,bidvol1,bidvol2,bidvol3,bidvol4,bidvol5,update,time ");
			strSql.Append(" FROM StockMinInfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM StockMinInfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.id desc");
			}
			strSql.Append(")AS Row, T.*  from StockMinInfo T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "StockMinInfo";
			parameters[1].Value = "id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

