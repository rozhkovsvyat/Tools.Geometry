namespace Tools.GeometryTests;

[TestClass]
public class CircleArgsTests : Tests
{
	#region Recipe

	[TestMethod]
	public void Recipe_CircleArgs_15_IsCircle()
	{
		const double radius = 15;

		var args = new CircleArgs(radius);
		var actual = CircleArgs.Recipe.Invoke(args).GetType();
		var expected = typeof(Circle);

		Assert.AreEqual(expected, actual, FailMessage,
			nameof(Type), expected, actual);
	}

	[TestMethod]
	public void Recipe_TriangleArgs_3and5and6_IsDefaultShape()
	{
		const double sideA = 3;
		const double sideB = 5;
		const double sideC = 6;

		var args = new TriangleArgs(sideA, sideB, sideC);
		var actual = CircleArgs.Recipe.Invoke(args).GetType();
		var expected = typeof(DefaultShape);

		Assert.AreEqual(expected, actual, FailMessage, 
			nameof(Type), expected, actual);
	}

	#endregion
}
