namespace RefactoringLab.Part02.Reports;

public abstract class ReportExporter
{
	public void Export(string reportData)
	{
		var rowData = Load();

		if (!Validate(rowData))
			throw new InvalidOperationException("Invalid data");

		var content = FormatReport(rowData);

		Save(reportData, content);
	}

	private List<string> Load() =>
	[
		"Id,Name",
		"1,Keyboard",
		"2,Mouse"
	];

	protected abstract string FormatReport(List<string> rowData);

	private bool Validate(List<string> rowData) =>
		rowData.Count > 1 && rowData[0].Length > 0;

	private void Save(string path, string content) =>
		File.WriteAllText(path, content);
}