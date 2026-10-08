namespace RefactoringLab.Part02.Reports;

public class TextReportExporter : ReportExporter
{
    protected override string FormatReport(List<string> rowData)
    {
        return string.Join(Environment.NewLine, rowData);
    }
}
