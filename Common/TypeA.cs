using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    //Access Modifiers: C# keywords Indicate Accessibility Scope
    // 1. private
    // 2. private protected
    // 3. protected
    // 4. internal
    // 5. internal protected
    // 6.public

    //What can we write inside namespace
    // 1. Class
    // 2. Stuct
    // 3. Interface
    // 4. Enum

    // Access modifier inside the namespace:
    // 1. internal : accessable inside the same project
    // 2. public   : everywhere

    // Default Access modifier inside namespace is internal 

    // What can we write inside class or stuct?
    // 1. Attributes [Field - Member Variable]
    // 2. Properties [Full Property - Automatic Property- Special Property(Indexer)]
    // 3. Methods [Functions]
    // 4. Event

    // Access modifier inside the class?
    // 1. private
    // 2. private protected
    // 3. protected
    // 4. internal
    // 5. internal protected
    // 6.public

    // Access modifier inside the class?
    // 1. private => accessiable inside the same class only
    // 2. internal => accessiable inside the same project only
    // 3. public => accessiable everywhere

    //Default access modifier inside class or struct is private

    // What can we write inside interface
    // 1. Signature of methods [Return Type - Name - Parameter]
    // 2. Signamture Of Property
    // 3. Default Implemented Methods [C# 8.0 .NET Core 3.1]

    // Access modifier inside the interface?
    // All access modifiers except private unless for methods with default values

    //Default access modifier inside interface is [public]

    //No Access Modifier are allowed in Enums


    internal class TypeA
    {
        TypeB typeB = new TypeB(); //valid

        
        void fun1()
        {
            //typeB.num1 = 12; //invalid because num1 is private
            typeB.num2 = 1; //valid -> internal and in same project
            typeB.num3 = 2; //valid -> public
        }
    }
}
