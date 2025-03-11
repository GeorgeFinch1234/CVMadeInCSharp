using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CV.Models;

namespace CV.Tests
{

    //unit tests for, bondary, equilvent
    //maybe do manualy or write test for integreation
    //maybe do black box acceptance testing

    [TestClass]
    public class ContactTest
    {
        Validation validator = new Validation();
        String TestString = "";
        [TestMethod]
       public void TestStingOptionalMaxBorder()
        {
            Assert.AreEqual("", validator.validateOptionalString(TestString.PadRight(50, 'a')));
        }
        [TestMethod]
        public void TestStingOptionalMaxBorderPlusOne()
        {
            Assert.AreEqual("input is to long", validator.validateOptionalString(TestString.PadRight(51, 'a')));
        }
        [TestMethod]
        public void TestStingOptionalMaxBorderMinusOne()
        {
            Assert.AreEqual("", validator.validateOptionalString(TestString.PadRight(49, 'a')));
        }
        [TestMethod]
        public void TestStingOptionalMinBorder()
        {
            Assert.AreEqual("", validator.validateOptionalString(""));
        }
        [TestMethod]
        public void TestStingOptionalMinBorderPlusOne()
        {
            Assert.AreEqual("", validator.validateOptionalString("a"));
        }

        [TestMethod]
        public void TestStingOptionlEquilventValid()
        {
            Assert.AreEqual("", validator.validateOptionalString( "a valid string"));
        }
        [TestMethod]
        public void TestStingOptionlEquilventInvalid()
        {
            Assert.AreEqual("only numbers, letter, dot and @ allowed",validator.validateOptionalString("this is invlaid*&654"));

        }
        //phone number
        [TestMethod]
        public void testPhoneNumberMaxBoundary()
        {
            Assert.AreEqual("", validator.validatePhoneNumber(TestString.PadRight(10, '1')));
        }
        [TestMethod]
        public void testPhoneNumberMaxBoundaryPlusOne()
        {
            Assert.AreEqual("must be between 9 and 10 digits.", validator.validatePhoneNumber("12345678901"));
        }
        [TestMethod]
        public void testPhoneNumberMaxBoundaryMinusOne()
        {
            Assert.AreEqual("", validator.validatePhoneNumber(TestString.PadRight(9, '1')));
        }
        [TestMethod]
        public void testPhoneNumberMinBoundary()
        {
            Assert.AreEqual("", validator.validatePhoneNumber(TestString.PadRight(9, '1')));
        }
        [TestMethod]
        public void testPhoneNumberMibBoundaryPlusOne()
        {
            Assert.AreEqual("", validator.validatePhoneNumber(TestString.PadRight(10, '1')));
        }
        [TestMethod]
        public void testPhoneNumberMinBoundaryMinusOne()
        {
            Assert.AreEqual("must be between 9 and 10 digits.", validator.validatePhoneNumber(TestString.PadRight(8, '1')));
        }
        [TestMethod]
        public void testPhoneNumberEquilventValid()
        {
            Assert.AreEqual("", validator.validatePhoneNumber(TestString.PadRight(10, '1')));
        }
        [TestMethod]
        public void testPhoneNumberEquilventInValid()
        {
            Assert.AreEqual("only numbers allowed", validator.validatePhoneNumber(TestString.PadRight(10, 'a')));
        }
        //mandioty String
        [TestMethod]
        public void testStringManditoryMin()
        {
            Assert.AreEqual("input is mandioty", validator.validateManditoryString(""));
        }
        [TestMethod]
        public void testStringManditoryMinPlusOne()
        {
            Assert.AreEqual("", validator.validateManditoryString("a"));
        }
        [TestMethod]
        public void TestStingManditoryMaxBorder()
        {
            Assert.AreEqual("", validator.validateManditoryString(TestString.PadRight(50, 'a')));
        }
        [TestMethod]
        public void TestStingManditoryMaxBorderPlusOne()
        {
            Assert.AreEqual("input is to long", validator.validateManditoryString(TestString.PadRight(51, 'a')));
        }
        [TestMethod]
        public void TestStingManditoryMaxBorderMinusOne()
        {
            Assert.AreEqual("", validator.validateManditoryString(TestString.PadRight(49, 'a')));
        }
       

        [TestMethod]
        public void TestStingManditoryEquilventValid()
        {
            Assert.AreEqual("", validator.validateManditoryString("a valid string"));
        }
        [TestMethod]
        public void TestStingManditoryEquilventInvalid()
        {
            Assert.AreEqual("only numbers, letter, dot and @ allowed", validator.validateManditoryString("this is invlaid*&654"));

        }
    }
}
