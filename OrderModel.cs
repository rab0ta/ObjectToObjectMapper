﻿public class OrderModel
{
    public int Id { get; set; }
    public string CustomerName { get; set; }
    public string DeliveryAddress { get; set; }
    public DateTime EstimatedDeliveryDate { get; set; }
    public string OrderReference { get; set; }
}