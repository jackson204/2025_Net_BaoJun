using System.ComponentModel;
using System.Reflection;
using Xunit.Abstractions;

namespace 反射_Deom;

public class UnitTest1(ITestOutputHelper testOutputHelper)
{
    [Fact]
    public void 查公開的屬性()
    {
        var type = typeof(StudentInfo).GetProperties(BindingFlags.Public | BindingFlags.Instance);
        foreach (var info in type)
        {
            testOutputHelper.WriteLine($"Name {info.Name}");
        }
    }

    [Fact]
    public void 把屬性全查出來包含私有的()
    {
        var propertyInfos = typeof(StudentInfo).GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic);

        foreach (var info in propertyInfos)
        {
            testOutputHelper.WriteLine($"Name {info.Name}");
        }
    }

    [Fact]
    public void 取特定的屬性()
    {
        var type = typeof(StudentInfo);
        var info = type.GetProperty("Id", BindingFlags.Instance | BindingFlags.NonPublic);
        testOutputHelper.WriteLine($"Id {info.Name}");
    }

    [Fact]
    public void 使用反射建立物件()
    {
        var type = typeof(StudentInfo);
        var obj = Activator.CreateInstance(type, "小明", 18) as StudentInfo;
        testOutputHelper.WriteLine($"NickName {obj?.NickName}");
    }

    [Fact]
    public void 屬性塞值取值()
    {
        // var info = new StudentInfo();
        // info.Age = 19

        var type = typeof(StudentInfo);
        var instance = Activator.CreateInstance(type);
        var propertyInfo = type.GetProperty("Age");

        propertyInfo?.SetValue(instance, 19);
        var age = propertyInfo?.GetValue(instance);
        testOutputHelper.WriteLine($"Age {age}");
    }

    [Fact]
    public void 自段塞值取值()
    {
        var type = typeof(StudentInfo);
        var instance = Activator.CreateInstance(type);
        var fieldInfo = type.GetField("<Age>k__BackingField", BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic);
        fieldInfo?.SetValue(instance, 11);
        var age = fieldInfo?.GetValue(instance);
        testOutputHelper.WriteLine($"Age {age}");
    }

    [Fact]
    public void 操作建構式()
    {
        var type = typeof(StudentInfo);

        //get constructor() 
        var constructorInfos = type.GetConstructor(Type.EmptyTypes);

        //get constructor(string,int)
        var constructorInfos2 = type.GetConstructor([typeof(string), typeof(int)]);
        var invoke = constructorInfos2?.Invoke(["小明", 18]) as StudentInfo;
        testOutputHelper.WriteLine(invoke?.Age.ToString());
    }

    [Fact]
    public void 操作方法()
    {
        var type = typeof(StudentInfo);
        var methodInfos = type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
        foreach (var info in methodInfos)
        {
            testOutputHelper.WriteLine($"Name {info.Name}");
        }
    }

    [Fact]
    public void 操作方法2()
    {
        var type = typeof(StudentInfo);
        var methodInfo = type.GetMethod("Run2", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
        var instance = Activator.CreateInstance(type);
     
        var result = methodInfo?.Invoke(instance, new object?[]{2});
        //testOutputHelper.WriteLine($"result {result}");
    }

    [Fact]
    public void 獲取特性()
    {
        var type = typeof(StudentInfo);
        var descriptionAttribute = type.GetCustomAttribute<DescriptionAttribute>();
        var description = descriptionAttribute?.Description;
        testOutputHelper.WriteLine($"Description {description}");
    }
}
