class Parent {
    protected int field1; protected int field2;
}

class Child : Parent {
    protected int field3; protected int field4;
    public Child(int field1, int field2, int field3, int field4) {
        base.field1 = field1;
        base.field2 = field2;
        this.field3 = field3;
        this.field4 = field4;
    }
}
class Program {
  static void Main() {
    Child obj = new Child(7, 4, 2, 4);
  }
}