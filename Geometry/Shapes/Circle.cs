namespace Tools.Geometry;

/// <summary>
/// Contains circle properties and methods.
/// </summary>
public class Circle : IShape
{
	#region Static
	 
	/// <summary>
	/// Returns the area of a circle.
	/// </summary>
	/// <param name="radius">Radius.</param>
	/// <returns>Area result.</returns>
	public static double GetArea(double radius) 
		=> Math.PI * Math.Pow(radius, 2);

	/// <summary>
	/// Returns the perimeter of a circle.
	/// </summary>
	/// <param name="radius">Radius.</param>
	/// <returns>Perimeter result.</returns>
	public static double GetPerimeter(double radius) 
		=> 2 * Math.PI * radius;

	#endregion

	#region IShape

	/// <inheritdoc/>
	public double Perimeter 
		=> _perimeter ??= GetPerimeter(_radius);
	private double? _perimeter;

	/// <inheritdoc/>
	public double Area 
		=> _area ??= GetArea(_radius);
	private double? _area;

	#endregion

	/// <summary>
	/// Circle radius.
	/// </summary>
	private readonly double _radius;

	/// <summary>
	/// Constructor.
	/// </summary>
	/// <param name="radius">Circle radius.</param>
	/// <exception cref="ArgumentException"></exception>
	public Circle(double radius) 
		=> _radius = radius > 0 ? radius : throw new ArgumentException
			($"Input {nameof(radius)} is less than or equal to zero.");
}
