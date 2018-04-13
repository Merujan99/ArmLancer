﻿namespace ArmLancer.Data.Models
{
    public class Rating
    {
        public long Id { get; set; }
        public int Score { get; set; }
        public string Review { get; set; } 
        
        public long ClientIdFrom { get; set; }
        public virtual Client ClientFrom { get; set; }
        
        public long ClientIdTo { get; set; }
        public virtual Client ClientTo { get; set; }
    }
}