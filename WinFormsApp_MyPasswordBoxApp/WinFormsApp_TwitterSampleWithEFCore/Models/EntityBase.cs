using System;
using System.ComponentModel.DataAnnotations;

namespace WinFormsApp_TwitterSampleWithEFCore.Models
{
    public class EntityBase<T>
    {
        [Key]
        public T Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
