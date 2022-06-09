using System.Security.Cryptography;
using System;
// ! POCO file

namespace DeliveryService_Repo;

public class Delivery
{
    public Delivery(DateTime orderDate, DateTime deliveryDate, int itemNumber, int itemQuantity, Random customerID, string orderStatus)
    {
        OrderDate = orderDate;
        DeliveryDate = deliveryDate;
        ItemNumber = itemNumber;
        ItemQuantity = itemQuantity;
        CustomerID = customerID;
        OrderStatus = orderStatus;
    }

// Do I need a custom get for order status? 
    public string OrderStatus {get; set; }
   
    public DateTime OrderDate { get; set; }

    public DateTime DeliveryDate { get; set; }

    public int ItemNumber {get; set; }

    public int ItemQuantity {get; set; }

// Not sure if using 'Random' is correct here.  Having a hard time determining if assigning a Random num here is the right approach.  
    public Random CustomerID { get; set; }

    

}

 public enum OrderStatus
    {
        Scheduled = 1,
        EnRoute,
        Complete,
        Canceled,
        Unknown
    }
