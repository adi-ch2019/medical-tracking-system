using MedicalTrackingSystem_Backend.Controllers;
using MedicalTrackingSystem_Backend.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace MedicalTrackingSystem_Backend.Test.Controllers
{
    [TestClass]
    public class MTSControllerTests
    {
        private MockRepository mockRepository;

        private Mock<IMTSService> mockMTSService;

        [TestInitialize]
        public void TestInitialize()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);

            this.mockMTSService = this.mockRepository.Create<IMTSService>();
        }

        private MTSController CreateMTSController()
        {
            return new MTSController(
                this.mockMTSService.Object);
        }

        [TestMethod]
        public void AddMedicine_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mTSController = this.CreateMTSController();
            Medicine medicine = null;

            // Act
            var result = mTSController.AddMedicine(
                medicine);

            // Assert
            Assert.Fail();
            this.mockRepository.VerifyAll();
        }

        [TestMethod]
        public void GetMedicines_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mTSController = this.CreateMTSController();

            // Act
            var result = mTSController.GetMedicines();

            // Assert
            Assert.Fail();
            this.mockRepository.VerifyAll();
        }

        [TestMethod]
        public void UpdateMedicine_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mTSController = this.CreateMTSController();
            string id = null;
            Medicine medicine = null;

            // Act
            var result = mTSController.UpdateMedicine(
                id,
                medicine);

            // Assert
            Assert.Fail();
            this.mockRepository.VerifyAll();
        }

        [TestMethod]
        public void DeleteMedicine_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mTSController = this.CreateMTSController();
            string id = null;

            // Act
            var result = mTSController.DeleteMedicine(
                id);

            // Assert
            Assert.Fail();
            this.mockRepository.VerifyAll();
        }

        [TestMethod]
        public void GetMedicineById_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mTSController = this.CreateMTSController();
            string id = null;

            // Act
            var result = mTSController.GetMedicineById(
                id);

            // Assert
            Assert.Fail();
            this.mockRepository.VerifyAll();
        }
    }
}
