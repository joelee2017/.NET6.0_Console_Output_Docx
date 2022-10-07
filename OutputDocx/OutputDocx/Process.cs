/// <summary>
/// 資料處理過程
/// </summary>
public static class Process
{
    public static List<IContentItem> GetFundTotalAssetsDetail()
    => new TranscriptService()
        .ToContent(TranscriptTestData.GetData()).ToList();

    public static List<IContentItem> GetFundInvestmentStockDetail()
        => new InformationService()
            .ToContent(InformationTestData.GetData()).ToList();

    public static List<IContentItem> GetFundInvestmentBondsDetail()
        => new ActivityRecordService()
        .ToContent(ActivityRecordTestData.GetData()).ToList();
}