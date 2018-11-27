using System;
using Xunit;

namespace testingapplication {
    public class GridTest_EvenGrid {

        [Fact]
        public void ShouldThrowException () {
            Action testCode = () => { new Grid(3); };
            var ex = Record.Exception(testCode);
            Assert.IsType<UnevenGridException>(ex);
        }
    }
}