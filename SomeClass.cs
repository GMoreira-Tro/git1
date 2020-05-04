using System;

namespace VSCode_test {
    public class Something {
        public double someNumber;
        public string someText {get;}
        private Something someNode {get;}

        public Something (double someNumber, string someText, Something
        someNode) {
            this.someNumber = someNumber;
            this.someText = someText;
            this.someNode = someNode;
        }

        public override String ToString() {
            return this.someNumber + "\n" + 
                    this.someText;
        }
    }

    public class AnotherClass: Attribute {
        public int MyProperty { get; set; }
        public int someNumber;
        private int MyInt;        
       
       private void SomeFunction() {
           MyInt = 1;
       }
    }
}