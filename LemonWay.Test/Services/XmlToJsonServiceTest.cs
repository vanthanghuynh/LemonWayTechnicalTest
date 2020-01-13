using LemonWay.Service;
using LemonWay.TestBase;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LemonWay.Test.Services
{
    [TestClass]
    public class XmlToJsonServiceTest
    {
        private XmlToJsonService _xmlToJsonService;

        [TestInitialize]
        public void SetUp()
        {
            _xmlToJsonService = new XmlToJsonService();
        }

        private void ExecuteTest(string xmlFileName, string jsonFileName)
        {
            string xmlStr = AccessTestResource.GetTestResourceString(xmlFileName);
            string expected = AccessTestResource.GetTestResourceString(jsonFileName);

            string actual = _xmlToJsonService.XmlToJson(xmlStr);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void should_convert_xml_string_to_json_1()
        {
            ExecuteTest("first_test_xml.txt", "first_test_json.txt");
        }

        [TestMethod]
        public void should_convert_xml_string_to_json_2()
        {
            ExecuteTest("second_test_xml.txt", "second_test_json.txt");
        }

        [TestMethod]
        public void should_return_error_message_when_passing_xml_string_invalid()
        {
            ExecuteTest("invalid_input_xml.txt", "invalid_input_json.txt");
        }

        [TestMethod]
        public void should_be_ignored_xml_attribute_when_converting()
        {
            ExecuteTest("ignore_attribute_xml.txt", "ignore_attribute_json.txt");
        }
    }
}
