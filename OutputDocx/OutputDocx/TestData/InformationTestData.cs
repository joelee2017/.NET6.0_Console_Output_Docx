/// <summary>
/// 基金投資股票明細
/// </summary>
public static class InformationTestData
{
    public static List<Information> GetData()
    {
        var obj = new List<Information>();
        obj.Add(new Information { Name = "令孤沖", Number = 1, Height = 178, Weight = 70, Tel = "00-1234-5896", Phone = "0911-123456" });
        obj.Add(new Information { Name = "楊過", Number =2, Height = 176, Weight = 70, Tel = "00-1234-9854", Phone = "0911-234567" });
        obj.Add(new Information { Name = "郭靖", Number = 3, Height = 175, Weight = 75, Tel = "00-1234-7415", Phone = "0911-345678" });
        obj.Add(new Information { Name = "喬峰", Number = 4, Height = 185, Weight = 80, Tel = "00-1234-9845", Phone = "0911-456789" });
        obj.Add(new Information { Name = "掃地僧", Number = 5, Height = 165, Weight = 60, Tel = "00-1234-2256", Phone = "0911-456789" });
        return obj;
    }
}
