namespace Tools.GeometryTests;

[TestClass]
public abstract class Tests
{
	/// <summary>
	/// Double comparison tolerance.
	/// </summary>
	protected const float Tolerance = 0.01f;
	/// <summary>
	/// Floating point value comparison error message.
	/// </summary>
	protected const string FailMessageF4 = "\nExpected {0}: {1:F4}. Actual: {2:F4}";
	/// <summary>
	/// Comparison error message.
	/// </summary>
	protected const string FailMessage = "\nExpected {0}: {1}. Actual: {2}";
	/// <summary>
	/// Exception error message.
	/// </summary>
	protected const string NoExceptionMessage = "ㅤ\nException was not thrown.";
}
