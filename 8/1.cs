using System;

interface ImInterface {
    void printName();
    void printAddress();
}

class Person {
    public string name;
    public string surname;
    public string address;
    public Person(string name, string surname, string address) {
        this.name = name;
        this.surname = surname;
        this.address = address;
    }
    public void printName() {
        Console.WriteLine($"Name is: {name} {surname}");
    }
    public void printAddress() {
        Console.WriteLine($"Address is: {address}");
    }
    
}

class Program {
  static void Main() {
    Person me = new Person("Arman", "Grigoryan", "6th Ave, Seattle, WA");
    me.printName();
    me.printAddress();
  }
}