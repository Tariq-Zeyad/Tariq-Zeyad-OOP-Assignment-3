namespace RefactoringLab.Part02.Reports;

public class JsonReportExporter : ReportExporter

{
    protected override string FormatReport(List<string> rowData)
    {
        var headers = rowData[0].Split(',');
        var jsonObjects = new List<Dictionary<string, string>>();
        for (int i = 1; i < rowData.Count; i++)
        {
            var values = rowData[i].Split(',');
            var jsonObject = new Dictionary<string, string>();
            for (int j = 0; j < headers.Length; j++)
            {
                jsonObject[headers[j]] = values[j];
            }
            jsonObjects.Add(jsonObject);
        }
        return System.Text.Json.JsonSerializer.Serialize(jsonObjects, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
    }

}
