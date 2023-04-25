using Reflection_Task.Models;
using System.Reflection;


Type type = typeof(User);

User user = new User();
PropertyInfo propId = type.GetProperty("Id",BindingFlags.Instance | BindingFlags.NonPublic);
propId.SetValue(user, 5);
Console.WriteLine(propId.GetValue(user));

PropertyInfo propName = type.GetProperty("Name", BindingFlags.Instance | BindingFlags.NonPublic);
propName.SetValue(user, "Cosqun");
PropertyInfo propSurname = type.GetProperty("Surname", BindingFlags.Instance | BindingFlags.NonPublic);
propSurname.SetValue(user, "Salahov");

MethodInfo method = type.GetMethod("GetFullName");
method.Invoke(user, null);

PropertyInfo propAge = type.GetProperty("age", BindingFlags.Static | BindingFlags.NonPublic);
propAge.SetValue(null, 21);
Console.WriteLine(propAge.GetValue(null));


//PropertyInfo propAge = type.GetProperty("age",BindingFlags.Static| BindingFlags.NonPublic);
//MethodInfo metod1 = type.GetMethod("ChangeAge");
//metod1.Invoke(user,propAge);
//static void ChangeAge(PropertyInfo propAge)
//{
//    propAge.SetValue(null, 21);
//   Console.WriteLine(propAge.GetValue(null));
//}



