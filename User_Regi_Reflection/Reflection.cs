using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace User_Regi_Reflection
{
    class Reflection
    {
        public static void ReflectionTest()
        {
            Type type = typeof(Patterns);

            Console.WriteLine("Full Name : {0}", type.FullName);
            Console.WriteLine("Class Name : {0}", type.Name);
            Console.WriteLine("\n");
           
            
            Console.WriteLine("Methods in Patterns Class are :-");
            MethodInfo[] methods = type.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType.Name + " " + method.Name);
            }
            Console.WriteLine("\n");
                        
            
            Console.WriteLine("Constructors in Patterns Class are :- ");
            ConstructorInfo[] constructors = type.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }
        }
    }
}
