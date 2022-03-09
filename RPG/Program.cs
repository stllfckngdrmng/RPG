using System.Linq;

namespace RPG
{
    class Program
    {
        public static void Main(string[] args)
        {
            string pathToExcelFile = "D:\\My files\\Work\\C#\\RPG\\ExcelSkills.xlsx"; // Таблица в корне проекта: Path\\RPG\\ExcelSkills.xlsx
            
            ConnectionExcel connectObject = new ConnectionExcel(pathToExcelFile);

            var context1 = new RpgDbContext();
            connectObject.UrlConnection.AddMapping<Skill>(x => x.Range, "Distation");
            var skills = from a in connectObject.UrlConnection.Worksheet<Skill>("Skils").ToList()
                    select a;
            var nn = skills.Where(x => x.Name != null);

            using (var context = new RpgDbContext())
            {
                context.Skills.AddRange(nn);
                
                context.SaveChanges();
            }
        }
    }
}