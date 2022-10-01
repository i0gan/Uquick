using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;
using ILRuntime.Reflection;
using ILRuntime.CLR.Utils;

namespace ILRuntime.Runtime.Generated
{
    unsafe class System_Threading_Tasks_TaskScheduler_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(System.Threading.Tasks.TaskScheduler);
            args = new Type[]{typeof(System.EventHandler<System.Threading.Tasks.UnobservedTaskExceptionEventArgs>)};
            method = type.GetMethod("add_UnobservedTaskException", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_UnobservedTaskException_0);


        }


        static StackObject* add_UnobservedTaskException_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.EventHandler<System.Threading.Tasks.UnobservedTaskExceptionEventArgs> @value = (System.EventHandler<System.Threading.Tasks.UnobservedTaskExceptionEventArgs>)typeof(System.EventHandler<System.Threading.Tasks.UnobservedTaskExceptionEventArgs>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            System.Threading.Tasks.TaskScheduler.UnobservedTaskException += value;

            return __ret;
        }



    }
}
