//4․ Գրել ծրագրային կոդ, որը էկրան դուրս կբերի 3-23 միջակայքի բոլոր 3-ի պատիկ թվերը
using System;
class myProgram {
    static void Main() {
        int i = 3;
        while (i <= 23) {
            if (i % 3 == 0) {
                Console.Write(i + "\t");
            }
            i++;
        }
    }
}