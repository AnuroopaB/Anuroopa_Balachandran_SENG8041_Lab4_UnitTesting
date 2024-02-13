using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnitDemonstration;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Test_class1
{
    public class Class1
    {
        [TestFixture]

        public class Class2
        {
            [Test]
            //Triangle Test by Anuroopa
            public void TriangleTest()
            {
                //Arrange
                int firstAngle = 60;
                int secondAngle = 60;
                int thirdAngle = 60;

                string expected = "The triangle is valid.";

                //Act
                string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

                //Assert
                ClassicAssert.AreEqual(expected, actual);
            }
        }
    }

}
