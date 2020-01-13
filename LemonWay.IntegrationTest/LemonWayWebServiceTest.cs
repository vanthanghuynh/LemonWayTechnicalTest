using System.Threading.Tasks;
using LemonWay.TestBase;
using LemonWay.WebServiceConnector;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LemonWay.IntegrationTest
{
    [TestClass]
    public class LemonWayWebServiceTest
    {
        private LemonWayWSConnector lemonWayWSConnector;

        [TestInitialize]
        public void SetUp()
        {
            lemonWayWSConnector = new LemonWayWSConnector();
        }

        [TestMethod]
        public async Task should_communication_ok()
        {
            int n = 2;
            string xmlStr = AccessTestResource.GetTestResourceString("first_test_xml.txt");

            var actual1 = await lemonWayWSConnector.ComputeFibonnaciAsync(n);
            var actual2 = await lemonWayWSConnector.XmlToJsonAsync(xmlStr);

            Assert.IsNotNull(actual1.Result);
            Assert.IsNotNull(actual2.Result);
            Assert.IsNull(actual1.Messages);
            Assert.IsNull(actual2.Messages);
        }

        [TestMethod]
        public async Task should_return_fibonacci_number()
        {
            int number = 5;
            int expected = 5;

            var actual = await lemonWayWSConnector.ComputeFibonnaciAsync(number);

            Assert.AreEqual(expected, actual.Result);
        }

        [TestMethod]
        public async Task should_be_ignored_xml_attribute_when_convert_xml_string_to_json()
        {
            string xmlStr = AccessTestResource.GetTestResourceString("ignore_attribute_xml.txt");
            string expected = AccessTestResource.GetTestResourceString("ignore_attribute_json.txt");
           
            var actual = await lemonWayWSConnector.XmlToJsonAsync(xmlStr);

            Assert.AreEqual(expected, actual.Result);
        }
    }
}
