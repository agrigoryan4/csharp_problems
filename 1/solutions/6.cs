//6․  Գրել ծրագրային կոդ, որը էկրան դուրս կբերի 4-44 միջակայքի այն 
// թվերի արտադրյալը, որոնք բաժանվում են 5-ի և թողնում են 4 մնացորդ։
using System;
class myProgram {
    static void Main() {
        long i = 4;
        long product = 1;
        while (i <= 44) {
            if (i % 5 == 4) {
                product *= i;
            }
            i++;
        }
        Console.WriteLine("product = " + product);
    }
}