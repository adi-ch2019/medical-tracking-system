using MedicalTrackingSystem_Backend.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace MedicalTrackingSystem_Backend.Test.Data.Services
{
    [TestClass]
    public class MTSServiceTests
    {
        private MockRepository mockRepository;



        [TestInitialize]
        public void TestInitialize()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);


        }

        private MTSService CreateService()
        {
            return new MTSService();
        }

        [TestMethod]
        public void AddMedicine_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();
            Medicine newMedicine = null;

            // Act
            service.AddMedicine(
                newMedicine);

            // Assert
            Assert.Fail();
            this.mockRepository.VerifyAll();
        }

        [TestMethod]
        public void DeleteMedicine_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();
            string id = null;

            // Act
            service.DeleteMedicine(
                id);

            // Assert
            Assert.Fail();
            this.mockRepository.VerifyAll();
        }

        [TestMethod]
        public void GetAllMedicines_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();

            // Act
            var result = service.GetAllMedicines();

            // Assert
            Assert.Fail();
            this.mockRepository.VerifyAll();
        }

        [TestMethod]
        public void GetMedicineById_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();
            string id = null;

            // Act
            var result = service.GetMedicineById(
                id);

            // Assert
            Assert.Fail();
            this.mockRepository.VerifyAll();
        }

        [TestMethod]
        public void UpdateMedicine_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();
            string id = null;
            Medicine newMedicine = null;

            // Act
            service.UpdateMedicine(
                id,
                newMedicine);

            // Assert
            Assert.Fail();
            this.mockRepository.VerifyAll();
        }
    }
}
