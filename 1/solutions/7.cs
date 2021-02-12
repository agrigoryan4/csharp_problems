//7․ Գրել ծրագրային կոդ, որը էկրան դուրս կբերի 4-44 միջակայքի բոլոր 5-ի պատիկ կենտ թվերը և դրանք քանակց
using System;
class myProgram {
    static void Main() {
        int i = 4;
        int num = 0;
        while (i <= 44) {
            if (i % 5 == 0 && i % 2 == 1) {
                Console.Write(i + "\t");
                num++;
            }
            i++;
        }
        Console.Write("\n");
        Console.WriteLine(num + " numbers in total");
    }
}