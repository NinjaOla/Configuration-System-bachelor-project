namespace WorksoftConfigSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Settings
    {
        [Key]
        public int SettingId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int? SubIndex { get; set; }

        [StringLength(1000)]
        public string Value { get; set; }

        [StringLength(1000)]
        public string Comments { get; set; }

        public int ConfigurationCategoriesID { get; set; }

        public int ConfigurationDataTypesID { get; set; }

        [StringLength(1000)]
        public string LongComment { get; set; }



    }
}
