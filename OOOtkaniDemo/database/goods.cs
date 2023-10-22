namespace OOOtkaniDemo.database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class goods
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public goods()
        {
            good_order = new HashSet<good_order>();
        }

       
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        [Required]
        [StringLength(50)]
        public string description { get; set; }

        public int manufacturer_id { get; set; }

        public double price { get; set; }

        public int? discount { get; set; }

        public int count { get; set; }

        public byte[] image { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<good_order> good_order { get; set; }

        public virtual manufacturers manufacturers { get; set; }
    }
}
