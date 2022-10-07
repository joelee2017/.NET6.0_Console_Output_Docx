public class DataModel<T>
{
    /// <summary>
    /// 資料日期
    /// </summary>
    public DateTime Date { get; set; }
    /// <summary>
    /// 類型資料
    /// </summary>
    public T? ObjectData { get; set; }
}

/// <summary>
/// 學生成績表
/// </summary>
public class Transcript
{
    /// <summary>
    /// 姓名
    /// </summary>
    public string? Name { get; set; }
    /// <summary>
    /// 國語
    /// </summary>
    public int? Mandarin { get; set; }
    /// <summary>
    /// 英語
    /// </summary>
    public int? English { get; set; }
    /// <summary>
    /// 數學
    /// </summary>
    public int? Math { get; set; }
}
/// <summary>
/// 個人資料
/// </summary>
public class Information
{
    /// <summary>
    /// 姓名
    /// </summary>
    public string? Name { get; set; }
    /// <summary>
    /// 編號
    /// </summary>
    public int? Number { get; set; }
    /// <summary>
    /// 身高
    /// </summary>
    public int? Height { get; set; }
    /// <summary>
    /// 體重
    /// </summary>
    public double? Weight { get; set; }
    /// <summary>
    /// 電話
    /// </summary>
    public string? Tel { get; set; }
    /// <summary>
    /// 手機
    /// </summary>
    public string? Phone { get; set; }
}
/// <summary>
/// 活動記錄
/// </summary>
public class ActivityRecord
{
    /// <summary>
    /// 活動
    /// </summary>
    public string? Activity { get; set; }
    /// <summary>
    /// 活動內容
    /// </summary>
    public string? Content { get; set; }
    /// <summary>
    /// 參予人
    /// </summary>
    public string? Participant { get; set; }
    /// <summary>
    /// 備註
    /// </summary>
    public string? Memo { get; set; }
}
