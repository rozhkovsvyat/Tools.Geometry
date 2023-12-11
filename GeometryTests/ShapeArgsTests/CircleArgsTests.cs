namespace Tools.GeometryTests;

[TestClass]
public class CircleArgsTests
{
	#region Recipe

	[TestMethod]
	public void Recipe_CircleArgs_15_IsCircle()
	{
		const double radius = 15;

		var expected = typeof(Circle);
		IArgs args = new CircleArgs(radius);
		var actual = CircleArgs.Recipe.Invoke(args).GetType();

		Assert.AreEqual(expected, actual);
	}

	[TestMethod]
	public void Recipe_TriangleArgs_3and5and6_IsDefaultShape()
	{
		const double sideA = 3;
		const double sideB = 5;
		const double sideC = 6;

		var expected = typeof(DefaultShape);
		IArgs args = new TriangleArgs(sideA, sideB, sideC);
		var actual = CircleArgs.Recipe.Invoke(args).GetType();

		Assert.AreEqual(expected, actual);
	}

	#endregion
}
