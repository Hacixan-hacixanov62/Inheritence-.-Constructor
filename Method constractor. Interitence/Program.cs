


using Method_constractor._Interitence;


//Person person = new()
//{
//    id = 1,
//    fullName = "Fatime Qayxanova",
//    age = 22,
//    position = "Student"
//};





//Person person = new(1, "Hacixan Hacixanov", 19, "Student");

//Console.WriteLine(person.fullName);

//Person person2 = new Person(); 

//Person person1 = new Person("Azerbaycan", "Turkiye");




//ShowAllPeople(allPeople);


//Person result = FindStudentByeId(people, 1);

//string response = $"Id: {result.id} Fullname: {result.fullName} Age: {result.age}";

//Console.WriteLine(response);

//if (result != null)
//{
//    string response = $" Id:{result.id}\n FullName:{result.fullName}\n Age:{result.age}";

//    Console.WriteLine(response);

//}
//else
//{
//    Console.WriteLine("Data notfound");

//}

//var result1 = result != null ? $"Id:{result.id} FullName:{result.fullName} Age:{result.age}" : "notfound";
//Console.WriteLine(result1);



//Person result = FindPersonByeId(people, 100);

//var allPeople = GetAllPerson(people);

//ShowPersonById(result);



    

Person[] GetAllPerson()
{

    Person person1 = new()
    {
        id = 1,
        fullName = "Ilqar Shiriyev",
        age = 26

    };

    Person person2 = new()
    {
        id = 2,
        fullName = "Behruz Agayev",
        age = 21

    };

    Person person3 = new()
    {
        id = 3,
        fullName = "Nurlan Umudov",
        age = 22

    };

    Person person4 = new()
    {
        id = 4,
        fullName = "Behruz Agayev",
        age = 21

    };

    Person[] people = { person1, person2, person3, person4 };

    return people;

}            // esaS METHOD
void ShowAllPeople(Person[] datas)
{
    foreach (var item in datas)
    {
        string response = $"Id: {item.id} FullName: {item.fullName} Age: {item.age}";
        Console.WriteLine(response);

    }


}   //eKRANDA GOSTEREN

//ShowAllPeople(GetAllPerson());    // Gostereni Cagirir  Esasi icine eleave eden.

Person FindPersonByeId(Person[] people,int id)  
{
    return people.FirstOrDefault(m => m.id == id); 
    
}  // Esas Method
void ShowPerson(Person person)
{

    if (person != null)
    {
        string response = $" Id:{person.id} FullName:{person.fullName} Age:{person.age}";

        Console.WriteLine(response);

    }
    else
    {
        Console.WriteLine("Data notfound");

    }

}                   // Esasi ekranda gosteren

//ShowPerson(FindPersonByeId(GetAllPerson(), 2));   // Gostereni Cagirir Esasi icine elave eden

Person[] GetPeopleByName(Person[] people ,string name)
{
    return people.Where(m => m.fullName == name).ToArray();         
}      



void ShowPeopleByName(Person[] datas)
{

    foreach (var item in datas)
    {
        string response = $"Id: {item.id} FullName: {item.fullName} Age: {item.age}";
        Console.WriteLine(response);

    }
}

//ShowPeopleByName(GetPeopleByName(GetAllPerson(), "Behruz Agayev"));






//Animal animal = new();
//animal.id = 5;
//animal.name = "Qartal";

//Console.WriteLine(animal.name);


//Bird bird = new()
//{
//    id = 1,
//    name = "Qaranqush",     
//    age = 1
//};

//Console.WriteLine(bird.name);

//bird.Sound();



//Fish fish = new();

//Animal animal = new("salam");






