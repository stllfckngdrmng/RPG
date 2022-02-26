using System.Linq;

namespace RPG
{
    class Program
    {
        public static void Main(string[] args)
        {
            string pathToExcelFile = "C:\\Users\\Teced\\Desktop\\rpg\\RPG\\ExcelSkills.xlsx"; // Таблица в корне проекта: Path\\RPG\\ExcelSkills.xlsx
            
            ConnectionExcel connectObject = new ConnectionExcel(pathToExcelFile);

            var context1 = new RpgDbContext();
            connectObject.UrlConnection.AddMapping<Skill>(x => x.Range, "Distation");
            var skills = connectObject.UrlConnection.Worksheet<Skill>("Skils").ToList();

            using (var context = new RpgDbContext())
            {
                context.Skills.AddRange(skills);
                
                context.SaveChanges();
            }
        }
    }
}