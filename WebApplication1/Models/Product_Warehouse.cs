﻿using System.ComponentModel.DataAnnotations;

namespace DefaultNamespace;

public class Product_Warehouse
{
    [Required]
    public int IdProductWarehouse { get; set; }
    [Required]
    public int IdProduct { get; set; }
    [Required]
    public int IdWarehouse { get; set; }
    [Required]
    public int IdOrder { get; set; }
    [Required]
    public int Amount { get; set; }
    [Required]
    [MaxLength(25)]
    public decimal Price {get; set; }
    [Required]
    public DateTime CreatedAt { get; set; }
}