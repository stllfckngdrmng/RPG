using System.Collections.Generic;

namespace RPG
{
    public class Npc
    {
        public int Id { get; set; }
        
        public Characteristic Characteristic { get; set; }
        
        public Appearance Appearance { get; set; }
        
        public Personality Personality { get; set; }
        
        /// <summary>
        /// Задание
        /// </summary>
        public string Quest { get; set; }
        
        public Job Job { get; set; }

        public List<NpcSkill> NpcSkills { get; set; }
    }
}