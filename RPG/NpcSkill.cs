namespace RPG
{
    /// <summary>
    /// Навык НПС
    /// </summary>
    public class NpcSkill
    {
        /// <summary>
        /// Название навыка
        /// </summary>
        public string SkillName { get; set; }
        
        /// <summary>
        /// Характеристика навыка
        /// </summary>
        public string Characteristic { get; set; }
        
        /// <summary>
        /// Уровень навыка
        /// </summary>
        public int SkillLevel { get; set; }
        
        /// <summary>
        /// Максимальный уровень навыка
        /// </summary>
        public int MaxSkillLevel { get; set; }
    }
}