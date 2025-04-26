using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;

namespace 反射_Deom;

[Description("學生資訊")]
public class StudentInfo
{
    private string _studentNo; //字段 

    public StudentInfo()
    {
    }

    public StudentInfo(string nickName, int age)
    {
        NickName = nickName;
        Age = age;
    }

    public string Email { get; }

    public int Age { get; set; }

    public string NickName { get; set; }

    private int Id { get; set; } //属性 

    public void Run()
    {
        Console.WriteLine($"我是{NickName},我每天都要晨跑");
    }

    public void Run2(int age)
    
    {
        Console.WriteLine($"我是{NickName},我今年{age},我每天都要晨跑");
    }

    private string Run3(string nickName)
    {
        return $"我是{nickName},我是私有方法";
    }
    
    public int Run4(int age)
    
    {
        return age + 100;
    }

}
