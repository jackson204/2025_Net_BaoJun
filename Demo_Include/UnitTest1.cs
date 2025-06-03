using Microsoft.EntityFrameworkCore;
using Xunit.Abstractions;

namespace Demo_Include;

public class UnitTest1
{
    private readonly ITestOutputHelper _testOutputHelper;

    public UnitTest1(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void Test_LazyLoading()
    {
        using var casinoCashContext = new CasinoCashContext();
        _testOutputHelper.WriteLine("====== 測試1：懶加載 ======");
        
        // 第一次查詢：獲取 Member
        var member = casinoCashContext.Members.First();
        _testOutputHelper.WriteLine($"Member ID: {member.Id}, DiscountSettingId: {member.DiscountSettingId}");
        
        // 第二次查詢：訪問 User 屬性時才會查詢關聯的 User
        var user = member.User;
      
    }

    [Fact]
    public void Test_EagerLoading_Include()
    {
        using var casinoCashContext = new CasinoCashContext();
        _testOutputHelper.WriteLine("====== 測試2：Include ======");
        
        // 使用 Include 進行預加載，只產生一次查詢
        var member = casinoCashContext.Members
            .Include(r => r.User)
            .First();
            
        var user = member.User;
    }

    [Fact]
    public void Test_Select_Projection語法與Test_Include_With_Select一樣()
    {
        using var casinoCashContext = new CasinoCashContext();
        _testOutputHelper.WriteLine("====== 測試3：Select投影 ======");
        
        // 使用 Select 只查詢需要的欄位
        var result = casinoCashContext.Members
            .Select(r => new { r.DiscountSettingId, r.User.Account })
            .First();
            
        
    }

    [Fact]
    public void Test_Include_With_Select()
    {
        using var casinoCashContext = new CasinoCashContext();
        _testOutputHelper.WriteLine("====== 測試4：Include + Select ======");
        
        // Include 在這裡是多餘的，因為 Select 會自動處理關聯
        var result = casinoCashContext.Members
            .Include(r => r.User)
            .Select(r => new { r.DiscountSettingId, r.User.Account })
            .First();
            
        
    }
}
