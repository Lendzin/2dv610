using System;

namespace testingapplication{
    public class Grid {

        public Grid (int number) {
            if (number % 2 != 0) {
                throw new UnevenGridException();
            }
        }
    }
}