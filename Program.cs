// See https://aka.ms/new-console-template for more 
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Functions Sorular

static void StartProject(string state , List<Dictionary<String, String>> Data) 
{
    List<Dictionary<String, String>> list = new List<Dictionary<String, String>>();
    list = Data;

    switch (state)
    {
        //Home
        case "home":
            Console.WriteLine("");
            Console.WriteLine("1- Add Student");
            Console.WriteLine("2- Print Students List");
            Console.WriteLine("3- Exit");
            Console.WriteLine("");
            Console.WriteLine("Please choose one of the options above: ");

            string port = Console.ReadLine();
            StartProject(port , list);
            break;

        //Yeni Ekleme
        case "1":
            Console.WriteLine("---------- Yeni Ekleme ---------");

            Console.WriteLine("Student's name :");
            string name = Console.ReadLine();

            Console.WriteLine("Student's point :");
            string points = Console.ReadLine();

            Student student = new Student(name , points);
            Data.Add(student.get());
            StartProject("home", list);

            break;

        // Yazdır
        case "2":
            Console.WriteLine("--------------------  List -------------------");

            for (int i = 0; i <= (Data.Count - 1); i++)
            {

                string State = float.Parse(Data[i]["points"]) < 60 ? "Failed" : "Passed";
                Console.WriteLine("Name: {0} , Point: {1}, State: {2}", Data[i]["name"], Data[i]["points"], State);
                Console.WriteLine("--------------------------------------------");
            }
            StartProject("home", list);
            break;

        case "3":
            Console.WriteLine("Signed out");

            break;
        default:
            Console.WriteLine("NOT: Please make sure to check");
            StartProject("home", list);
            break;
    }
}
Console.WriteLine("----------------------------------------------");
Console.WriteLine("    Welcome to the Student Registration List  ");
Console.WriteLine("----------------------------------------------");
string start = "home";
List<Dictionary<String, String>>  list = new List<Dictionary<String, String>>();

StartProject(start, list);


// Class

class Student
{
    public string name;
    public string points;


    public  Student(string name, string points)
    {
        this.name = name;
        this.points = points;

    }

    public Dictionary<String, String> get()
    {
        Dictionary<String,String> data = new Dictionary<String, String>();
        data.Add("name",name);
        data.Add("points", points);

        return (data);
    }
}

