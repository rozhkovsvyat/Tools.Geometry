using System.Net.Mail;

namespace Tools.GeometryTests;

[TestClass]
public class TriangleArgsTests : Tests
{
	#region Recipe

	[TestMethod]
	public void Recipe_TriangleArgs_3and5and6_IsTriangle()
	{
		const double sideA = 3;
		const double sideB = 5;
		const double sideC = 6;

		var args = new TriangleArgs(sideA, sideB, sideC);
		var actual = TriangleArgs.Recipe.Invoke(args).GetType();
		var expected = typeof(Triangle);

		Assert.AreEqual(expected, actual, FailMessage,
			nameof(Type), expected, actual);
	}

	[TestMethod]
	public void Recipe_CircleArgs_15_IsDefaultShape()
	{
		const double radius = 15;

		var args = new CircleArgs(radius);
		var actual = TriangleArgs.Recipe.Invoke(args).GetType();
		var expected = typeof(DefaultShape);

		Assert.AreEqual(expected, actual, FailMessage,
			nameof(Type), expected, actual);
	}

	#endregion
}
