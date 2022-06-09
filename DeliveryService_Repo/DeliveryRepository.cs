// ! Repository for CRUD method

namespace DeliveryService_Repo;

public class DeliveryRepo
{
    // Need a list for deliveries
    public readonly List<Delivery> _deliveryDirectory = new List<Delivery>();

    // Create: Add a new delivery to the history
    public bool AddDeliveryToList(Delivery delivery)
    {
        int prevDeliveryCount = _deliveryDirectory.Count;

        _deliveryDirectory.Add(delivery);

        if (_deliveryDirectory.Count > prevDeliveryCount)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Read: List all en route deliveries, and all completed deliveries

    public List<Delivery> GetDeliveryList()
    {
        return _deliveryDirectory;
    }

    // Update: Update the status of a delivery
    public void UpdateDeliveryStatus(string originalStatus, Delivery newStatus)
    {
        Delivery oldStatus = GetUpdatedStatus(originalStatus);

        if(oldStatus != null)
        {
            oldStatus.Scheduled = newStatus.OrderDate;
            oldStatus.DeliveryDate = newStatus.DeliveryDate;
            oldStatus.ItemNumber = newStatus.ItemNumber;
            oldStatus.OrderDate = newStatus.OrderDate;
            oldStatus.OrderDate = newStatus.OrderDate;
        }
    }


    // Delete: Cancel a delivery

    public bool CancelDelivery(string delivery)
    {
        
        Delivery deliveryToCancel = GetDeliveryList(delivery);

        if (deliveryToCancel != default)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
