using Microsoft.VisualStudio.TestTools.UnitTesting;
using Interceptor_Wether.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interceptor_Wether.Service_Class.Tests
{
    [TestClass()]
    public class DisplayTests
    {
        [TestMethod()]
        public void UpdateTest()
        {
            Display display = new Display();
            display.Update(24.0, 72.1, 33.3);
        }
    }
}