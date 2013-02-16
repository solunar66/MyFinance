//########################################################################
// 目的： 新建和删除常用数据库：                CreateDB/DelDB
//        新建和删除常用数据库中的表：          AddTable/DelTable
//        新建和删除常用数据库中表的字段：      AddTableField:/DelTableField
//        对数据库进行备份和还原：              BackUpDataBase/DbRestore
//        对数据库字段值进行修改：              UpdaterDB
//        对数据库字段值进行查询：              GetDataSet
// 输入： strHostName:     主机名
//        strDbName：      数据库名
//        strSa:           服务器登录名
//        strSaPwd:        服务器登录密码
//        nDbType :        连接的数据库类型 (1:Miscrosoft SQL server)
//        strSqlUpdate：   数据库操作字符串
// 返回： 返回查询结果，并以数据集显示
//########################################################################
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MyFinance
{
    public class Sql
    {
        /**/
        /// <summary>
        ///
        /// </summary>
        public static string strSub;                    //程序过程函数名
        /**/
        /// <summary>
        ///
        /// </summary>
        public static string strCls = "ControlIni";     //代码文件名
        public static string strErrs;                   //运行说明
        public static Boolean bShowMessageBox = false;  //是否弹出错误提示框(默认不弹出)
        bool bOperation;
        public string strConnection;  //连接字符串
        public string strCmd;         //操作字符串
        public SqlConnection sqlConn; //连接对象
        public SqlCommand sqlCmd;     //操作对象
        /**/
        /// <summary>
        /// 对数据库更新
        /// </summary>
        /// <param name="strHostName">主机名</param>
        /// <param name="strDbName">数据库名</param>
        /// <param name="strSa">数据库用户名</param>
        /// <param name="strSaPwd">数据库登录密码</param>
        /// <param name="strTableName">表名</param>
        /// <param name="strUpdater">修改字段</param>
        /// <param name="strReson">修改条件</param>
        /// <param name="nDbType">数据库类型</param>
        /// <returns></returns>
        public bool UpdaterDB(string strHostName, string strDbName, string strSa, string strSaPwd, string strTableName, string strUpdater, string strReson, int nDbType)
        {
            switch (nDbType)
            {
                case 1:
                    strConnection = GetStrConnection(strHostName, strDbName, strSa, strSaPwd, nDbType);
                    break;
                case 2:
                    break;
                default:
                    break;
            }
            try
            {
                //建立数据库操作语句
                strCmd = "update " + strTableName + " set " + strUpdater + " where " + strReson;
                //调用自定义函数，打开 操作 关闭数据库
                bOperation = OperateDataBase();
                if (bOperation == true)
                    return true;  //操作成功，返回真
                else
                    return false;
            }
            catch
            {
                return false;  //操作失败，返回flase
            }
            finally
            {
            }
        }
        //
        /**/
        /// <summary>
        /// 根据条件得到查询结果，返回数据集
        /// </summary>
        /// <param name="strHostName">主机名</param>
        /// <param name="strDbName">数据库名</param>
        /// <param name="strSa">数据库用户名</param>
        /// <param name="strSaPwd">数据库登录密码</param>
        /// <param name="strResult">查询列名</param>
        /// <param name="strTableName">表名</param>
        /// <param name="strReson">查询条件</param>
        /// <param name="nDbType">数据库类型</param>
        /// <returns></returns>
        public DataSet GetDataSet(string strHostName, string strDbName, string strSa, string strSaPwd, string strResult, string strTableName, string strReson, int nDbType)
        {
            switch (nDbType)
            {
                case 1:
                    strConnection = GetStrConnection(strHostName, strDbName, strSa, strSaPwd, nDbType);
                    break;
                case 2:
                    break;
                default: break;
            }
            SqlConnection conn = new SqlConnection(strConnection);
            try
            {
                string strFind = "select " + strResult + " from " + strTableName + " where " + strReson;
                conn.Open();// 打开数据库连接
                SqlDataAdapter da = new SqlDataAdapter(strFind, conn);// 创建数据适配器
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        /// 建立数据库
        ///
        /// 主机名
        /// 数据库名
        /// 路径名
        /// 数据库类型
        ///
        public bool CreateDB(string strHostName, string strNewDbName, string strDbPath, int nDbType)
        {
            switch (nDbType)
            {
                case 1:
                    strConnection = GetStrConnection(strHostName, "", "", "", 1);
                    break;
                case 2:
                    strConnection = GetStrConnection(strHostName, "", "", "", 2);
                    break;
                default: break;
            }
            try
            {
                strCmd = "CREATE DATABASE " + strNewDbName + " ON PRIMARY" + "(name=" + strNewDbName + ", filename ='" + strDbPath + strNewDbName + ".mdf', size=3," + "maxsize=5, filegrowth=10%)";
                //调用自定义函数，打开 操作 关闭数据库
                bOperation = OperateDataBase();
                if (bOperation == true)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false; //操作失败，返回flase
            }
            finally
            {
            }
        }

        /**/
        ///
        /// 删除指定数据库
        ///
        /// 主机名
        /// 数据库名
        /// 数据库类型
        ///
        public bool DelDataBase(string strHostName, string strDbName, int nDbType)
        {
            switch (nDbType)
            {
                case 1:
                    strConnection = GetStrConnection(strHostName, "", "", "", 1);
                    break;
                case 2:
                    break;
                default:
                    break;
            }
            try
            {
                strCmd = "drop database " + strDbName;      //建立操作字符串
                bOperation = OperateDataBase();
                if (bOperation == true)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false; //操作失败，返回flase
            }
            finally
            {
            }
        }
        //
        /**/
        ///
        /// 向数据库中添加表
        ///
        /// 主机名
        /// 数据库名
        /// 数据库用户名
        /// 数据库登录密码
        /// 表名
        /// 数据库类型
        ///
        public bool AddTable(string strHostName, string strDbName, string strSa, string strSaPwd, string strTableName, int nDbType)
        {
            strSub = "AddTable";
            switch (nDbType)
            {
                case 1:
                    strConnection = GetStrConnection(strHostName, strDbName, strSa, strSaPwd, nDbType);
                    break;
                case 2: break;
                default: break;
            }
            try
            {
                //建立表操作语句
                strCmd = "CREATE TABLE " + strTableName + "(id char(50))";
                //调用自定义函数，打开 操作 关闭数据库
                bOperation = OperateDataBase();
                if (bOperation == true)
                    return true;
                else
                    return false;
            }
            catch
            {
                strErrs = "添加数据库的表失败！";
                SubError(strHostName, strDbName, strSa, "", strErrs);
                return false;   //操作失败，返回flase
            }
            finally
            {
                //程序运行日志
                SubLog(strSub);
            }
        }
        //
        /**/
        ///
        /// 删除数据库中表
        ///
        /// 主机名
        /// 数据库名
        /// 数据库用户名
        /// 数据库登录密码
        /// 表名
        ///
        public bool DelTable(string strHostName, string strDbName, string strSa, string strSaPwd, string strTableName, int nDbType)
        {
            strSub = "DelTable";
            switch (nDbType)
            {
                case 1:
                    strConnection = GetStrConnection(strHostName, strDbName, strSa, strSaPwd, nDbType);
                    break;
                default: break;
            }
            try
            {
                //删除数据库表操作语句
                strCmd = "DROP TABLE " + strTableName;
                //调用自定义函数，打开 操作 关闭数据库
                bOperation = OperateDataBase();
                if (bOperation == true)
                    return true;
                else
                    return false;
            }
            catch
            {
                strErrs = "删除数据库的表失败！";
                SubError(strHostName, strDbName, strSa, "", strErrs);
                return false;      //操作失败，返回flase
            }
            finally
            {
                //程序运行日志
                SubLog(strSub);
            }
        }
        /// 向数据库中添加字段值
        /// </summary>
        /// <param name="strHostName">主机名</param>
        /// <param name="strDbName">数据库名</param>
        /// <param name="strSa">数据库用户名</param>
        /// <param name="strSaPwd">数据库登录密码</param>
        /// <param name="strTableName">表名</param>
        /// <param name="strFieldName">字段名</param>
        /// <param name="strFieldType">字段类型</param>
        /// <param name="nDbType">数据库类型</param>
        /// <returns></returns>
        public bool AddTableField(string strHostName, string strDbName, string strSa, string strSaPwd, string strTableName, string strFieldName, string strFieldType, int nDbType)
        {
            strSub = "AddTableField";
            switch (nDbType)
            {
                case 1:
                    strConnection = GetStrConnection(strHostName, strDbName, strSa, strSaPwd, nDbType);
                    break;
                default: break;
            }
            try
            {
                //增加表字段操作语句
                strCmd = "ALTER TABLE " + strTableName + " ADD " + strFieldName + " " + strFieldType;
                //调用自定义函数，打开 操作 关闭数据库
                bOperation = OperateDataBase();
                if (bOperation == true)
                    return true;
                else
                    return false;
            }
            catch
            {
                strErrs = "添加数据库字段失败！";
                SubError(strHostName, strDbName, strSa, "", strErrs);
                return false;      //操作失败，返回flase
            }
            finally
            {
                //程序运行日志
                SubLog(strSub);
            }
        }
        //
        /**/
        /// <summary>
        /// 删除数据库中指定字段值
        /// </summary>
        /// <param name="strHostName">主机名</param>
        /// <param name="strDbName">数据库名</param>
        /// <param name="strSa">数据库用户名</param>
        /// <param name="strSaPwd">数据库登录密码</param>
        /// <param name="strTableName">表名</param>
        /// <param name="strFieldName">字段名</param>
        /// <param name="nDbType">数据库类型</param>
        /// <returns></returns>
        public bool DelTableField(string strHostName, string strDbName, string strSa, string strSaPwd, string strTableName, string strFieldName, int nDbType)
        {
            strSub = "DelTableField";
            switch (nDbType)
            {
                case 1:
                    strConnection = GetStrConnection(strHostName, strDbName, strSa, strSaPwd, nDbType);
                    break;
                case 2:
                    break;
                default: break;
            }
            try
            {
                //删除表字段操作语句
                strCmd = "alter table " + strTableName + " drop column " + strFieldName;
                //调用自定义函数，打开 操作 关闭数据库
                bOperation = OperateDataBase();
                if (bOperation == true)
                    return true;
                else
                    return false;
            }
            catch//(Exception Ex)        throw Ex;
            {
                strErrs = "删除字段失败！";
                SubError(strHostName, strDbName, strSa, "", strErrs);
                return false;    //操作失败，返回flase
            }
            finally
            {
                //程序运行日志
                SubLog(strSub);
            }
        }
        /**/
        /// <summary>
        ///
        /// </summary>
        /// <param name="strHostName"></param>
        /// <param name="strDbName"></param>
        /// <param name="strSa"></param>
        /// <param name="strSaPwd"></param>
        /// <param name="strTableName"></param>
        /// <param name="strFieldName"></param>
        /// <param name="strFieldVaule"></param>
        /// <param name="nDbType"></param>
        /// <returns></returns>
        public bool AddRecord(string strHostName, string strDbName, string strSa, string strSaPwd, string strTableName, string strFieldName, string strFieldVaule, int nDbType)
        {
            strSub = "AddRecord";
            switch (nDbType)
            {
                case 1:
                    strConnection = GetStrConnection(strHostName, strDbName, strSa, strSaPwd, nDbType);
                    break;
                case 2:
                    break;
                default: break;
            }
            try
            {
                //增加表记录语句
                // "insert into " + strTableName + " values " + strFieldVaule;PriKey, Description
                strCmd = " INSERT INTO " + strTableName + " (" + strFieldName + ") VALUES (" + strFieldVaule + ")";
                //调用自定义函数，打开 操作 关闭数据库
                bOperation = OperateDataBase();
                if (bOperation == true)
                    return true;
                else
                    return false;
            }
            catch
            {
                strErrs = "增加记录失败！";
                SubError(strHostName, strDbName, strSa, "", strErrs);
                return false;    //操作失败，返回flase
            }
            finally
            {
                //程序运行日志
                SubLog(strSub);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strHostName"></param>
        /// <param name="strDbName"></param>
        /// <param name="strSa"></param>
        /// <param name="strSaPwd"></param>
        /// <param name="strTableName"></param>
        /// <param name="strUpdater"></param>
        /// <param name="strReson"></param>
        /// <param name="nDbType"></param>
        /// <returns></returns>
        public bool DelRecord(string strHostName, string strDbName, string strSa, string strSaPwd, string strTableName, string strReson, int nDbType)
        {
            switch (nDbType)
            {
                case 1:
                    strConnection = GetStrConnection(strHostName, strDbName, strSa, strSaPwd, nDbType);
                    break;
                case 2:
                    break;
                default:
                    break;
            }
            try
            {
                //建立数据库操作语句
                strCmd = "delete from " + strTableName + " where " + strReson;
                //调用自定义函数，打开 操作 关闭数据库
                bOperation = OperateDataBase();
                if (bOperation == true)
                    return true;  //操作成功，返回真
                else
                    return false;
            }
            catch
            {
                return false;  //操作失败，返回flase
            }
            finally
            {
            }
        }
        /**/
        /// <summary>
        /// 数据库备份
        /// </summary>
        /// <param name="strHostName">主机名</param>
        /// <param name="strSa">数据库用户名</param>
        /// <param name="strSaPwd">数据库密码</param>
        /// <param name="strBackupDb">备份数据名</param>
        /// <param name="strBackPath">备份路径</param>
        /// <param name="nDbType">数据库类型</param>
        /// <returns></returns>
        public bool BackUpDataBase(string strHostName, string strSa, string strSaPwd, string strBackupDb, string strBackPath, int nDbType)
        {
            strSub = "BackUpDataBase";
            //根据输入nDbType判断数据库类型,1为SQL Server  ..
            if (nDbType == 1)
            {
                try
                {
                    string path = @"c:\" + strBackupDb + ".bak";
                    string backupstr = "backup database " + strBackupDb + " to disk='" + path + "';";
                    string strCon = "server=" + strHostName + ";uid=" + strSa + ";pwd=" + strSaPwd;
                    // SqlConnection con = new SqlConnection("server=NWAFT6929FES;uid=sa;pwd=121;");
                    SqlConnection con = new SqlConnection(strCon);
                    SqlCommand cmd = new SqlCommand(backupstr, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return true;
                }
                catch
                {
                    strErrs = "数据库备份失败！";
                    SubError(strHostName, "", strSa, "", strErrs);
                    return false;
                }
                finally
                {
                    //程序运行日志
                    SubLog(strSub);
                }
            }
            else
            {
                if (nDbType == 2)  //期他数据库类型(预留)
                {
                }
                return false;
            }
        }
        /// 数据库还原
        /// </summary>
        /// <param name="strHostName">主机名</param>
        /// <param name="strSa">数据库用户名</param>
        /// <param name="strSaPwd">数据库密码</param>
        /// <param name="strRestoreDb">还原数据名</param>
        /// <param name="strRestorePath">还原路径</param>
        /// <param name="nDbType">数据库类型</param>
        /// <returns></returns>
        public bool DbRestore(string strHostName, string strSa, string strSaPwd, string strRestoreDb, string strRestorePath, int nDbType)
        {
            strSub = "DbRestore";
            if (nDbType == 1)
            {
                try
                {
                    string path = @"c:\" + strRestoreDb + ".bak";
                    string restore = "restore database " + strRestoreDb + " from disk='" + path + "';";
                    string strCon = "server=" + strHostName + ";uid=" + strSa + ";pwd=" + strSaPwd;
                    // SqlConnection con = new SqlConnection("server=NWAFT6929FES;uid=sa;pwd=121;");
                    SqlConnection con = new SqlConnection(strCon);
                    SqlCommand cmd = new SqlCommand(restore, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return true;
                }
                catch
                {
                    strErrs = "数据库还原失败！";
                    SubError(strHostName, "", strSa, "", strErrs);
                    return false;   //操作失败，返回flase
                }
                finally
                {
                    //程序运行日志
                    SubLog(strSub);
                }
            }
            else
            {
                if (nDbType == 2)  //期他数据库类型(预留)
                {
                }
                return false;
            }
        }
        /**/
        /// <summary>
        /// 自定义函数，用于生成连接数据库字符串
        /// </summary>
        /// <param name="strHostName">主机名</param>
        /// <param name="strDbName">数据库名</param>
        /// <param name="strSa">数据库用户名</param>
        /// <param name="strSaPwd">数据库密码</param>
        /// <param name="nDbType">数据库类型</param>
        /// <returns></returns>
        private string GetStrConnection(string strHostName, string strDbName, string strSa, string strSaPwd, int nDbType)
        {
            string strConn = "";
            switch (nDbType)
            {
                case 1:
                    strConn = "Integrated Security=SSPI;Initial Catalog=" + strDbName + ";Data Source=" + strHostName + ";User ID=" + strSa + ";Password=" + strSaPwd + ";";
                    break;
                case 2:
                    strConn = @"Provider=Microsoft.Jet.OLEDB.4.0;Password=" + strSa + ";User ID=" + strSaPwd + ";Data Source=" + strHostName;
                    break;
                case 3: break;
                default:
                    break;
            }
            return strConn;
        }
        /**/
        /// <summary>
        ///
        /// </summary>
        /// <param name="strHostName"></param>
        /// <param name="strDbName"></param>
        /// <param name="strSa"></param>
        /// <param name="strSaPwd"></param>
        /// <param name="nDbType"></param>
        /// <returns></returns>
        public bool bOpen(string strHostName, string strDbName, string strSa, string strSaPwd, int nDbType)
        {
            string conn = GetStrConnection(strHostName, strDbName, strSa, strSaPwd, nDbType);
            bool b;
            try
            {
                sqlConn = new SqlConnection(conn);
                sqlConn.Open();
                if (sqlConn.State.ToString().ToLower() == "open")
                {
                    sqlConn.Close();
                    return true;
                }
                else
                    return false;
            }
            catch(Exception ex)
            {
                return false;
            }
            finally
            {
            }
        }
        //自定义函数，打开、操作、关闭数据库
        /**/
        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        private bool OperateDataBase()
        {
            strSub = "OperateDataBase";
            try
            {
                sqlConn = new SqlConnection(strConnection); //建立连接对象
                sqlConn.Open();                             //打开连接
                sqlCmd = new SqlCommand(strCmd, sqlConn);   //建立操作对象
                SqlDataReader o;
                o = sqlCmd.ExecuteReader();                     //执行数据库操作sql
                sqlConn.Close();
                if (o != null)
                    return true;
                else return false;
                //关闭数据库连接
            }
            catch (Exception ex)
            {
                strErrs = "数据库操作失败！" + ex.ToString();
                SubError("", "", "", "", strErrs);
                return false;
            }
            finally
            {
                //程序运行日志
                SubLog(strSub);
            }
        }
        //捕捉错误信息
        /**/
        /// <summary>
        ///
        /// </summary>
        /// <param name="strHostName"></param>
        /// <param name="strDbName"></param>
        /// <param name="strSa"></param>
        /// <param name="strSaPwd"></param>
        /// <param name="strErrs"></param>
        public static void SubError(string strHostName, string strDbName, string strSa, string strSaPwd, string strErrs)
        {
            String strErr;
            strErr = strErrs + "([" + strHostName + "][" + strDbName + "][" + strSa + "][" + strSaPwd + "])";
            if (bShowMessageBox == false)
            {
            }
            else
            {
                MessageBox.Show(strErr);
            }
            //程序运行异常日志
            SubErrLog(strSub);
        }
        //记录系统日志
        /**/
        /// <summary>
        ///
        /// </summary>
        /// <param name="strSubName"></param>
        public static void SubLog(string strSubName)
        {
            //调用外部接口函数写函数运行过程详细情况(预留)
        }
        /**/
        /// <summary>
        ///
        /// </summary>
        /// <param name="strSubName"></param>
        public static void SubErrLog(string strSubName)
        {
            //写函数运行过程异常详细情况（预留）
        }
    }
}