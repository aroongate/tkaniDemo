namespace OOOtkaniDemo.database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class good_order
    {
        public int id { get; set; }

        public int good_id { get; set; }

        public int order_id { get; set; }

        public virtual goods goods { get; set; }

        public virtual orders orders { get; set; }
    }
}
