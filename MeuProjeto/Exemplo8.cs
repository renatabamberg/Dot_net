using System;

class MainClass {
    static void Main() {
        int num1 = 7;
        int num2 = 3;
        int num3 = 10;

        if (num1 > num2 && num3 == num1 + num2) {
            Console.WriteLine("num1 é maior que num2 e num3 é igual a num1 + num2.");
        } else {
            Console.WriteLine("Uma ou ambas as condições não são atendidas.");
        }
    }
}
