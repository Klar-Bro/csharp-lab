using ConsoleApp1;

Animal animal = new Dog();
Console.WriteLine(animal.Sound);
animal.Move();

Dog dog = new Dog();
Console.WriteLine(dog.Sound);
dog.FetchBall();

Dog dog1 = new Dog();
dog1.Walk();

IWalkable walkableDog = new Dog();
walkableDog.Walk();

Cat cat = new Cat();
cat.Walk();

IWalkable walkableCat = new Cat();
walkableCat.Walk();

Animal[] animals = { new Cat(), new Dog(), new Salmon() };
foreach (Animal ani in animals)
{
    Console.WriteLine($"The {ani.GetType().Name} goes {ani.Sound}");
    animal.Move();

    if (ani is Mammal)
        (ani as Mammal).ProduceMilk();

    if (ani is Dog)
        (ani as Dog).FetchBall();

    if (ani is Cat)
        (ani as Cat).ThrowOfTheTable();

    if (ani is IWalkable)
        (ani as IWalkable).Walk();

    if (ani is ISwimmable)
        (ani as ISwimmable).Swim();
}