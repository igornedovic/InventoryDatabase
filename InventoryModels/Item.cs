using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InventoryModels
{
    public class Item: FullAuditModel
    {
        [StringLength(InventoryModelsConstants.MAX_NAME_LENGTH)]
        [Required]
        public string Name { get; set; }
        [Range(InventoryModelsConstants.MINIMUM_QUANTITY, InventoryModelsConstants.MAXIMUM_QUANTITY)]
        public int Quantity { get; set; }
        [StringLength(InventoryModelsConstants.MAX_DESCRIPTION_LENGTH)]
        public string Description { get; set; }
        [StringLength(InventoryModelsConstants.MAX_NOTES_LENGTH, MinimumLength = 10)]
        public string Notes { get; set; }
        public bool IsOnSale { get; set; }
        public DateTime? PurchasedDate { get; set; }
        public DateTime? SoldDate { get; set; }
        [Range(InventoryModelsConstants.MINIMUM_PRICE, InventoryModelsConstants.MAXIMUM_PRICE)]
        public decimal? PurchasePrice { get; set; }
        public decimal? CurrentOrFinalPrice { get; set; }
        public virtual Category Category { get; set; } // virtual jer svaki item ima samo jednu kategoriju
        public int? CategoryId { get; set; } // CategoryId trenutno moze biti null, jer vec postoje odredjeni podaci u bazi za Items

        public virtual List<ItemGenre> ItemGenres { get; set; } = new List<ItemGenre>(); 
        // JOIN tabela ItemGenres je nista vise nego one-to-many veza od JOIN tabele ka obe strane many-to-many veze


    }
}
