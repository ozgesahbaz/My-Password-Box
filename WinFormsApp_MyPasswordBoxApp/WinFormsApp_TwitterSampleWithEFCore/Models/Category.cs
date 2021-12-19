using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WinFormsApp_TwitterSampleWithEFCore.Models
{
    public class Category : EntityBase<int>
    {
        public Category()
        {
            Labels = new HashSet<Label>();
        }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public virtual ICollection<Label> Labels { get; set; }
    }
}
