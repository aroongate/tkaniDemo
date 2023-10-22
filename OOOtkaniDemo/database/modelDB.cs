using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace OOOtkaniDemo.database
{
    public partial class modelDB : DbContext
    {
        public modelDB()
            : base("name=modelDB2")
        {
        }

        public virtual DbSet<good_order> good_order { get; set; }
        public virtual DbSet<goods> goods { get; set; }
        public virtual DbSet<manufacturers> manufacturers { get; set; }
        public virtual DbSet<orders> orders { get; set; }
        public virtual DbSet<pick_up_points> pick_up_points { get; set; }
        public virtual DbSet<roles> roles { get; set; }
        public virtual DbSet<statuses> statuses { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<users> users { get; set; }
        public virtual DbSet<goodsViev> goodsViev { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<goods>()
                .HasMany(e => e.good_order)
                .WithRequired(e => e.goods)
                .HasForeignKey(e => e.good_id);

            modelBuilder.Entity<manufacturers>()
                .HasMany(e => e.goods)
                .WithRequired(e => e.manufacturers)
                .HasForeignKey(e => e.manufacturer_id);

            modelBuilder.Entity<orders>()
                .HasMany(e => e.good_order)
                .WithRequired(e => e.orders)
                .HasForeignKey(e => e.order_id);

            modelBuilder.Entity<pick_up_points>()
                .HasMany(e => e.orders)
                .WithRequired(e => e.pick_up_points)
                .HasForeignKey(e => e.pick_up_point_id);

            modelBuilder.Entity<roles>()
                .HasMany(e => e.users)
                .WithRequired(e => e.roles)
                .HasForeignKey(e => e.role_id);

            modelBuilder.Entity<statuses>()
                .HasMany(e => e.orders)
                .WithRequired(e => e.statuses)
                .HasForeignKey(e => e.status_id);

            modelBuilder.Entity<users>()
                .HasMany(e => e.orders)
                .WithOptional(e => e.users)
                .HasForeignKey(e => e.user_id)
                .WillCascadeOnDelete();

            modelBuilder.Entity<goodsViev>()
                .Property(e => e.image)
                .IsFixedLength();
        }
    }
}
