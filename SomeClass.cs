using System;

namespace VSCode_test {
    public class Something : IComparable<Something> {
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
            return this.someText + " \\\\ " + 
                    this.someNumber;
        }

        public int CompareTo(Something other) {
            if(this.someText.Equals(other.someText)) {
                if(this.someNumber > other.someNumber) {
                    return 1;
                }
                else if (other.someNumber > this.someNumber) {
                    return -1;
                }
                else {
                    return 0;
                }
            }
            else if (StringGreaterThanComparison(this.someText, other.someText,0)) {
                return 1;
            }
            else {
                return -1;
            }
        }

        private bool StringGreaterThanComparison(String reference, String comparative, int index) {
            if(reference[index] > comparative[index])
                return true;
            else if(comparative[index] > reference[index])
                return false;
            else {
                ++index;
                if(reference.Length == index)
                    return false;
                else if (comparative.Length == index)
                    return true;
                else
                    return StringGreaterThanComparison(reference, comparative, index);
            }
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