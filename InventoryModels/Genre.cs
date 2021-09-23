using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryModels
{
    public class Genre : FullAuditModel
    {
        [Required]
        [StringLength(InventoryModelsConstants.MAX_NAME_LENGTH)]
        public string Name { get; set; }

        public virtual List<ItemGenre> GenreItems { get; set; } = new List<ItemGenre>();
        // JOIN tabela ItemGenres je nista vise nego one-to-many veza od JOIN tabele ka obe strane many-to-many veze
    }
}
