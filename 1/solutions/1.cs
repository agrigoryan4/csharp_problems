//1․ Գրել ծրագրային կոդ, որը կհաշվի 1-10 թվերի գումարը։
using System;
class myProgram {
    static void Main() {
        int sum = 0;
        for(int i = 1; i <= 10; i++) {
            sum += i;   
        }
        Console.WriteLine(sum);
    }
}