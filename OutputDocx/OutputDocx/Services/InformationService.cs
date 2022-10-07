/// <summary>
/// 個人資料
/// </summary>
public class InformationService: IDocx<Information>
{
    public Content ToContent(List<Information> source)
    {
        var model = new DataModel<IEnumerable<Information>>();
        model.Date = DateTime.Now.Date;
        model.ObjectData = new List<Information>();
        model.ObjectData = source;

        Content _fillContent = new Content();
        List<IContentItem> fields = null;
        TableContent tableContent = null;

        //FieldContent → 代換一般內容(RTF)
        fields = new List<IContentItem>();
        fields.Add(new FieldContent("@Date2", $"{model.Date.Year - 1911} 年 {model.Date.Month} 月 {model.Date.Day} 日"));
        //TableContent → 代換表格並依照資料數自動產生列

        //設定表格中要代換的RTF
        tableContent = new TableContent("@row2");
        foreach (var item in model.ObjectData)
        {
            tableContent.AddRow(new FieldContent("@Name", item.Name),
                                new FieldContent("@Number", item.Number?.ToString()),
                                new FieldContent("@Height", item.Height?.ToString()),
                                new FieldContent("@Weight", item.Weight?.ToString()),
                                new FieldContent("@Tel", item.Tel),
                                new FieldContent("@Phone", item.Phone));
        }

        //最後把要代換的所有資料丟到Content內
        fields.ForEach(f => _fillContent.Fields.Add(f as FieldContent)); //一般內容丟Fields
        _fillContent.Tables.Add(tableContent); //表格丟Tables
        return _fillContent;
    }
}
