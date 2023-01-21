using System;
using System.Collections.Generic;
using BOL;
using DAL;
Console.WriteLine("WELCOME TO GYANTECHNO SOLUTION");
ISTManager stm=new STManager();
// menu driven
bool status =true;
while(status)
{
    Console.WriteLine("choose options");
    Console.WriteLine("1. display all student");
    Console.WriteLine(" 2.  add students ");
    Console.WriteLine("3 delete");
    Console.WriteLine("choose options");
    switch(int.Parse(Console.ReadLine()))
    {
        case 1:
        {    Console.WriteLine("in aall");
             List<Student> allstudents=stm.GetAll();
             Console.WriteLine("in  loop");
             foreach(var std in allstudents)
             {  Console.WriteLine("iD:{0},name:{1},course:{2},fee:{3}",std.id,std.name,std.course,std.fee);

             }

        } break;

        case 2:
        {   var newstd = new Student()
            {
                id = 23,
                name = "sumit",
                course = "Dac",
                fee=120000,
                
            };
            stm.insert(newstd);

        }break;
        case 3:
            stm.delete(23);
        break;
        

    }
    
    
}

