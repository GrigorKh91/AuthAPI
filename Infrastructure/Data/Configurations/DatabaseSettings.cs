namespace Infrastructure.Data.Configurations
{
    public class DatabaseSettings
    {
        public ConnectionStrings ConnectionString { get; set; }
    }

    public class ConnectionStrings
    {
        public string MSSQL { get; set; }
        public string Postgres { get; set; }
        public string MySQL { get; set; }
        public string SQLite { get; set; }
        public string Oracle { get; set; }
    }

}
