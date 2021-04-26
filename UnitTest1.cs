using System;
using Xunit;

namespace Project.tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var book=new Book("");
            book.AddGrade(51);
            book.AddGrade(50);
            book.AddGrade(49);

            var result=book.GetStatistics();

            Assert.Equal(51,result.Average,1);
            Assert.Equal(50,result.High,1);
            Assert.Equal(49,result.Low,1);
        }
    }
}
