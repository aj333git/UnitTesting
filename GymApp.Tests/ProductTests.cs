using GymApp.Models;
using Xunit;

namespace GymApp.Tests {

    public class ProductTests {

        [Fact]
        public void ProductName_Change() {

            // Arrange
            var p = new Product { Machine_Name = "Test", Machine_Price = 100M };

            // Act
            p.Machine_Name = "New Name";

            //Assert
            Assert.Equal("New Name", p.Machine_Name);
        }

        [Fact]
        public void ProductPrice_Change() {

            // Arrange
            var p = new Product { Machine_Name = "Test", Machine_Price = 100M };

            // Act
            p.Machine_Price = 200M;

            //Assert
           
            Assert.Equal(200M, p.Machine_Price);
            
            
        }
    }
}
