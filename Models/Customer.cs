using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerApi.Models;

[Table("Customers", Schema = "Sales")]
public class Customer
{
    [Key]
    public int CustomerID { get; set; }
    
    [Required]
    [StringLength(100)]
    public string CustomerName { get; set; } = string.Empty;
    
    public int BillToCustomerID { get; set; }
    
    public int CustomerCategoryID { get; set; }
    
    public int? BuyingGroupID { get; set; }
    
    public int PrimaryContactPersonID { get; set; }
    
    public int? AlternateContactPersonID { get; set; }
    
    public int DeliveryMethodID { get; set; }
    
    public int DeliveryCityID { get; set; }
    
    public int PostalCityID { get; set; }
    
    [Column(TypeName = "decimal(18,2)")]
    public decimal? CreditLimit { get; set; }
    
    public DateTime AccountOpenedDate { get; set; }
    
    [Column(TypeName = "decimal(18,3)")]
    public decimal StandardDiscountPercentage { get; set; }
    
    public bool IsStatementSent { get; set; }
    
    public bool IsOnCreditHold { get; set; }
    
    public int PaymentDays { get; set; }
    
    [Required]
    [StringLength(20)]
    public string PhoneNumber { get; set; } = string.Empty;
    
    [Required]
    [StringLength(20)]
    public string FaxNumber { get; set; } = string.Empty;
    
    [StringLength(5)]
    public string? DeliveryRun { get; set; }
    
    [StringLength(5)]
    public string? RunPosition { get; set; }
    
    [Required]
    [StringLength(256)]
    public string WebsiteURL { get; set; } = string.Empty;
    
    [Required]
    [StringLength(60)]
    public string DeliveryAddressLine1 { get; set; } = string.Empty;
    
    [StringLength(60)]
    public string? DeliveryAddressLine2 { get; set; }
    
    [Required]
    [StringLength(10)]
    public string DeliveryPostalCode { get; set; } = string.Empty;
    
    [Required]
    [StringLength(60)]
    public string PostalAddressLine1 { get; set; } = string.Empty;
    
    [StringLength(60)]
    public string? PostalAddressLine2 { get; set; }
    
    [Required]
    [StringLength(10)]
    public string PostalPostalCode { get; set; } = string.Empty;
    
    public int LastEditedBy { get; set; }
}