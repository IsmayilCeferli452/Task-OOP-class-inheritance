


#region Practice

//using C_Task_OOP_class_inheritance;


////1)

//string name = "Anar";
//string surname = "Ceferov";
//int age = 24;

//Console.WriteLine($"{name} {surname} {age}");


////2)

//var student1 = new
//{
//    name = "Anar",
//    surname = "Ceferov",
//    age = "24"
//};

//var result = student1.name + " " + student1.surname + " " + student1.age;

//Console.WriteLine(result);


////3)


//StudentDatas student1 = new StudentDatas();

//student1.name = "Ismayil";
//student1.surname = "Ceferli";
//student1.age = 24;
//student1.address = "Ehmedli";

//Console.WriteLine(student1.name);

//var studentFullData = "Name:" + student1.name + " " + "Surname:" + student1.surname + " " + "Age:" + student1.age + " " + "Address:" + student1.address;

//Console.WriteLine(studentFullData);


////4)

//using C_Task_OOP_class_inheritance;

//StudentDatas student1 = new()
//{
//    name = "Ismayil",
//    surname = "Ceferli",
//    age = 24,
//    address = "Ehmedli",
//};

//var studentFullName = "Name:" + student1.name + " " + "Surname:" + student1.surname;

//Console.WriteLine(studentFullName);


////5) Default value-lar:

//using C_Task_OOP_class_inheritance;

//StudentDatas student2 = new()
//{
//    name = "Samir",
//    surname = "Qarayev",
//    age = 30,
//};

//Console.WriteLine("Name:" + student2.name + " " + "Surname:" + student2.surname + " " + "Age:" + student2.age + " " + "Address:" + student2.address);

//Console.WriteLine(student2.FullData());

////6) Methodlar:

//StudentDatas student1 = new()
//{
//    name = "Ismayil",
//    surname = "Ceferli",
//    age = 24,
//    address = "Ehmedli",
//};

//StudentDatas student2 = new()
//{
//    name = "Qurban",
//    surname = "Qurbanov",
//    age = 40,
//    address = "28 May",
//    phonenumber = "0501234567",
//};

//StudentDatas[] studentsArray = {student1, student2};


////a) FullData:

//foreach (StudentDatas student in studentsArray)
//{
//    Console.WriteLine(student.FullData());
//}

////b) If ile:

//foreach (StudentDatas student in studentsArray)
//{
//    if (student.name == "Qurban")
//    {
//        Console.WriteLine(student.FullData());
//    }
//}


////c) Hamisi biryerde:

//void ShowAll(StudentDatas[] students)
//{
//    foreach (StudentDatas student in students)
//    {
//        Console.WriteLine(student.FullData());
//    }
//}

//ShowAll(studentsArray);



////d) GetByAge Method:

//StudentDatas GetByAge(StudentDatas[] students, int age)
//{
//    StudentDatas result = new();

//    foreach(StudentDatas student in students)
//    {
//        if (student.age == age)
//        {
//            result = student;
//            break;
//        }
//    }
//    return result;
//}

//Console.WriteLine(GetByAge(studentsArray, 24).name);

//var result = GetByAge(studentsArray,24).FullData();

//Console.WriteLine(result);


////GetByAge2 method:

//StudentDatas GetByAge2(StudentDatas[] students, int age)
//{
//    return Array.Find(students, x => x.age == age);
//}

//var result1 = GetByAge2(studentsArray, 24);

//Console.WriteLine(result1.FullData());



#endregion