//5․ Գրել ծրագրային կոդ, որը էկրան դուրս կբերի 4-44 միջակայքի բոլոր 4-ի պատիկ թվերի գումարը
using System;
class myProgram {
    static void Main() {
        int i = 4;
        int sum = 0;
        while (i <= 44) {
            if (i % 4 == 0) {
                sum += i;
            }
            i++;
        }
        Console.WriteLine("sum = " + sum);
    }
}