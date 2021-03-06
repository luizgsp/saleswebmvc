// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SalesWebMvc.Data;

namespace SalesWebMvc.Migrations
{
    [DbContext(typeof(SalesWebMvcContext))]
    [Migration("20210324152147_NewObjects")]
    partial class NewObjects
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SalesWebMvc.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Block");

                    b.Property<string>("City");

                    b.Property<string>("Complement");

                    b.Property<int?>("CustomerId");

                    b.Property<string>("Location");

                    b.Property<string>("Number");

                    b.Property<string>("PostalCode");

                    b.Property<int?>("SupplierId");

                    b.Property<int>("Type");

                    b.Property<string>("UF");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("SupplierId");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("SalesWebMvc.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("SalesWebMvc.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Account");

                    b.Property<string>("AgencyBank");

                    b.Property<string>("BankName");

                    b.Property<string>("CnpjCpf");

                    b.Property<string>("Contact");

                    b.Property<DateTime>("CreateDate");

                    b.Property<decimal>("CreditLimit");

                    b.Property<string>("Email");

                    b.Property<string>("Identification");

                    b.Property<string>("Image");

                    b.Property<string>("MunicipalRegistration");

                    b.Property<string>("Name");

                    b.Property<string>("NickName");

                    b.Property<string>("NumBank");

                    b.Property<int>("PersonType");

                    b.Property<string>("StateRegistration");

                    b.Property<bool>("Status");

                    b.Property<DateTime>("UptadeDate");

                    b.Property<string>("Website");

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("SalesWebMvc.Models.Departament", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Departament");
                });

            modelBuilder.Entity("SalesWebMvc.Models.Phone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CustomerId");

                    b.Property<string>("Number");

                    b.Property<int?>("SupplierId");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("SupplierId");

                    b.ToTable("Phone");
                });

            modelBuilder.Entity("SalesWebMvc.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("AdditionTax");

                    b.Property<string>("BarCode");

                    b.Property<string>("Brand")
                        .IsRequired();

                    b.Property<int>("CategoryId");

                    b.Property<string>("Cfop");

                    b.Property<string>("CodeProduct");

                    b.Property<string>("CodeSupplier");

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<decimal>("DiscountTax");

                    b.Property<string>("FiscalScrore");

                    b.Property<decimal>("IcmsTax");

                    b.Property<string>("Image");

                    b.Property<decimal>("IpiTax");

                    b.Property<DateTime>("LastDateBuy");

                    b.Property<DateTime>("LastDateSale");

                    b.Property<string>("Measure")
                        .IsRequired();

                    b.Property<decimal>("Multiply");

                    b.Property<decimal>("Mva");

                    b.Property<string>("NatOper");

                    b.Property<string>("Reference")
                        .IsRequired();

                    b.Property<decimal>("ShippingTax");

                    b.Property<int>("Status");

                    b.Property<decimal>("Stock");

                    b.Property<decimal>("StockMax");

                    b.Property<decimal>("StockMin");

                    b.Property<bool>("SubstitutionTax");

                    b.Property<int>("SupplierId");

                    b.Property<decimal>("UnitPrice");

                    b.Property<string>("Unity")
                        .IsRequired();

                    b.Property<DateTime>("UpdateDate");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SupplierId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("SalesWebMvc.Models.SalesItems", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Note");

                    b.Property<decimal>("Price");

                    b.Property<int>("ProductId");

                    b.Property<decimal>("Quantity");

                    b.Property<int>("SalesRecordId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("SalesRecordId");

                    b.ToTable("SalesItems");
                });

            modelBuilder.Entity("SalesWebMvc.Models.SalesRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CustomerId");

                    b.Property<DateTime>("Date");

                    b.Property<int?>("SellerId");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("SellerId");

                    b.ToTable("SalesRecord");
                });

            modelBuilder.Entity("SalesWebMvc.Models.Seller", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("BaseSalary");

                    b.Property<DateTime>("BirthDate");

                    b.Property<int>("DepartamentId");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.HasKey("Id");

                    b.HasIndex("DepartamentId");

                    b.ToTable("Seller");
                });

            modelBuilder.Entity("SalesWebMvc.Models.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Account");

                    b.Property<string>("AgencyBank");

                    b.Property<string>("BankName");

                    b.Property<string>("CnpjCpf");

                    b.Property<string>("Contact");

                    b.Property<DateTime>("CreateDate");

                    b.Property<decimal>("CreditLimit");

                    b.Property<string>("Email");

                    b.Property<string>("Identification");

                    b.Property<string>("Image");

                    b.Property<string>("MunicipalRegistration");

                    b.Property<string>("Name");

                    b.Property<string>("NickName");

                    b.Property<string>("NumBank");

                    b.Property<int>("PersonType");

                    b.Property<string>("StateRegistration");

                    b.Property<bool>("Status");

                    b.Property<DateTime>("UptadeDate");

                    b.Property<string>("Website");

                    b.HasKey("Id");

                    b.ToTable("Supplier");
                });

            modelBuilder.Entity("SalesWebMvc.Models.Address", b =>
                {
                    b.HasOne("SalesWebMvc.Models.Customer")
                        .WithMany("Addresses")
                        .HasForeignKey("CustomerId");

                    b.HasOne("SalesWebMvc.Models.Supplier")
                        .WithMany("Addresses")
                        .HasForeignKey("SupplierId");
                });

            modelBuilder.Entity("SalesWebMvc.Models.Phone", b =>
                {
                    b.HasOne("SalesWebMvc.Models.Customer")
                        .WithMany("Phones")
                        .HasForeignKey("CustomerId");

                    b.HasOne("SalesWebMvc.Models.Supplier")
                        .WithMany("Phones")
                        .HasForeignKey("SupplierId");
                });

            modelBuilder.Entity("SalesWebMvc.Models.Product", b =>
                {
                    b.HasOne("SalesWebMvc.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SalesWebMvc.Models.Supplier", "Supplier")
                        .WithMany("Products")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SalesWebMvc.Models.SalesItems", b =>
                {
                    b.HasOne("SalesWebMvc.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SalesWebMvc.Models.SalesRecord", "SalesRecord")
                        .WithMany("Items")
                        .HasForeignKey("SalesRecordId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SalesWebMvc.Models.SalesRecord", b =>
                {
                    b.HasOne("SalesWebMvc.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");

                    b.HasOne("SalesWebMvc.Models.Seller", "Seller")
                        .WithMany("Sales")
                        .HasForeignKey("SellerId");
                });

            modelBuilder.Entity("SalesWebMvc.Models.Seller", b =>
                {
                    b.HasOne("SalesWebMvc.Models.Departament", "Departament")
                        .WithMany("Sellers")
                        .HasForeignKey("DepartamentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
