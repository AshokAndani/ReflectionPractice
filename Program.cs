using System.Reflection;

namespace Reflections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // GetAllMembersAvailableInClass(typeof(Ashok));
            //GetAllMethods(typeof(Custom));
            //GetAllConstructors(typeof(Custom));
            InvokeAMethodwhichHasHighestParameters(2);
        }
        public static void InvokeAMethodwhichHasHighestParameters(int value)
        {
            List<object> paramss = new List<object>(); 
            var type = typeof(Ashok);
            MethodInfo invokingMethod = null;
            foreach(var method in type.GetMethods())
            {
                if(method.GetParameters().Length == value)
                {
                    invokingMethod = method;
                }
            }
            if (invokingMethod != null)
            {
                var obj = Activator.CreateInstance(type);

                invokingMethod.Invoke(obj, new string[]{"", ""});
            }
        }
        public static void GetAllConstructors(Type classType)
        {
            Console.WriteLine("All constructors with thier parameters defined in the class: ----------------->");
            var constructorInfos = classType.GetConstructors();
            foreach (var constructorInfo in constructorInfos)
            {
                Console.Write("ctorName: " + constructorInfo.Name + " Parameters: ");
                var parameterinfos = constructorInfo.GetParameters();
                foreach (var parameterInfo in parameterinfos)
                {
                    Console.Write(parameterInfo.Name + " [" + parameterInfo.ParameterType + "] ");
                }
                Console.WriteLine();
            }
        }
        public static void GetAllMethods(Type classType)
        {
            Console.WriteLine("All methods with thier parameters defined in the class: ----------------->");
            var methodInfos = classType.GetMethods();
            foreach (var methodInfo in methodInfos)
            {
                Console.Write("Method Name: " + methodInfo.Name + " ReturnType: ");

                var returnType = methodInfo.ReturnType;
                Console.Write(returnType + " Parameters: ");
                var parameterinfos = methodInfo.GetParameters();

                foreach (var parameterInfo in parameterinfos)
                {
                    Console.Write(parameterInfo.Name + " [" + parameterInfo.ParameterType + "] ");
                }
                Console.WriteLine();
            }
        }
        public static void GetAllMembersAvailableInClass(Type classType)
        {
            Console.WriteLine($"Class Name of Passed Object: {classType.FullName}");
            var members = classType.GetMembers();
            Console.WriteLine("All Members of the Passed class:------------------->");
            foreach ( var member in members )
            {
                Console.WriteLine(member.Name);
            }
        }
    }
}