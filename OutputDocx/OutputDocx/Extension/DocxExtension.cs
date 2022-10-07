/// <summary>
/// Docx 擴充工具
/// </summary>
public static class DocxExtension
{
    //儲存檔案
    public static void SaveFile(this Content fillContent,string outpath, string templatepath)
    {
        if (File.Exists(outpath))
        {
            File.Delete(outpath);
        }
        //複製 Template 檔案
        File.Copy(templatepath, outpath);

        //將Content丟給TemplateProcessor處理，SetRemoveContentControls = true表示要清除標籤內文字，如不要清除則設為false
        using (var outputDocument = new TemplateProcessor(outpath).SetRemoveContentControls(true))
        {
            outputDocument.FillContent(fillContent);
            outputDocument.SaveChanges(); //儲存變更檔案
        }
    }    
}