using CodingExamples.Data.Mgr;
using System;
using Xunit;

namespace CodingExamples.Tests
{
    public class StringCalcTests
    {
        StringCalcMgr calcMgr = new StringCalcMgr();


        [Fact]
        public void addEmptyStringExpectZero()
        {
            var result = calcMgr.Add("");
            Assert.Equal(0, result);
        }
        [Fact]
        public void addSingleNumberExpectThatNumber()
        {
            var result = calcMgr.Add("1");
            Assert.Equal(1, result);
        }
        [Fact]
        public void addTwoNumbersExpectSumOfThem()
        {
            var result = calcMgr.Add("1,2");
            Assert.Equal(3, result);
        }
        [Fact]
        public void addTwoLargeNumbersExpectSumOfThem()
        {
            var result = calcMgr.Add("10,30");
            Assert.Equal(40, result);
        }
        [Fact]
        public void addNewLineExpectZero()
        {
            var result = calcMgr.Add("\n");
            Assert.Equal(0, result);
        }
        [Fact]
        public void addNewLineBetweenTwoNumbersExpectItTreatedAsSeperator()
        {
            var result = calcMgr.Add("1\n2");
            Assert.Equal(3, result);
        }
        [Fact]
        public void addDifferentDelimiterExpectItUsedToParseTheSum()
        {
            var result = calcMgr.Add("//A\n1A2");
            Assert.Equal(3, result);
        }
        [Fact]
        public void addNegativeExpectException()
        {
            Assert.Throws<ApplicationException>(() => calcMgr.Add("-1"));
        }
        [Fact]
        public void addMultipleNegativeExpectException()
        {
            Assert.Throws<ApplicationException>(() => calcMgr.Add("-1,-2"));
        }
        [Fact]
        public void addNegativeAndPositiveExpectExceptionForOnlyTheNegative()
        {
            Assert.Throws<ApplicationException>(() => calcMgr.Add("-1,2"));
        }
        [Fact]
        public void addNumbersBiggerThan1000ExpectThatNumberIgnored()
        {
            var result = calcMgr.Add("2,1001");
            Assert.Equal(2, result);
        }
        [Fact]
        public void addDelimitersLongerThanOneCharacterExpectItStillAccepted()
        {
            var result = calcMgr.Add("//AAA\n1AAA2AAA3");
            Assert.Equal(6, result);
        }
        [Fact]
        public void addMultipleDelimitersExpectAllUsed()
        {
            var result = calcMgr.Add("//[A][b]\n1A2b3");
            Assert.Equal(6, result);
        }
    }
}
