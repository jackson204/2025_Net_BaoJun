using System.Reflection;

namespace 擴展方法_Demo;

public static class DescriptionAttribute 
{
  
    public static string GetDescription(this Enum value)
    {
        var field = value.GetType().GetField(value.ToString(),BindingFlags.Instance|BindingFlags.Public | BindingFlags.Static);
        var attribute = field.GetCustomAttribute(typeof(System.ComponentModel.DescriptionAttribute)) as System.ComponentModel.DescriptionAttribute;
        return attribute?.Description ?? value.ToString();
    }
}
