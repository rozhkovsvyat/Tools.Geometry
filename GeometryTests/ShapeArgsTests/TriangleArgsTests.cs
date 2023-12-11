namespace Tools.GeometryTests;

[TestClass]
public class TriangleArgsTests
{
	#region Recipe

	[TestMethod]
	public void Recipe_TriangleArgs_3and5and6_IsTriangle()
	{
		const double sideA = 3;
		const double sideB = 5;
		const double sideC = 6;

		var expected = typeof(Triangle);
		IArgs args = new TriangleArgs(sideA, sideB, sideC);
		var actual = TriangleArgs.Recipe.Invoke(args).GetType();

		Assert.AreEqual(expected, actual);
	}

	[TestMethod]
	public void Recipe_CircleArgs_15_IsDefaultShape()
	{
		const double radius = 15;

		var expected = typeof(DefaultShape);
		IArgs args = new CircleArgs(radius);
		var actual = TriangleArgs.Recipe.Invoke(args).GetType();

		Assert.AreEqual(expected, actual);
	}

	#endregion
}
