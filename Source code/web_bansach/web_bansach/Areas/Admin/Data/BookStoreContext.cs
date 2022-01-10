using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web_bansach.Areas.Admin.Models;
using Microsoft.EntityFrameworkCore;
using web_bansach.ModelView;
using web_bansach.Models;

namespace web_bansach.Areas.Admin.Data
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext()
        {
        }

        public BookStoreContext(DbContextOptions<BookStoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AuthorModel> Authors { get; set; }
        public virtual DbSet<BookModel> Books { get; set; }
        public virtual DbSet<CategoryModel> Categories { get; set; }
        public virtual DbSet<CustomerModel> Customers { get; set; }
        public virtual DbSet<OrderModel> DbOrders { get; set; }
        public virtual DbSet<UserModel> DbUsers { get; set; }
        public virtual DbSet<DistrictModel> Districts { get; set; }
        public virtual DbSet<OrderDetailModel> Orderdetails { get; set; }
        public virtual DbSet<ProducerModel> Producers { get; set; }
        public virtual DbSet<ProvinceModel> Provinces { get; set; }
        //public virtual DbSet<Slider> Sliders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost; Database=QLBS; Trusted_Connection=True; MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuthorModel>(entity =>
            {
                entity.ToTable("Author");

                entity.Property(e => e.AuthorID).HasColumnName("AuthorID");

                entity.Property(e => e.AuthorName).HasMaxLength(255);

                entity.Property(e => e.Created_at)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_at");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.Phone)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BookModel>(entity =>
            {
                entity.ToTable("Book");

                entity.Property(e => e.BookID).HasColumnName("BookID");

                entity.Property(e => e.AuthorID).HasColumnName("AuthorID");

                entity.Property(e => e.BookName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CategoryID).HasColumnName("CategoryID");

                entity.Property(e => e.Created_at)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_at");

                entity.Property(e => e.Img)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                //entity.Property(e => e.PriceSale).HasColumnType("money");

                entity.Property(e => e.PriceUnit).HasColumnType("money");

                entity.Property(e => e.ProducerID).HasColumnName("ProducerID");

                entity.Property(e => e.Quantity_buy).HasColumnName("Quantity_buy");

                //entity.HasOne(d => d.AuthorID)
                //    .WithMany(p => p.Books)
                //    .HasForeignKey(d => d.AuthorId)
                //    .HasConstraintName("FK_BOOK_AUTHOR");

                //entity.HasOne(d => d.Category)
                //    .WithMany(p => p.Books)
                //    .HasForeignKey(d => d.CategoryId)
                //    .HasConstraintName("FK_BOOK_CATEGORY");

                //entity.HasOne(d => d.Producer)
                //    .WithMany(p => p.Books)
                //    .HasForeignKey(d => d.ProducerId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_BOOK_PRODUCER");
            });

            modelBuilder.Entity<CategoryModel>(entity =>
            {
                entity.ToTable("Category");

                entity.Property(e => e.CategoryID).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName).HasMaxLength(255);

                entity.Property(e => e.Created_at)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_at");
            });

            modelBuilder.Entity<CustomerModel>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.CustomerID).HasColumnName("CustomerID");

                entity.Property(e => e.Address).HasMaxLength(255);

                entity.Property(e => e.Created_at)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_at");

                entity.Property(e => e.CustomerName).HasMaxLength(255);

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Salt)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderModel>(entity =>
            {
                entity.HasKey(e => e.OrderID)
                   .HasName("PK__db_Order__C3905BAF8EA5E226");

                entity.ToTable("db_Order");

                entity.Property(e => e.OrderID).HasColumnName("OrderID");

                entity.Property(e => e.Address).HasMaxLength(255);

                entity.Property(e => e.Created_at)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_at");

                entity.Property(e => e.CustomerID).HasColumnName("CustomerID");

                entity.Property(e => e.CustomerName).HasMaxLength(255);

                entity.Property(e => e.Total).HasColumnType("money");
            });

            modelBuilder.Entity<UserModel>(entity =>
            {
                entity.HasKey(e => e.UserID)
                    .HasName("PK__db_User__1788CCAC93F1E4FD");

                entity.ToTable("db_User");

                entity.Property(e => e.UserID).HasColumnName("UserID");

                entity.Property(e => e.Address).HasMaxLength(255);

                entity.Property(e => e.Created_at)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_at");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeName).HasMaxLength(255);

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            //modelBuilder.Entity<DistrictModel>(entity =>
            //{
            //    entity.ToTable("District");

            //    entity.Property(e => e.DistrictID).HasColumnName("DistrictID");

            //    entity.Property(e => e.DistrictName).HasMaxLength(255);

            //    entity.Property(e => e.ProvinceID).HasColumnName("ProvinceID");

            //    //entity.HasOne(d => d.Province)
            //    //    .WithMany(p => p.Districts)
            //    //    .HasForeignKey(d => d.ProvinceId)
            //    //    .HasConstraintName("FK_District_Province");
            //});

            modelBuilder.Entity<OrderDetailModel>(entity =>
            {
                entity.ToTable("Orderdetail");

                entity.Property(e => e.OrderdetailID).HasColumnName("OrderdetailID");

                entity.Property(e => e.BookID).HasColumnName("BookID");

                entity.Property(e => e.OrderID).HasColumnName("OrderID");

                entity.Property(e => e.PriceUnit).HasColumnType("money");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.Orderdetails)
                    .HasForeignKey(d => d.BookID)
                    .HasConstraintName("FK_Orderdetail_Book");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Orderdetails)
                    .HasForeignKey(d => d.OrderID)
                    .HasConstraintName("FK_Orderdetail_Order");
            });

            modelBuilder.Entity<ProducerModel>(entity =>
            {
                entity.ToTable("Producer");

                entity.Property(e => e.ProducerID).HasColumnName("ProducerID");

                entity.Property(e => e.Created_at)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_at");

                entity.Property(e => e.ProducerName).HasMaxLength(255);
            });

            //modelBuilder.Entity<ProvinceModel>(entity =>
            //{
            //    entity.ToTable("Province");

            //    entity.Property(e => e.ProvinceID).HasColumnName("ProvinceID");

            //    entity.Property(e => e.ProvinceName).HasMaxLength(255);
            //});

            //modelBuilder.Entity<Slider>(entity =>
            //{
            //    entity.HasKey(e => e.SlideId)
            //        .HasName("PK__Slider__9E7CB67093C78716");

            //    entity.ToTable("Slider");

            //    entity.Property(e => e.SlideId).HasColumnName("SlideID");

            //    entity.Property(e => e.Img)
            //        .HasMaxLength(100)
            //        .IsUnicode(false);

            //    entity.Property(e => e.SlideName).HasMaxLength(255);

            //    entity.Property(e => e.SliderLink).HasMaxLength(255);
            //});


        }

        public DbSet<web_bansach.ModelView.RegisterViewModel> RegisterViewModel { get; set; }


    }
}

