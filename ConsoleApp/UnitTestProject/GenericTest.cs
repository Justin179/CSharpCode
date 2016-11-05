using System;
using System.ComponentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp.Generics;

namespace UnitTestProject
{
    [TestClass]
    public class GenericTest
    {

        [TestMethod]
        public void NullableTest()
        {
            var nullable = new Nullable<int>(5);
            Assert.AreEqual(true,nullable.HasValue);
            Assert.AreEqual(5,nullable.GetValueOrDefault());

            Console.WriteLine();
            Console.WriteLine();

            var nullable2 = new Nullable<int>();
            Assert.AreEqual(false, nullable2.HasValue);
            Assert.AreEqual(0, nullable2.GetValueOrDefault());
        }
        
        
        [TestMethod]
        public void GenericDictionaryTest()
        {
            var genericDic = new GenericDictionary<string, Book>();
            var book = new Book();
            genericDic.Add("123", book);

        }
        
        [TestMethod]
        public void GenericListTest()
        {
            // Arrange
            var books = new GenericList<Book>();
            var book = new Book() { Name = "網站開發美學", Price = 380 };
            books.Add(book);
            // Act
            var numbers = new GenericList<int>();
            numbers.Add(1);
            numbers.Add(2);
            // Assert
        }
    }
}
