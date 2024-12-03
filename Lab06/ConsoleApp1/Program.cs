using ConsoleApp1;

Person child = Person.NewlyBornChild;
child.FirstName = "Brian";
child.LastName = "Doe";

Person p1 = new Person();
p1.FirstName = "Jane";
p1.LastName = "Doe";

Person p2 = new Person();
p2.FirstName = "Eryko";
p2.LastName = "Meryko";

Person.Relate(p1, p2);



