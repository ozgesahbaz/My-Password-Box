using System.ComponentModel.DataAnnotations;

namespace WinFormsApp_TwitterSampleWithEFCore.Models
{
    public class Vault : EntityBase<int>
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Username { get; set; }

        public string Password { get; set; }
        public string Description { get; set; }
        public int LabelId { get; set; }

        public virtual Label Label { get; set; }
    }
}
