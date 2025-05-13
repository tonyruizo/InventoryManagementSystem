using System.ComponentModel;
using System.Linq;

namespace InventoryManagementSystem.Models
{
    /// <summary>
    /// Represents all the parts and the products for the inventory collection.
    /// </summary>
    public class Inventory
    {
        public static BindingList<Product> Products { get; set; } = new BindingList<Product>();
        public static BindingList<Part> AllParts { get; set; } = new BindingList<Part>();

        /// <summary>
        /// Add a part to the inventory.
        /// </summary>
        /// <param name="part">The part to add.</param>
        public static void AddPart(Part part)
        {
            AllParts.Add(part);
        }

        /// <summary>
        /// Delete a part from the inventory.
        /// </summary>
        /// <param name="part">The part, to be deleted.</param>
        /// <returns>Return true or flase.</returns>
        public static bool DeletePart(Part part)
        {
            return AllParts.Remove(part);
        }

        public static Part LookupPart(int partId)
        {
            return AllParts.FirstOrDefault(p => p.PartID == partId);
        }

        /// <summary>
        /// Update an exisiting part from the inventory.
        /// </summary>
        /// <param name="partId">The ID of the part, to be updated.</param>
        /// <param name="part">The part, to be updated.</param>
        public static void UpdatePart(int partId, Part part)
        {
            var index = AllParts.ToList().FindIndex(p => p.PartID == partId);
            if (index >= 0) AllParts[index] = part;
        }

        /// <summary>
        /// Add a new product to the inventory.
        /// </summary>
        /// <param name="product">The product to add.</param>
        public static void AddProduct(Product product)
        {
            Products.Add(product);
        }

        /// <summary>
        /// Remove the product from the inventory.
        /// </summary>
        /// <param name="productId">The Id of the associated product, to be removed.</param>
        /// <returns></returns>
        public static bool RemoveProduct(int productId)
        {
            Product product = Products.FirstOrDefault(p => p.ProductID == productId);
            if (product != null)
            {
                Products.Remove(product);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Find and return a given product.
        /// </summary>
        /// <param name="productId">The ID of the product to return.</param>
        /// <returns>The product found in the inventory.</returns>
        public Product LookupProduct(int productId)
        {
            return Products.FirstOrDefault(p => p.ProductID == productId);
        }


        /// <summary>
        /// Modify an existing product from the inventory.
        /// </summary>
        /// <param name="productId">The Id of the product, to be modified.</param>
        /// <param name="product">The product. to be modified.</param>
        public static void UpdateProduct(int productId, Product product)
        {
            var index = Products.ToList().FindIndex(p => p.ProductID == productId);
            if (index >= 0)
            {
                Products[index] = product;
            }
        }


    }
}
