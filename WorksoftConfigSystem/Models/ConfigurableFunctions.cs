namespace WorksoftConfigSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ConfigurableFunctions
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ConfigurableFunctionID { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        [Required]
        [StringLength(50)]
        public string ActivationCode { get; set; }

        [StringLength(1000)]
        public string Comments { get; set; }

        public int ConfigurationCategoriesID { get; set; }

        public int ConfigurationDataTypesID { get; set; }

        [StringLength(1000)]
        public string LongComment { get; set; }



    }
}
