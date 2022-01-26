using CodingExamples.Data.Mgr;
using System;
using Xunit;

namespace CodingExamples.Tests
{
    public class TestConstructor
    {
        LinkedListMgr list1 = new LinkedListMgr();
        LinkedListMgr list2 = new LinkedListMgr();

        public TestConstructor(LinkedListMgr list1, LinkedListMgr list2)
        {
            list1.AddFirst("Hello");
            list1.AddFirst("Magical");
            list1.AddFirst("World");


            list2.AddLast("Hello");
            list2.AddLast("Magical");
            list2.AddLast("World");

            this.list1 = list1;
            this.list2 = list2;
        }



    }
    public class LinkedListTests
    {
        LinkedListMgr linkedListMgr = new LinkedListMgr();


        [Fact]
        public void addFirstExpectCorrectOrder()
        {
            TestConstructor testConstructor = new TestConstructor(linkedListMgr, linkedListMgr);
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
