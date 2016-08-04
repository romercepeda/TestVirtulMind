using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestFullApp;
using RestFullApp.Controllers;

namespace RestFullApp.Tests.Controllers
{
    [TestClass]
    public class ValuesControllerTest
    {
        [TestMethod]
        public void Dolar()
        {
            // Arrange
            CotizacionController controller = new CotizacionController();

            // Act
            string result = controller.Dolar();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("[\"14.700\",\"15.100\",\"Actualizada al 3/8/2016 15:00\"]", result);
        }

        [TestMethod]
        public void Pesos()
        {
            // Arrange
            CotizacionController controller = new CotizacionController();

            // Act
            Exception exception = null;
            try
            {
                string result = controller.Pesos();
            }
            catch (Exception t)
            {
                exception = t;
            }
            
            // Assert
            Assert.IsNotNull(exception,"The expected exception was not thrown.");
            Assert.AreEqual<Type>(typeof(ArgumentException), exception.GetType(), "401 no authorized de http");
            
        }

        [TestMethod]
        public void Reales()
        {
            // Arrange
            CotizacionController controller = new CotizacionController();
            
            Exception exception = null;
            try
            {
                string result = controller.Reales();
            }
            catch (Exception t)
            {
                exception = t;
            }

            // Assert
            Assert.IsNotNull(exception, "The expected exception was not thrown.");
            Assert.AreEqual<Type>(typeof(ArgumentException), exception.GetType(), "401 no authorized de http");

            // Assert
        }

     
    }
}
