namespace Tools.Geometry;

/// <summary>
/// Contains triangle properties and methods.
/// </summary>
public class Triangle : IShape
{
	#region Static

	/// <inheritdoc cref="GetArea"/>
	/// <remarks>Used if the triangle is right.</remarks>
	/// <param name="legA">Leg A.</param>
	/// <param name="legB">Leg B.</param>
	public static double GetAreaRight(double legA, double legB)
		=> legA * legB * 0.5;

	/// <inheritdoc cref="GetArea"/>
	/// <remarks>Used if the triangle is equilateral.</remarks>
	/// <param name="side">Triangle side.</param>
	public static double GetAreaEquilateral(double side) 
		=> Math.Pow(side, 2) * Math.Sqrt(3) * 0.25;

	/// <inheritdoc cref="GetArea"/>
	/// <remarks>Used if the triangle is isosceles.</remarks>
	/// <param name="side">Triangle side.</param>
	/// <param name="bs">Triangle base.</param>
	public static double GetAreaIsosceles(double side, double bs)
		=> Math.Sqrt(Math.Pow(side, 2) - Math.Pow(bs, 2) * 0.25) * bs * 0.5;

	/// <summary>
	/// Returns the area of a triangle.
	/// </summary>
	/// <param name="sideA">Side A.</param>
	/// <param name="sideB">Side B.</param>
	/// <param name="sideC">Side C.</param>
	/// <param name="sp">Semi-perimeter of triangle.</param>
	/// <returns>Area result.</returns>
	public static double GetArea(double sideA, double sideB, double sideC, double sp)
		=> Math.Sqrt(sp * (sp - sideA) * (sp - sideB) * (sp - sideC));

	/// <summary>
	/// Returns the perimeter of a triangle.
	/// </summary>
	/// <param name="sideA">Side A.</param>
	/// <param name="sideB">Side B.</param>
	/// <param name="sideC">Side C.</param>
	/// <returns>Perimeter result.</returns>
	public static double GetPerimeter(double sideA, double sideB, double sideC) 
		=> sideA + sideB + sideC;

	#endregion

	#region IShape

	/// <inheritdoc/>
	public double Perimeter 
		=> _perimeter ??= GetPerimeter(_sideA, _sideB, _sideC);
	private double? _perimeter;

	/// <inheritdoc/>
	public double Area 
		=> _area ??= IsRight ? GetAreaRight(_sideA, _sideB) 
			: IsEquilateral ? GetAreaEquilateral(_sideA) 
			: IsIsosceles ? GetAreaIsosceles(_sideB, Math.Abs(_sideA - _sideB) < Tolerance ? _sideC : _sideA) 
			: GetArea(_sideA, _sideB, _sideC, Perimeter / 2);
	private double? _area;

	#endregion

	#region Flags

	/// <summary>
	/// A flag indicating that the triangle has a right angle.
	/// </summary>
	public bool IsRight => _isRight ??=
		Math.Abs(_sideC - Math.Sqrt(Math.Pow(_sideA, 2) + Math.Pow(_sideB, 2))) < Tolerance;
	private bool? _isRight;

	/// <summary>
	/// A flag indicating that a triangle has all sides equal.
	/// </summary>
	public bool IsEquilateral => _isEquilateral ??=
		Math.Abs(_sideA - _sideB) < Tolerance &&
		Math.Abs(_sideB - _sideC) < Tolerance;
	private bool? _isEquilateral;

	/// <summary>
	/// A flag indicating that a triangle has two equal sides.
	/// </summary>
	public bool IsIsosceles => _isIsosceles ??=
		Math.Abs(_sideA - _sideB) < Tolerance ||
		Math.Abs(_sideB - _sideC) < Tolerance ||
		Math.Abs(_sideC - _sideA) < Tolerance;
	private bool? _isIsosceles;

	#endregion

	/// <summary>
	/// Triangle side.
	/// </summary>
	private readonly double _sideA, _sideB, _sideC;

	/// <summary>
	/// Double comparison tolerance.
	/// </summary>
	private const float Tolerance = 0.05f;

	/// <summary>
	/// Constructor.
	/// </summary>
	/// <param name="sideA">Side A.</param>
	/// <param name="sideB">Side B.</param>
	/// <param name="sideC">Side C.</param>
	/// <exception cref="ArgumentException"></exception>
	public Triangle(double sideA, double sideB, double sideC)
	{
		var sides = new[] { sideA, sideB, sideC };

		if (sides.Any(side => side <= 0)) throw new ArgumentException
			($"One or more {nameof(sides)} are less than or equal to zero.");

		Array.Sort(sides);

		_sideA = sides[0];
		_sideB = sides[1];
		_sideC = sides[2];
	}
}
