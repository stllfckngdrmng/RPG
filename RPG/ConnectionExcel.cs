using LinqToExcel;

namespace RPG
{
    public class ConnectionExcel
    {
        public IExcelQueryFactory UrlConnection { get; }

        public ConnectionExcel(string path)
        {
            UrlConnection = new ExcelQueryFactory(path);
        }
    }
}