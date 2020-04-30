using System;

namespace VSCode_test {
    public static class Principal {
        static void Main(String[] args) {
            Something algo = new Something(new Random().Next(),
            "aaa", new Something(10,"bb", null));

            Console.WriteLine($"{algo.toString()}");
        }
    }
}