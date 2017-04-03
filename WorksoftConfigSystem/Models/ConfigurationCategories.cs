namespace WorksoftConfigSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ConfigurationCategories
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]

        public ConfigurationCategories()
        {

        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ConfigurationCategoriesID { get; set; }

        [Required]
        [StringLength(100)]
        public string ConfigurationCategoryDescription { get; set; }

        public int SortingOrder { get; set; }

    }
}
