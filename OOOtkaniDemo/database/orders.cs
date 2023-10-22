namespace OOOtkaniDemo.database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class orders
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public orders()
        {
            good_order = new HashSet<good_order>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Column(TypeName = "date")]
        public DateTime date { get; set; }

        public double price { get; set; }

        public double price_discount { get; set; }

        public int pick_up_point_id { get; set; }

        public int code { get; set; }

        public int? user_id { get; set; }

        public int status_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<good_order> good_order { get; set; }

        public virtual pick_up_points pick_up_points { get; set; }

        public virtual statuses statuses { get; set; }

        public virtual users users { get; set; }
    }
}
