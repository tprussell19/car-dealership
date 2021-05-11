using System.Collections.Generic;

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
    private static List<Car> _carList = new List<Car> { };

    public Car(string makeModel, int price, int miles)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      _carList.Add(this);
    }

    public static List<Car> GetAll()
    {
      return _carList;
    }

    public static void ClearAll()
    {
      _carList.Clear();
    }
    // public string GetMakeModel()
    // {
    //   return MakeModel;
    // }

    // public int GetPrice()
    // {
    //   return Price;
    // }

    // public void SetPrice(int newPrice)
    // {
    //   Price = newPrice;
    // }

    // public int GetMiles()
    // {
    //   return Miles;
    // }

    // public bool WorthBuying(int maxPrice)
    // {
    //   return (Price <= maxPrice);

    // }
    // public static string MakeSound(string sound)
    // {
    //   return "Our cars sound like " + sound;
    // }
  }
}