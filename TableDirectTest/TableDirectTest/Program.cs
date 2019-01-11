using System;
using System.Data;
using System.Data.OleDb;

namespace ConsoleApplication20
{
    class Program
    {
        static void Main(string[] args)
        {
            OleDbConnection myOleDbConnection =
            new OleDbConnection("Provider=MSDAORA;data source=topcredu;User ID = scott; Password = tiger");
        OleDbCommand myOleDbCommand = myOleDbConnection.CreateCommand();
            //CommendText에 직접 테이블 명을 기술하겠다는 의미
            myOleDbCommand.CommandType = CommandType.TableDirect;
            myOleDbCommand.CommandText = "EMP"; //테이블명이다.
            myOleDbConnection.Open();
            OleDbDataReader myOleDbDataReader = myOleDbCommand.ExecuteReader();
            //전체 EMP 테이블의 데이터중 두 건만 출력하자.
            for (int count = 1; count <= 2; count++)
            {
                myOleDbDataReader.Read();
                Console.WriteLine("myOleDbDataReader[\" EMPNO\"] = " +
               myOleDbDataReader["EMPNO"]);
                Console.WriteLine("myOleDbDataReader[\" ENAME\"] = " +
               myOleDbDataReader["ENAME"]);
                Console.WriteLine("myOleDbDataReader[\" SAL\"] = " +
               myOleDbDataReader["SAL"]);
            }
            myOleDbDataReader.Close();
            myOleDbConnection.Close();
        }
    }
}