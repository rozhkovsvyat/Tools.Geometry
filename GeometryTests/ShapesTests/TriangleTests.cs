namespace Tools.GeometryTests;

[TestClass]
public class TriangleTests : Tests
{
	#region GetArea [Right]

	[TestMethod]
	public void GetAreaRight_31and44_682returned()
	{
		const double legA = 31;
		const double legB = 44;
		const double expected = 682;

		var actual = Triangle.GetAreaRight(legA, legB);

		Assert.AreEqual(expected, actual, Tolerance, 
			FailMessageF4, nameof(IShape.Area), expected, actual);
	}

	[TestMethod]
	public void GetAreaRight_64d3and72d8_2340d52returned()
	{
		const double legA = 64.3;
		const double legB = 72.8;
		const double expected = 2340.52;

		var actual = Triangle.GetAreaRight(legA, legB);

		Assert.AreEqual(expected, actual, Tolerance, 
			FailMessageF4, nameof(IShape.Area), expected, actual);
	}

	[TestMethod]
	public void GetAreaRight_Area_64d3and72d8and97d13_AreEqual()
	{
		const double legA = 64.3;
		const double legB = 72.8;
		const double hippo = 97.13;

		var triangle = new Triangle(legA, legB, hippo);
		var actual = triangle.Area;
		var expected = Triangle.GetAreaRight(legA, legB);

		Assert.AreEqual(expected, actual, Tolerance,
			FailMessageF4, nameof(IShape.Area), expected, actual);
	}

	#endregion

	#region GetArea [Equilateral]

	[TestMethod]
	public void GetAreaEquilateral_27_315d666returned()
	{
		const double side = 27;
		const double expected = 315.666;

		var actual = Triangle.GetAreaEquilateral(side);

		Assert.AreEqual(expected, actual, Tolerance,
			FailMessageF4, nameof(IShape.Area), expected, actual);
	}

	[TestMethod]
	public void GetAreaEquilateral_61d33_1628d72returned()
	{
		const double side = 61.33;
		const double expected = 1628.72;

		var actual = Triangle.GetAreaEquilateral(side);

		Assert.AreEqual(expected, actual, Tolerance,
			FailMessageF4, nameof(IShape.Area), expected, actual);
	}

	[TestMethod]
	public void GetAreaEquilateral_Area_61d33_AreEqual()
	{
		const double side = 61.33;

		var triangle = new Triangle(side, side, side);
		var actual = triangle.Area;
		var expected = Triangle.GetAreaEquilateral(side);

		Assert.AreEqual(expected, actual, Tolerance,
			FailMessageF4, nameof(IShape.Area), expected, actual);
	}

	#endregion

	#region GetArea [Isosceles]

	[TestMethod]
	public void GetAreaIsosceles_14and3d547_24d629returned()
	{
		const double side = 14;
		const double bs = 3.547;
		const double expected = 24.629;

		var actual = Triangle.GetAreaIsosceles(side, bs);

		Assert.AreEqual(expected, actual, Tolerance,
			FailMessageF4, nameof(IShape.Area), expected, actual);
	}

	[TestMethod]
	public void GetAreaIsosceles_71d378and84d944_2436d4821returned()
	{
		const double side = 71.378;
		const double bs = 84.944;
		const double expected = 2436.4821;

		var actual = Triangle.GetAreaIsosceles(side, bs);

		Assert.AreEqual(expected, actual, Tolerance,
			FailMessageF4, nameof(IShape.Area), expected, actual);
	}

	[TestMethod]
	public void GetAreaIsosceles_Area_71d378and84d944_AreEqual()
	{
		const double side = 71.378;
		const double bs = 84.944;

		var triangle = new Triangle(side, bs, side);
		var actual = triangle.Area;
		var expected = Triangle.GetAreaIsosceles(side, bs);

		Assert.AreEqual(expected, actual, Tolerance,
			FailMessageF4, nameof(IShape.Area), expected, actual);
	}

	#endregion

	#region GetArea

	[TestMethod]
	public void GetArea_11and59and64_300d0799returned()
	{
		const double sideA = 11;
		const double sideB = 59;
		const double sideC = 64;
		const double pp = (sideA + sideB + sideC) / 2;
		const double expected = 300.0799;

		var actual = Triangle.GetArea(sideA, sideB, sideC, pp);

		Assert.AreEqual(expected, actual, Tolerance,
			FailMessageF4, nameof(IShape.Area), expected, actual);
	}

	[TestMethod]
	public void GetArea_0d341and0d228and0d15_0d0135returned()
	{
		const double sideA = 0.341;
		const double sideB = 0.228;
		const double sideC = 0.15;
		const double pp = (sideA + sideB + sideC) / 2;
		const double expected = 0.0135;

		var actual = Triangle.GetArea(sideA, sideB, sideC, pp);

		Assert.AreEqual(expected, actual, Tolerance,
			FailMessageF4, nameof(IShape.Area), expected, actual);
	}

	[TestMethod]
	public void GetArea_Area_0d341and0d228and0d15_AreEqual()
	{
		const double sideA = 0.341;
		const double sideB = 0.228;
		const double sideC = 0.15;
		const double pp = (sideA + sideB + sideC) / 2;

		var triangle = new Triangle(sideA, sideB, sideC);
		var actual = triangle.Area;
		var expected = Triangle.GetArea(sideA, sideB, sideC, pp);

		Assert.AreEqual(expected, actual, Tolerance,
			FailMessageF4, nameof(IShape.Area), expected, actual);
	}

	#endregion

	#region GetPerimeter

	[TestMethod]
	public void GetPerimeter_144d92and200d06and104d7662_449d7462returned()
	{
		const double sideA = 144.92;
		const double sideB = 200.06;
		const double sideC = 104.7662;
		const double expected = 449.7462;

		var actual = Triangle.GetPerimeter(sideA, sideB, sideC);

		Assert.AreEqual(expected, actual, Tolerance, FailMessageF4,
			nameof(IShape.Perimeter), expected, actual);
	}

	[TestMethod]
	public void GetPerimeter_0d44and0d31and0d7_1d45returned()
	{
		const double sideA = 0.44;
		const double sideB = 0.31;
		const double sideC = 0.7;
		const double expected = 1.45;

		var actual = Triangle.GetPerimeter(sideA, sideB, sideC);

		Assert.AreEqual(expected, actual, Tolerance, FailMessageF4,
			nameof(IShape.Area), expected, actual);
	}

	[TestMethod]
	public void GetPerimeter_Perimeter_71d4and82d66and67d5_AreEqual()
	{
		const double sideA = 71.4;
		const double sideB = 82.66;
		const double sideC = 67.5;

		var triangle = new Triangle(sideA, sideB, sideC);
		var actual = triangle.Perimeter;
		var expected = Triangle.GetPerimeter(sideA, sideB, sideC);

		Assert.AreEqual(expected, actual, Tolerance,
			FailMessageF4, nameof(IShape.Area), expected, actual);
	}

	[TestMethod]
	public void GetPerimeter_Perimeter_0d15and0d5and0d4_AreEqual()
	{
		const double sideA = 0.15;
		const double sideB = 0.5;
		const double sideC = 0.4;

		var triangle = new Triangle(sideA, sideB, sideC);
		var actual = triangle.Perimeter;
		var expected = Triangle.GetPerimeter(sideA, sideB, sideC);

		Assert.AreEqual(expected, actual, Tolerance, FailMessageF4,
			nameof(IShape.Area), expected, actual);
	}

	#endregion

	#region Exception

	[TestMethod]
	[ExpectedException(typeof(ArgumentException), NoExceptionMessage)]
	public void Triangle_2d43and0and1d71_Exception()
	{
		const double sideA = 2.43;
		const double sideB = uint.MinValue;
		const double sideC = 1.71;

		var _ = new Triangle(sideA, sideB, sideC);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentException), NoExceptionMessage)]
	public void Triangle_1andMin2d23and0d03_Exception()
	{
		const double sideA = 1;
		const double sideB = -2.23;
		const double sideC = 0.03;

		var _ = new Triangle(sideA, sideB, sideC);
	}

	#endregion

	#region IsRight

	[TestMethod]
	public void Triangle_3and4and5_IsRight()
	{
		const double sideA = 3;
		const double sideB = 4;
		const double sideC = 5;

		var triangle = new Triangle(sideA, sideB, sideC);
		var actual = triangle.IsRight;

		Assert.IsTrue(actual, FailMessage,
			nameof(Triangle.IsRight), true.ToString(), actual);
	}

	[TestMethod]
	public void Triangle_23d1and34d85and41d81067_IsRight()
	{
		const double sideA = 23.1;
		const double sideB = 34.85;
		const double sideC = 41.81067;

		var triangle = new Triangle(sideA, sideB, sideC);
		var actual = triangle.IsRight;

		Assert.IsTrue(actual, FailMessage, 
			nameof(Triangle.IsRight), true.ToString(), actual);
	}

	[TestMethod]
	public void Triangle_15_IsNotRight()
	{
		const double sideA = 15;
		const double sideB = 15;
		const double sideC = 15;

		var triangle = new Triangle(sideA, sideB, sideC);
		var actual = triangle.IsRight;

		Assert.IsFalse(actual, FailMessage,
			nameof(Triangle.IsRight), false.ToString(), actual);
	}

	#endregion

	#region IsEquilateral

	[TestMethod]
	public void Triangle_1_IsEquilateral()
	{
		const double sideA = 1;
		const double sideB = 1;
		const double sideC = 1;

		var triangle = new Triangle(sideA, sideB, sideC);
		var actual = triangle.IsEquilateral;

		Assert.IsTrue(actual, FailMessage,
			nameof(Triangle.IsEquilateral), true.ToString(), actual);
	}

	[TestMethod]
	public void Triangle_12d3_IsEquilateral()
	{
		const double sideA = 12.3;
		const double sideB = 12.3;
		const double sideC = 12.3;

		var triangle = new Triangle(sideA, sideB, sideC);
		var actual = triangle.IsEquilateral;

		Assert.IsTrue(actual, FailMessage,
			nameof(Triangle.IsEquilateral), true.ToString(), actual);
	}

	[TestMethod]
	public void Triangle_7and6d9and6d9_IsNotEquilateral()
	{
		const double sideA = 7;
		const double sideB = 6.9;
		const double sideC = 6.9;

		var triangle = new Triangle(sideA, sideB, sideC);
		var actual = triangle.IsEquilateral;

		Assert.IsFalse(actual, FailMessage, 
			nameof(Triangle.IsEquilateral), false.ToString(), actual);
	}

	#endregion

	#region IsIsosceles

	[TestMethod]
	public void Triangle_45d4and50d223and45d4_IsIsosceles()
	{
		const double sideA = 45.4;
		const double sideB = 50.223;
		const double sideC = 45.4;

		var triangle = new Triangle(sideA, sideB, sideC);
		var actual = triangle.IsIsosceles;

		Assert.IsTrue(actual, FailMessage,
			nameof(Triangle.IsIsosceles), true.ToString(), actual);
	}

	[TestMethod]
	public void Triangle_71d3_IsIsosceles()
	{
		const double sideA = 71.3;
		const double sideB = 71.3;
		const double sideC = 71.3;

		var triangle = new Triangle(sideA, sideB, sideC);
		var actual = triangle.IsIsosceles;

		Assert.IsTrue(actual, FailMessage,
			nameof(Triangle.IsIsosceles), true.ToString(), actual);
	}

	[TestMethod]
	public void Triangle_71d3and71d24and68d44_IsNotIsosceles()
	{
		const double sideA = 71.3;
		const double sideB = 71.24;
		const double sideC = 68.44;

		var triangle = new Triangle(sideA, sideB, sideC);
		var actual = triangle.IsIsosceles;

		Assert.IsFalse(actual, FailMessage,
			nameof(Triangle.IsIsosceles), false.ToString(), actual);
	}

	#endregion
}
