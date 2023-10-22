namespace OOOtkaniDemo.database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("goodsViev")]
    public partial class goodsViev
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }
        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string name { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string description { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string Expr1 { get; set; }

        [Key]
        [Column(Order = 4)]
        public double price { get; set; }

        public int? discount { get; set; }

 
        public byte[] image { get; set; }
    }
}
