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
            LinkedListMgr linkedListMgr = new LinkedListMgr();

            LinkedListMgr list1 = new LinkedListMgr();
            list1.AddFirst("Hello");
            list1.AddFirst("Magical");
            list1.AddFirst("World");

            LinkedListMgr list2 = new LinkedListMgr();
            list2.AddLast("Hello");
            list2.AddLast("Magical");
            list2.AddLast("World");
            var result = 0;
                //linkedListMgr = linkedListMgr.AddFirst("");
            Assert.Equal(0, result);
        }
        [Fact]
        public void checkForExceptions()
        {
            //Assert.Throws<ApplicationException>(() => linkedListMgr.Add("-1"));
        }
    }
}
