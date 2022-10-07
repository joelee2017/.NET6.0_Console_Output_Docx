using DocumentFormat.OpenXml.Drawing.Charts;
/// <summary>
/// 基金淨資產總額明細
/// </summary>
public static class TranscriptTestData
{
    public static List<Transcript> GetData()
    {
        var obj = new List<Transcript>();
        obj.Add(new Transcript { Name = "令孤沖", Mandarin = 80, English = 90, Math = 100 });
        obj.Add(new Transcript { Name = "楊過", Mandarin = 75, English = 96, Math = 95 });
        obj.Add(new Transcript { Name = "郭靖", Mandarin = 60, English = 80, Math = 90 });
        obj.Add(new Transcript { Name = "喬峰", Mandarin = 40, English = 75, Math = 85 });
        obj.Add(new Transcript { Name = "掃地僧", Mandarin = 5, English = 5, Math = 5 });
        return obj;
    }
}