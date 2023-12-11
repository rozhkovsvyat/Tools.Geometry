namespace Tools.GeometryTests;

[TestClass]
public class CircleTests
{
	/// <summary>
	/// Double comparison tolerance.
	/// </summary>
	private const float Tolerance = 0.01f;

	#region GetArea

	[TestMethod]
	public void GetArea_15_706d86returned()
	{
		const double radius = 15;
		const double expected = 706.86;

		var actual = Circle.GetArea(radius);

		Assert.AreEqual(expected, actual, Tolerance);
	}

	[TestMethod]
	public void GetArea_38d4_4632d47returned()
	{
		const double radius = 38.4;
		const double expected = 4632.47;

		var actual = Circle.GetArea(radius);

		Assert.AreEqual(expected, actual, Tolerance);
	}

	[TestMethod]
	public void GetArea_Area_15_AreEqual()
	{
		const double radius = 15;

		var circle = new Circle(radius);
		var expected = Circle.GetArea(radius);

		Assert.AreEqual(expected, circle.Area, Tolerance);
	}

	[TestMethod]
	public void GetArea_Area_38d4_AreEqual()
	{
		const double radius = 38.4;

		var circle = new Circle(radius);
		var expected = Circle.GetArea(radius);

		Assert.AreEqual(expected, circle.Area, Tolerance);
	}

	#endregion

	#region GetPerimeter

	[TestMethod]
	public void GetPerimeter_19d5_122d522returned()
	{
		const double radius = 19.5;
		const double expected = 122.522;

		var actual = Circle.GetPerimeter(radius);

		Assert.AreEqual(expected, actual, Tolerance);
	}

	[TestMethod]
	public void GetPerimeter_44_276d46returned()
	{
		const double radius = 44;
		const double expected = 276.46;

		var actual = Circle.GetPerimeter(radius);

		Assert.AreEqual(expected, actual, Tolerance);
	}

	[TestMethod]
	public void GetPerimeter_Perimeter_225d37_AreEqual()
	{
		const double radius = 225.37;

		var circle = new Circle(radius);
		var expected = Circle.GetPerimeter(radius);

		Assert.AreEqual(expected, circle.Perimeter, Tolerance);
	}

	[TestMethod]
	public void GetPerimeter_Perimeter_0d04_AreEqual()
	{
		const double radius = 0.04;

		var circle = new Circle(radius);
		var expected = Circle.GetPerimeter(radius);

		Assert.AreEqual(expected, circle.Perimeter, Tolerance);
	}

	#endregion

	#region Exception

	[TestMethod]
	[ExpectedException(typeof(ArgumentException), "Exception was not thrown.")]
	public void Circle_0_Exception()
	{
		const double radius = uint.MinValue;

		var _ = new Circle(radius);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentException), "Exception was not thrown.")]
	public void Circle_min5d4_Exception()
	{
		const double radius = -5.4;

		var _ = new Circle(radius);
	}

	#endregion
}
