using DeliveryService_Repo;

namespace DeliveryService_Tests;

public class OrderTest
{
    
    [Fact]
    public void IsAddDeliverySuccess()
    {
        Delivery deliveryOne = new Delivery("08/15/2021", 25, 10);
        DeliveryRepo repo = new DeliveryRepo();

        bool isAddDeliverySuccess = repo.AddDeliveryToList(deliveryOne);

        Assert.True(isAddDeliverySuccess);

    }

}