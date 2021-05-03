namespace Dealership.Models
{
  public class Car
  {
    // private string _makeModel;
    // private int _price;
    // private int _miles;

    public string MakeModel { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }

    public Car(string makeModel, int price, int miles)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
    }

    public string GetMakeModel()
    {
      return MakeModel;
    }

    public int GetPrice()
    {
      return Price;
    }

    public void SetPrice(int newPrice)
    {
      Price = newPrice;
    }

    public int GetMiles()
    {
      return Miles;
    }

    public bool WorthBuying(int maxPrice)
    {
      return (Price <= maxPrice);

    }
    public static string MakeSound(string sound)
    {
      return "Our cars sound like " + sound;
    }
  }
}