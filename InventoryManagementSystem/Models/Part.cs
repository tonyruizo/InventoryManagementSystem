﻿namespace InventoryManagementSystem.Models
{
    /// <summary>
    /// Represents a part in the inventory.
    /// </summary>
    public abstract class Part
    {
        public int PartID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
    }
}
