namespace RefactoringLab.Part02.Reports;

public class CsvReportExporter : ReportExporter
{
    protected override string FormatReport(List<string> rowData)
    {
        return string.Join(Environment.NewLine, rowData);
    }

}
