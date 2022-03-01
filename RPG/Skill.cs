namespace RPG
{
    public class Skill
    {
        #region Поля
        public int Id { get; set; }

        public string Branch { get; set; } = "";
    
        public int Level { get; set; }

        public string Name { get; set; } = "";

        public string Type { get; set; } = "";
    
        public int? Mana { get; set; }

        public string Cast { get; set; } = "";

        public string Range { get; set; } = "";

        public string Reaction { get; set; } = "";
    
        public int? Damage { get; set; }

        public string Duration { get; set; } = "";
    
        public int Learning { get; set; }
    
        public int Price { get; set; }

        public string Description { get; set; } = "";

        #endregion
    }
}