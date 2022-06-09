
using DeliveryService_Repo;
using System;


namespace DeliveryService_Console;

public class ProgramUI
{
    public void Run()
    {
        Menu();
    }

    // Creating initial selection menu: 
    public void Menu()
    {
        bool keepRunning = true;

        do
        {
            Console.Clear();

            System.Console.WriteLine("Hello! Welcome to Warner Transit Federal.  Please select an option from our menu: \n" +
            "1. Add a new delivery: \n" +
            "2. List all deliveries:\n" +
            "3. Delivery status: \n" +
            "4. Cancel a delivery: \n" +
            "5. Exit");

            string selection = Console.ReadLine();

            switch (selection)
            {
                case "1":
                    AddNewDelivery();
                    break;
                case "2":
                    ListAllDeliveries();
                    break;
                case "3":
                    DeliveryStatus();
                    break;
                case "4":
                    CancelDelivery();
                    break;
                case "5":
                    Console.WriteLine("Goodbye!");
                    keepRunning = false;
                    break;
                default:
                    System.Console.WriteLine("Please enter a valid number.");
                    break;
            }
            
        }while (keepRunning);
    }

    // Add the delivery

    public void AddNewDelivery()
    {
        Console.Clear();
        Delivery newDelivery = new Delivery();

        // Enter Date
        System.Console.WriteLine("Please enter the date for your delivery: ");
        DateTime deliveryDate = Convert.ToDateTime(Console.ReadLine());

        // Enter item number
        System.Console.WriteLine("Please enter the item number: ");
        int itemNumber = Convert.ToInt32(Console.ReadLine());

        // Enter item quantity
        System.Console.WriteLine("Please enter an item quantity: ");
        int itemQuantity = Convert.ToInt32(Console.ReadLine());

    }


    // List all deliveries

    public void ListAllDeliveries()
    {
        Console.Clear();

        List<Delivery> deliveryList = _repo.GetList();

        if(deliveryList.Count < 1)
        {
            System.Console.WriteLine("No orders to view. Please select a delivery.");
        }
        else
        {
            foreach (Delivery delivery in deliveryList)
            {
                System.Console.WriteLine($" ------ Delivery-------\n; +
                $"Ordered on: {delivery.OrderDate}\n" +
                $"Delivered on: {delivery.DeliveryDate}\n" +
                $"Contains item number: {delivery.ItemNumber}\n" +
                $"Quantity of item: {delivery.ItemQuantity}\n" +
                $"With a status of: {delivery.OrderStatus}");
                
            }
        }

    }

    // Get delivery status

    public void DeliveryStatus()
    {
        Console.Clear();

        Delivery status = _repo.GetDeliveryStatus(orderStatus)
        {
            System.Console.WriteLine(orderStatus);
        }

    }

    // Cancel a delivery

    public void CancelDelivery()
    {
        Console.Clear();

        System.Console.WriteLine("Please enter the Customer ID of the delivery you would like to cancel: ");
        int customerID = Convert.ToInt32(Console.ReadLine());

        if (_repo.CancelDelivery(delivery))
        {
            Console.Clear();
            System.Console.WriteLine($"Delivery associated with {customerID} has been successfully deleted.");
        }
        else 
        {
            Console.Clear();
            System.Console.WriteLine($"{customerID} could not be found.");
        }
    }

    


}
