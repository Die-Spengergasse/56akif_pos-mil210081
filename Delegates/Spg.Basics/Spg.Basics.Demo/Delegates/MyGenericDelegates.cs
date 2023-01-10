using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Basics.Demo.Delegates
{
    // public delegate bool MyFunc(Student s);

    // Generics Delegate
    // Functions
    public delegate TypeOut MyFunc<TypeIn1, TypeOut>(TypeIn1 param1);
    public delegate TypeOut MyFunc<TypeIn1, TypeIn2, TypeOut>(TypeIn1 param1, TypeIn2 param2);
    public delegate TypeOut MyFunc<TypeIn1, TypeIn2, TypeIn3, TypeOut>(TypeIn1 param1, TypeIn2 param2, TypeIn3 param3);
    // ...param 15

    // Actions
    public delegate void MyAction();
    public delegate void MyAction<TypeIn1>(TypeIn1 param1);
    public delegate void MyAction<TypeIn1, TypeIn2>(TypeIn1 param1, TypeIn2 param2);
    // ...param15

}
