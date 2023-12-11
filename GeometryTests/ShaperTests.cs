namespace Tools.GeometryTests;

[TestClass]
public class ShaperTests : Tests
{
	/// <summary>
	/// Instance of <see cref="Shaper"/>.
	/// </summary>
	private readonly Shaper _shaper = new();

	/// <summary>
	/// Test shape arguments implementation.
	/// </summary>
	internal class TestArgs : IArgs { }

	#region Count

	[TestMethod]
	public void TypeNames_Count_2returned()
	{
		const int expected = 2;

		var actual = _shaper.TypeNames.Count();

		Assert.AreEqual(expected, actual, FailMessage, 
			nameof(Shaper.TypeNames), expected, actual);
	}

	#endregion

	#region Triangle

	[TestMethod]
	public void GetShape_TriangleArgs_2d2and3d44and5d71_TriangleReturned()
	{
		const double sideA = 2.2;
		const double sideB = 3.44;
		const double sideC = 5.71;

		var args = new TriangleArgs(sideA, sideB, sideC);
		var shape = _shaper.GetShape(args);

		var expected = typeof(Triangle);
		var actual = shape.GetType();

		Assert.AreEqual(expected, actual, FailMessage,
			nameof(Type), expected, actual);
	}

	[TestMethod]
	public void Area_TriangleArgs_45_876d850Returned()
	{
		const double side = 45;
		const double expected = 876.850;

		var args = new TriangleArgs(side, side, side);
		var shape = _shaper.GetShape(args);
		var actual = shape.Area;

		Assert.AreEqual(expected, actual, Tolerance, 
			FailMessageF4, nameof(IShape.Area), expected, actual);
	}

	[TestMethod]
	public void Area_TriangleArgs_3and4and5_6Returned()
	{
		const double sideA = 3;
		const double sideB = 4;
		const double sideC = 5;
		const double expected = 6;

		var args = new TriangleArgs(sideA, sideB, sideC);
		var shape = _shaper.GetShape(args);
		var actual = shape.Area;

		Assert.AreEqual(expected, actual, Tolerance,
			FailMessageF4, nameof(IShape.Area), expected, actual);
	}

	[TestMethod]
	public void Area_TriangleArgs_77d45and77d45and81d033_2674d37Returned()
	{
		const double sideA = 77.45;
		const double sideB = 77.45;
		const double sideC = 81.033;
		const double expected = 2674.37;

		var args = new TriangleArgs(sideA, sideB, sideC);
		var shape = _shaper.GetShape(args);
		var actual = shape.Area;

		Assert.AreEqual(expected, actual, Tolerance,
			FailMessageF4, nameof(IShape.Area), expected, actual);
	}

	[TestMethod]
	public void Area_TriangleArgs_145and154and112_7737d363Returned()
	{
		const double sideA = 145;
		const double sideB = 154;
		const double sideC = 112;
		const double expected = 7737.363;

		var args = new TriangleArgs(sideA, sideB, sideC);
		var shape = _shaper.GetShape(args);
		var actual = shape.Area;

		Assert.AreEqual(expected, actual, Tolerance,
			FailMessageF4, nameof(IShape.Area), expected, actual);
	}

	[TestMethod]
	public void Perimeter_TriangleArgs_14d55and15d24and11d203_40d993Returned()
	{
		const double sideA = 14.55;
		const double sideB = 15.24;
		const double sideC = 11.203;
		const double expected = 40.993;

		var args = new TriangleArgs(sideA, sideB, sideC);
		var shape = _shaper.GetShape(args);
		var actual = shape.Perimeter;

		Assert.AreEqual(expected, actual, Tolerance,
			FailMessageF4, nameof(IShape.Perimeter), expected, actual);
	}

	#endregion

	#region Circle

	[TestMethod]
	public void GetShape_CircleArgs_17d446_CircleReturned()
	{
		const double radius = 17.446;

		var args = new CircleArgs(radius);
		var shape = _shaper.GetShape(args);

		var expected = typeof(Circle);
		var actual = shape.GetType();

		Assert.AreEqual(expected, actual, FailMessage,
			nameof(Type), expected, actual);
	}

	[TestMethod]
	public void Area_CircleArgs_156d9833_77420d64Returned()
	{
		const double radius = 156.9833;
		const double expected = 77420.64;

		var args = new CircleArgs(radius);
		var shape = _shaper.GetShape(args);
		var actual = shape.Area;

		Assert.AreEqual(expected, actual, Tolerance,
			FailMessageF4, nameof(IShape.Area), expected, actual);
	}

	[TestMethod]
	public void Perimeter_CircleArgs_77_483d805Returned()
	{
		const double radius = 77;
		const double expected = 483.805;

		var args = new CircleArgs(radius);
		var shape = _shaper.GetShape(args);

		var actual = shape.Perimeter;

		Assert.AreEqual(expected, actual, Tolerance,
			FailMessageF4, nameof(IShape.Perimeter), expected, actual);
	}

	#endregion

	#region Default

	[TestMethod]
	public void GetShape_TestArgs_DefaultShapeReturned()
	{
		var args = new TestArgs();
		var shape = _shaper.GetShape(args);

		var expected = typeof(DefaultShape);
		var actual = shape.GetType();

		Assert.AreEqual(expected, actual, FailMessage,
			nameof(Type), expected, actual);
	}

	#endregion

	#region Exception

	[TestMethod]
	[ExpectedException(typeof(ArgumentException), NoExceptionMessage)]
	public void Shape_TriangleArgs_0and5and6_Exception()
	{
		const double sideA = 0;
		const double sideB = 5;
		const double sideC = 6;

		var args = new TriangleArgs(sideA, sideB, sideC);

		var _ = _shaper.GetShape(args);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentException), NoExceptionMessage)]
	public void Shape_TriangleArgs_0d3andMin5and1_Exception()
	{
		const double sideA = 0.3;
		const double sideB = -5;
		const double sideC = 1;

		var args = new TriangleArgs(sideA, sideB, sideC);

		var _ = _shaper.GetShape(args);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentException), NoExceptionMessage)]
	public void Shape_CircleArgs_Min11d78_Exception()
	{
		const double radius = -11.78;

		var args = new CircleArgs(radius);

		var _ = _shaper.GetShape(args);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentException), NoExceptionMessage)]
	public void Shape_CircleArgs_0_Exception()
	{
		const double radius = 1;

		var args = new CircleArgs(radius);

		var _ = _shaper.GetShape(args);
	}

	#endregion
}
