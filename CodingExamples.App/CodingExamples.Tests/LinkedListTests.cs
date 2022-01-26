using CodingExamples.Data.Class;
using CodingExamples.Data.Mgr;
using System;
using Xunit;

namespace CodingExamples.Tests
{
    public class LinkedListTests
    {
        LinkedListMgr linkedListMgr = new LinkedListMgr();

        [Fact]
        public void addFirstExpectCorrectOrder()
        {
            LinkedListMgr list = new LinkedListMgr();
            list.AddFirst("Hello");
            list.AddFirst("Magical");
            list.AddFirst("World");

            var result = list.ToList();
            Assert.Equal("World", result[0]);
        }
        [Fact]
        public void deleteFirstExpectCorrectOrder()
        {
            LinkedListMgr list = new LinkedListMgr();
            list.AddFirst("Hello");
            list.AddFirst("Magical");
            list.AddFirst("World");

            list.DeleteFirst();
            var result = list.ToList();
            Assert.Equal(2, result.Count);
            Assert.NotEqual("World", result[0]);
        }

        [Fact]
        public void addLastExpectCorrectOrder()
        {
            LinkedListMgr list = new LinkedListMgr();
            list.AddLast("Hello");
            list.AddLast("Magical");
            list.AddLast("World");

            var result = list.ToList();
            Assert.Equal("Hello", result[0]);
        }

        [Fact]
        public void deleteLastExpectCorrectOrder()
        {
            LinkedListMgr list = new LinkedListMgr();
            list.AddLast("Hello");
            list.AddLast("Magical");
            list.AddLast("World");

            var result = list.ToList();
            Assert.Equal(2, result.Count);
            Assert.Equal("Hello", result[0]);
        }

        [Fact]
        public void checkForExceptions()
        {
            //Assert.Throws<ApplicationException>(() => linkedListMgr.Add("-1"));
        }
    }
}
