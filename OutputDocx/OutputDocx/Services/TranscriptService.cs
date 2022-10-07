/// <summary>
/// 學生成績表
/// </summary>
public class TranscriptService : IDocx<Transcript>
{
    public Content ToContent(List<Transcript> source)
    {
        var model = new DataModel<IEnumerable<Transcript>>();
        model.Date = DateTime.Now.Date;
        model.ObjectData = new List<Transcript>();
        model.ObjectData = source;


        Content _fillContent = new Content();
        List<IContentItem> fields = null;
        TableContent tableContent = null;

        //FieldContent → 代換一般內容(RTF)
        fields = new List<IContentItem>();
        fields.Add(new FieldContent("@Date", $"{model.Date.Year - 1911} 年 {model.Date.Month} 月 {model.Date.Day} 日"));
        //TableContent → 代換表格並依照資料數自動產生列

        //設定表格中要代換的RTF
        tableContent = new TableContent("@row1");
        foreach (var item in model.ObjectData)
        {
            tableContent.AddRow(new FieldContent("@Name", item.Name),
                                new FieldContent("@Mandarin", item.Mandarin?.ToString()),
                                new FieldContent("@English", item.English?.ToString()),
                                new FieldContent("@Math", item.Math?.ToString()));
        }

        //最後把要代換的所有資料丟到Content內
        fields.ForEach(f => _fillContent.Fields.Add(f as FieldContent)); //一般內容丟Fields
        _fillContent.Tables.Add(tableContent); //表格丟Tables
        return _fillContent;
    }
}