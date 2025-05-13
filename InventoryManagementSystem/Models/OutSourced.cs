namespace InventoryManagementSystem.Models
{
    /// <summary>
    /// Represents the parts that are created by another company.
    /// </summary>
    public class OutSourced : Part
    {
        public string CompanyName { get; set; }
    }
}
