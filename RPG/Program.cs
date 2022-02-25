using System.Linq;
using LinqToExcel;

namespace RPG
{
    class Program
    {
        public static void Main(string[] args)
        {
            string pathToExcelFile = "D:\\My files\\Work\\C#\\RPG\\ExcelSkills.xlsx"; // Таблица в корне проекта: Path\\RPG\\ExcelSkills.xlsx
            
            ConnectionExcel ConnectObject = new ConnectionExcel(pathToExcelFile);
            
            ConnectObject.UrlConnection.AddMapping<Skill>(x => x.Range, "Distation");
            
            var skills = from a in ConnectObject.UrlConnection.Worksheet<Skill>("Skils")
                select a;

            using (var context = new RpgDbContext())
            {
                context.AddRange(skills);
                
                context.SaveChanges();
            }
        }
    }
}