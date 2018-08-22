using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//this application is used for self training in edX course DEV204.2x
//the class files are: Student, Teacher, UProgram, Degree and Course
/*SPECS for Main:
     Instantiate a UProgram object called Information Technology.
    Instantiate three Student objects.
    Instantiate a Course object called Programming with C#.
    Add your three students to this Course object.
    Instantiate at least one Teacher object.
    Add that Teacher object to your Course object.
    Instantiate a Degree object, such as Bachelor.
    Add your Course object to the Degree object.
    Instantiate a UProgram object called Information Technology.
    Add the Degree object to the UProgram object.

    Using Console.WriteLine statements, output the following information to the console window:
        The name of the program and the degree it contains
        The name of the course in the degree
        The count of the number of students in the course.
 */
namespace university_program
{
    class Program
    {
        static void Main(string[] args)
        {
            UProgram infoTech = new UProgram();
            //infoTech object must have Name string "Information Technology", length int Months = 60, degree string "Bachelor"
            Student student1 = new Student();
            //Student1 and similar objects must have Name and Surname String, DOB DateTime, Address and loads other details if required
            //Student has a mandatory counter, I'll call it "enrolled_people"
            //Interesting to instantiate students with missing data
            Course progrC = new Course();
            //ProgrC object must have at least a Name string "Programming with C#"
            Teacher teacher1 = new Teacher();
            //teacher1 has a name and surname string
            Degree degree = new Degree();
            //degree must have the value Name string "Bachelor"

            Console.WriteLine($"The programme is called {infoTech.Name}");
            Console.WriteLine($"{infoTech.Name} contains a {degree.Name} degree");
            Console.WriteLine($"This degree contains a few courses and one of them is {progrC.Name}");
            Console.WriteLine($"By now there are only {Student.enrolled_people} enrolled in {progrC.Name}");



        }
    }
}
