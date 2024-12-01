using PawnShop.Enums;
using System.ComponentModel.DataAnnotations;

namespace PawnShop.Entities
{
    public class Jewelry
    {
        [Key]
        public int JewelryID { get; set; }

        public JewelryMaterialType? MaterialType { get; set; }

        public JewelryWeightType? WeightType { get; set; }

        public double? Weight { get; set; }

        public double? MarketPrice { get; set; }

        public double? Purity { get; set; }

        public double? QualityFactor { get; set; }

        public ICollection<Item> Items { get; set; }
    }
}