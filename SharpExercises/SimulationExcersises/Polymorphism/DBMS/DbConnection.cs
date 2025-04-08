using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpExercises.SimulationExcersises.Polymorphism.DBMS
{
    public abstract class DbConnection
    {
        private string _connectionString;
        private TimeSpan _timeout;

        public DbConnection(string connectionString)
        {
            if(String.IsNullOrWhiteSpace(connectionString)) throw new ArgumentNullException("Connection string cannot be null");
            _connectionString = connectionString;
        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();

    }

    public class SQLConnection : DbConnection
    {
        public SQLConnection(string connectionString) : base(connectionString)
        {
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Close SQL Connection");
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Open SQL Connection ");
        }
    }

    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Close Oracle Connection");
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Open Oracle Connection ");
        }
    }

    public class DbCommand
    {
        private DbConnection _connection;
        private string _command;
        public DbCommand(DbConnection dbConnection, string command)
        {
            if (dbConnection == null)
                throw new ArgumentNullException("DbConnection cannot be null");
            _connection = dbConnection;
            _command = command;
        }

        public void Execute()
        {
            _connection.OpenConnection();
            Console.WriteLine($"Command Executed - {_command}");
            _connection.CloseConnection();
        }
    }
}
