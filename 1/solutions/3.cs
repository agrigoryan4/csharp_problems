//3․ Գրել ծրագրային կոդ, որը էկրան դուրս կբերի 3-23 միջակայքի բոլոր զույգ թվերը
using System;
class myProgram {
    static void Main() {
        int i = 3;
        while (i <= 23) {
            if (i % 2 == 0) {
                Console.Write(i + "\t");
            }
            i++;
        }
    }
}