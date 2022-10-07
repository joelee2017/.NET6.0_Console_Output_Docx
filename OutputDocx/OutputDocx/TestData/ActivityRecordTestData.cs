public static class ActivityRecordTestData
{  
    public static List<ActivityRecord> GetData()
    {
        var obj = new List<ActivityRecord>();
        obj.Add(new ActivityRecord { Activity = "111年大隊接力", Content = "大隊接力", Participant ="全班", Memo ="全校第二" });
        obj.Add(new ActivityRecord { Activity = "整潔環境比賽", Content = "校園清掃", Participant = "全班", Memo = "全校第一" });
        obj.Add(new ActivityRecord { Activity = "台北市速讀比賽", Content = "速讀比賽", Participant = "郭靖、令狐沖", Memo = "台北市第一名、第二名" });

        return obj;
    }
}
