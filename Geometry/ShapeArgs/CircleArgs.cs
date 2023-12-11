namespace Tools.Geometry;

/// <summary>
/// Contains <see cref="Circle"/> constructor arguments.
/// </summary>
public class CircleArgs : IShapeArgs
{
	#region IShapeArgs

	/// <inheritdoc/>
	public static Recipe<IShape, IArgs> Recipe 
		=> a => a is not CircleArgs args ? 
			new DefaultShape() : new Circle(args.Radius);

	#endregion

	/// <summary>
	/// Radius.
	/// </summary>
	public double Radius { get; }

	/// <summary>
	/// Constructor.
	/// </summary>
	/// <param name="radius">Circle radius.</param>
	public CircleArgs(double radius) => Radius = radius;
}
