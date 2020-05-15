using System.Collections;
using System.Collections.Generic;

namespace VSCode_test
{
    public class MyEnumerable<E> : IEnumerable {
        public List<E> list = new List<E>();
        public E this[int index] 
        {
            get { return list[index]; }
        }
        
        public IEnumerator GetEnumerator() {
            return (list as IEnumerable).GetEnumerator();
        }

        public MyEnumerable() {}
    }
}