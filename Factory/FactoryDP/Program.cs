using System;

namespace FactoryMethodDP
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string dbType = Console.ReadLine();

            IDALFactory dalFactoryObj;
            if (dbType == "SQL")
                dalFactoryObj = new SQLDALFactory();
            else
                dalFactoryObj = new OracleDALFactory();

            IDAL dalObj = dalFactoryObj.CreateDALObject();
            Console.WriteLine($"Connection String for {dbType} is: {dalObj.GetConnectionString()}");
        }
    }

    public interface IDAL //Product
    {
        string GetConnectionString();
    }

    public class SQLDAL : IDAL //Concrete Product
    {
        public string GetConnectionString()
        {
            return "Data Source=myServerAddress;Initial Catalog=myDataBase;Integrated Security=SSPI;\nUser ID=myDomain\\myUsername;Password=myPassword;";
        }
    }

    public class OracleDAL : IDAL //Concrete Product
    {
        public string GetConnectionString()
        {
            return "Data Source=MyOracleDB;User Id=myUsername;Password=myPassword;\nIntegrated Security=no;";
        }
    }

    public interface IDALFactory //Creator
    {
        IDAL CreateDALObject();
    }

    public class SQLDALFactory : IDALFactory //Concrete Creator
    {
        public IDAL CreateDALObject()
        {
            return new SQLDAL();
        }
    }

    public class OracleDALFactory : IDALFactory //Concrete Creator
    {
        public IDAL CreateDALObject()
        {
            return new OracleDAL();
        }
    }
}
