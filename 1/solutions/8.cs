//8․ Գրել ծրագրային կոդ, որը էկրան դուրս կբերի 4-44 միջակայքի բոլոր 3-ի պատիկ զույգ թվերը և դրանց գումարը
using System;
class myProgram {
    static void Main() {
        int sum = 0;
        for(int i = 4; i<= 44; i++) {
           if (i % 3 == 0 && i % 2 == 0) {
                Console.Write(i + "\t");
                sum += i;
            } 
        }
        Console.Write("\n");
        Console.WriteLine("sum = " + sum);
    }
}