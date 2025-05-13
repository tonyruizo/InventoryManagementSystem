using System.ComponentModel;
using System.Linq;

namespace InventoryManagementSystem.Models
{
    /// <summary>
    /// Represents a product in the inventory.
    /// </summary>
    public class Product
    {
        public BindingList<Part> AssociatedParts { get; } = new BindingList<Part>();
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        /// <summary>
        /// Add an associated part to the inventory.
        /// </summary>
        /// <param name="part">The part to add.</param>
        public void AddAssociatedParts(Part part)
        {
            AssociatedParts.Add(part);
        }

        /// <summary>
        /// Remove an associated part from the inventory.
        /// </summary>
        /// <param name="partId">The ID of the part, to be removed.</param>
        /// <returns>Returns true or false.</returns>
        public bool RemoveAssociatedPart(int partId)
        {
            Part part = AssociatedParts.FirstOrDefault(p => p.PartID == partId);
            if (part != null)
            {
                AssociatedParts.Remove(part);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Find and return a given part.
        /// </summary>
        /// <param name="partId">The ID of the part, to return</param>
        /// <returns>The part found in the inventory.</returns>
        public Part LookupAssociatedPart(int partId)
        {
            return AssociatedParts.FirstOrDefault(p => p.PartID == partId);
        }


    }
}
