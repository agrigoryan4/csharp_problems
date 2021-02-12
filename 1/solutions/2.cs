//2․ Գրել ծրագրային կոդ, որը կհաշվի 1-10 թվերի արտադրյալը։
using System;
class myProgram {
    static void Main() {
        int product = 1;
        for(int i = 1; i <= 10; i++) {
            product *= i;   
        }
        Console.WriteLine(product);
    }
}