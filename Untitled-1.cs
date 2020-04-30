using System;

namespace VSCode_test {
    public class Something {
        private double someNumber {get;set;}
        private string someText {get;set;}
        private Something someNode {get;set;}

        public Something (double someNumber, string someText, Something
        someNode) {
            this.someNumber = someNumber;
            this.someText = someText;
            this.someNode = someNode;
        }

        public String toString() {
            return this.someNumber + "\n" + 
                    this.someText + "\n";
        }
    }
}