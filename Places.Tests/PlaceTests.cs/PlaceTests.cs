using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Places.Models;
using System;

namespace Places.Tests
{
  [TestClass]
  public class PlaceTests : IDisposable
  {

    public void Dispose()
    {
      Place.ClearAll();
    }

    // [TestMethod]
    // public void PlaceConstructor_CreatesInstanceOfPlace_Place()
    // {
    //   Place newPlace = new Place("test");
    //   Assert.AreEqual(typeof(Place), newPlace.GetType());
    // }

    // [TestMethod]
    // public void GetPlaceName_ReturnsPlaceName_String()
    // {
    //   //Arrange
    //   string placeName = "Manchester, New Hampshire";

    //   //Act
    //   Place newPlace= new Place(placeName);
    //   string result = newPlace.PlaceName;

    //   //Assert
    //   Assert.AreEqual(placeName, result);
    // }

    [TestMethod]
    public void SetProperties_ConstructorSetsPropertiesAccurately_String()
    {
      //Arrange
      
      string placeName = "Atlanta, Georgia";
      string lengthOfStay = "5";
      string dateOfVisit = "08/21/2021";
      string company = "Fabio";
      string journalEntry = "Fabio and I went to the park.as It was lovely.";
      string favFood = "Baklava";

      //Act
      Place newPlace = new Place(placeName, lengthOfStay, dateOfVisit, company, journalEntry, favFood);
      string resultPlaceName = newPlace.PlaceName;
      string resultCompany = newPlace.Company;
      string resultLengthOfStay = newPlace.LengthOfStay;
      string resultDateOfVisit = newPlace.DateOfVisit;
      string resultJournalEntry = newPlace.JournalEntry;
      string resultFavFood = newPlace.FavFood;


      //Assert
      Assert.AreEqual(resultPlaceName, newPlace.PlaceName);
      Assert.AreEqual(resultLengthOfStay, newPlace.LengthOfStay);
      Assert.AreEqual(resultDateOfVisit, newPlace.DateOfVisit);
      Assert.AreEqual(resultCompany, newPlace.Company);
      Assert.AreEqual(resultJournalEntry, newPlace.JournalEntry);
      Assert.AreEqual(resultFavFood, newPlace.FavFood);
    }

    // [TestMethod]
    // public void GetAll_ReturnsEmptyList_ItemList()
    // {
    //   // Arrange
    //   List<Item> newList = new List<Item> { };

    //   // Act
    //   List<Item> result = Item.GetAll();

    //   // Assert
    //   CollectionAssert.AreEqual(newList, result);
    // }

    // [TestMethod]
    // public void GetAll_ReturnsItems_ItemList()
    // {
    //   //Arrange
    //   string description01 = "Walk the dog";
    //   string description02 = "Wash the dishes";
    //   Item newItem1 = new Item(description01);
    //   Item newItem2 = new Item(description02);
    //   List<Item> newList = new List<Item> { newItem1, newItem2 };

    //   //Act
    //   List<Item> result = Item.GetAll();

    //   //Assert
    //   CollectionAssert.AreEqual(newList, result);
    // }
    // [TestMethod]
    // public void GetId_ItemsInstantiateWithAnIdAndGetterReturns_Int()
    // {
    //   //Arrange
    //   string description = "Walk the dog.";
    //   Item newItem = new Item(description);

    //   //Act
    //   int result = newItem.Id;

    //   //Assert
    //   Assert.AreEqual(1, result);
    // }
    //   [TestMethod]
    //   public void Find_ReturnsCorrectItem_Item()
    //   {
    //     //Arrange
    //     string description01 = "Walk the dog";
    //     string description02 = "Wash the dishes";
    //     Item newItem1 = new Item(description01);
    //     Item newItem2 = new Item(description02);

    //     //Act
    //     Item result = Item.Find(2);

    //     //Assert
    //     Assert.AreEqual(newItem2, result);
    //   }
  }
}