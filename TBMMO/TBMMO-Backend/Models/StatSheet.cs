﻿namespace TBMMO_Backend.Models
{
    public class StatSheet
    {
        public int Id { get; set; }
        public string PlayerCharacterId { get; set; }
        public virtual PlayerCharacter PlayerCharacter { get; set; }
    }
}
