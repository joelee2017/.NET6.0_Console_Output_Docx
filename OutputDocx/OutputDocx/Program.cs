IConfiguration _config = Starup.Configuration().Build();

FileModel fileMdoel = _config.GetRequiredSection("File").Get<FileModel>();

string outpath = fileMdoel.OutPath;
string templatepath = fileMdoel.TemplatePath;
string templateFileName = templatepath + fileMdoel.TemplateName;
string pathFileName = outpath + fileMdoel.FileName;

Content fillContent = new(DataProcess().ToArray());

// 儲存檔案
fillContent.SaveFile(pathFileName, templateFileName);

Console.WriteLine("完成!!");

// 資料處理
static IEnumerable<IContentItem> DataProcess()
{
    List<IContentItem> ftad = Process.GetFundTotalAssetsDetail();

    List<IContentItem> fisd = Process.GetFundInvestmentStockDetail();

    List<IContentItem> fibd = Process.GetFundInvestmentBondsDetail();

    // 合併內容
    IEnumerable<IContentItem> outPutSource = ftad.Concat(fisd).Concat(fibd);
    return outPutSource;
}