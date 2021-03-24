using SalesWebMvc.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} requerido")]
        [StringLength(150, MinimumLength = 3, ErrorMessage ="A {0} deve conter entre {2} e {1} caracteres!")]
        [Display(Name = "Descrição")]
        public string Description { get; set; }

        [Required(ErrorMessage = "{0} requerido")]
        [StringLength(3, MinimumLength = 1, ErrorMessage ="A {0} deve conter entre {2} e {1} caracteres!")]
        [Display(Name = "Unidade")]
        public string Unity { get; set; }

        [Required(ErrorMessage = "{0} requerido")]
        [StringLength(20, MinimumLength = 3, ErrorMessage ="A {0} deve conter entre {2} e {1} caracteres!")]
        [Display(Name = "Referência")]
        public string Reference { get; set; }

        [Required(ErrorMessage = "{0} requerido")]
        [StringLength(20, MinimumLength = 3, ErrorMessage ="A {0} deve conter entre {2} e {1} caracteres!")]
        [Display(Name = "Marca")]
        public string Brand { get; set; }

        [Required(ErrorMessage = "{0} requerido")]
        [StringLength(20, MinimumLength = 3, ErrorMessage ="A {0} deve conter entre {2} e {1} caracteres!")]
        [Display(Name = "Medida")]
        public string Measure { get; set; }

        [Display(Name = "Imagem")]
        public string Image { get; set; }

        [Required(ErrorMessage = "{0} requerido")]
        public ProductStatus Status { get; set; }

        [Display(Name = "Categoria")]
        public int CategoryId { get; set; }

        [Display(Name = "Categoria")]
        public Category Category { get; set; }

        [Display(Name = "Fornecedor")]
        public int SupplierId { get; set; }

        [Display(Name = "Fornecedor")]
        public Supplier Supplier { get; set; }

        [Required(ErrorMessage = "{0} requerido")]
        [Display(Name = "Data de Criação")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime CreateDate { get; set; }

        [Required(ErrorMessage = "{0} requerido")]
        [Display(Name = "Data de Alteração")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime UpdateDate { get; set; }

        [Required(ErrorMessage = "{0} requerido")]
        [Display(Name = "Preço Unitário")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public decimal UnitPrice { get; set; }

        [Required(ErrorMessage = "{0} requerido")]
        [Display(Name = "Estoque")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public decimal Stock { get; set; }

        [Display(Name = "Estoque Mínimo")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public decimal StockMin { get; set; }

        [Display(Name = "Estoque Máximo")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public decimal StockMax { get; set; }

        [Display(Name = "MVA")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public decimal Mva { get; set; }

        [Required(ErrorMessage = "{0} requerido")]
        [Display(Name = "Alíquita ICMS")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public decimal IcmsTax { get; set; }

        [Required(ErrorMessage = "{0} requerido")]
        [Display(Name = "Alíquita IPI")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public decimal IpiTax { get; set; }

        [Display(Name = "Estoque")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public decimal AdditionTax { get; set; }

        [Display(Name = "Porcentagem de Desconto")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public decimal DiscountTax { get; set; }

        [Display(Name = "Porcentagem de Frete")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public decimal ShippingTax { get; set; }

        [Required(ErrorMessage = "{0} requerido")]
        [Display(Name = "Múltiplo")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public decimal Multiply { get; set; }

        [Display(Name = "Subistituição Tributária")]
        public bool SubstitutionTax { get; set; }

        [Display(Name = "Classificação Fiscal")]
        [StringLength(20, ErrorMessage ="A {0} deve conter até {1} caracteres!")]
        public string FiscalScrore { get; set; }

        [Display(Name = "CFOP")]
        [StringLength(20, ErrorMessage = "O {0} deve conter até {1} caracteres!")]
        public string Cfop { get; set; }

        [Display(Name = "Natureza da Operação")]
        [StringLength(20, ErrorMessage = "A {0} deve conter até {1} caracteres!")]
        public string NatOper { get; set; }

        [Display(Name = "Código do Produto")]
        [StringLength(20, ErrorMessage = "O {0} deve conter até {1} caracteres!")]
        public string CodeProduct { get; set; }

        [Display(Name = "Código do Fornecedor")]
        [StringLength(20, ErrorMessage = "O {0} deve conter até {1} caracteres!")]
        public string CodeSupplier { get; set; }

        [Display(Name = "Código de Barras")]
        [StringLength(20, ErrorMessage = "O {0} deve conter até {1} caracteres!")]
        public string BarCode { get; set; }

        [Display(Name = "Data da Última Compra")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime LastDateBuy { get; set; }

        [Display(Name = "Data da Última Venda")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime LastDateSale { get; set; }

        public Product() { }

        public Product(int id, string description, string unity, string reference, string brand, string measure, string image, ProductStatus status, Category category, Supplier supplier, DateTime createDate, DateTime updateDate, decimal unitPrice, decimal stock, decimal stockMin, decimal stockMax, decimal mva, decimal icmsTax, decimal ipiTax, decimal additionTax, decimal discountTax, decimal shippingTax, decimal multiply, bool substitutionTax, string fiscalScrore, string cfop, string natOper, string codeProduct, string codeSupplier, string barCode, DateTime lastDateBuy, DateTime lastDateSale)
        {
            Id = id;
            Description = description;
            Unity = unity;
            Reference = reference;
            Brand = brand;
            Measure = measure;
            Image = image;
            Status = status;
            Category = category;
            Supplier = supplier;
            CreateDate = createDate;
            UpdateDate = updateDate;
            UnitPrice = unitPrice;
            Stock = stock;
            StockMin = stockMin;
            StockMax = stockMax;
            Mva = mva;
            IcmsTax = icmsTax;
            IpiTax = ipiTax;
            AdditionTax = additionTax;
            DiscountTax = discountTax;
            ShippingTax = shippingTax;
            Multiply = multiply;
            SubstitutionTax = substitutionTax;
            FiscalScrore = fiscalScrore;
            Cfop = cfop;
            NatOper = natOper;
            CodeProduct = codeProduct;
            CodeSupplier = codeSupplier;
            BarCode = barCode;
            LastDateBuy = lastDateBuy;
            LastDateSale = lastDateSale;
        }

        [Display(Name = "Valor do Frete")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public decimal ShippingValue
        {
            get { return UnitPrice + (UnitPrice * ShippingTax / 100); }
        }

        [Display(Name = "Valor do IPI")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public decimal IpiValue
        {
            get { return ShippingValue + (ShippingValue * IpiTax / 100); }
        }

        [Display(Name = "Valor do ICMS")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public decimal IcmValue
        {
            get { return IpiValue + (IpiValue * IcmsTax / 100); }
        }

        [Display(Name = "Valor do MVA")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public decimal MvaValue
        {
            get { return IcmValue + (IcmValue * Mva / 100); }
        }

        [Display(Name = "Valor do Acréscimo")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public decimal AdditionValue
        {
            get { return MvaValue + AdditionTax / 100; }
        }

        [Display(Name = "Valor do Desconto")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public decimal DiscountValue
        {
            get { return MvaValue - DiscountTax / 100; }
        }
        [Display(Name = "Preço Mínimo de Venda")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public decimal SalePriceMin
        {
            get { return MvaValue - DiscountValue; }
        }

        [Display(Name = "Preço Máximo de Venda")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public decimal SalePriceMax
        {
            get { return SalePriceMin + AdditionValue; }
        }
    }
}
