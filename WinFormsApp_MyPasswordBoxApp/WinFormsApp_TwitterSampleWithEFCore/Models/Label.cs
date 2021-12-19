using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WinFormsApp_TwitterSampleWithEFCore.Models
{
    public class Label : EntityBase<int>
    {
        public Label()
        {
            Vaults = new HashSet<Vault>();
        }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Vault> Vaults { get; set; }
    }
}
