using System;
class HelloWorld {
  static void Main() {
      int start = 5, end = 100;
      for(int i = start; i <= end; i++) {
		bool parzTiv = true;
        for(int j = 2; j < i; j++) {
		    if(i % j == 0) parzTiv = false;
		}
		if(parzTiv) Console.Write(i+"\t");
      }
  }
}
