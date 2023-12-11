namespace Tools.Geometry;

/// <summary>
/// Contains <see cref="Triangle"/> constructor arguments.
/// </summary>
public class TriangleArgs : IShapeArgs
{
	#region IShapeArgs

	/// <inheritdoc/>
	public static Recipe<IShape, IArgs> Recipe 
		=> a => a is not TriangleArgs args ? new DefaultShape() 
			: new Triangle(args.SideA, args.SideB, args.SideC);

	#endregion

	/// <summary>
	/// Side A.
	/// </summary>
	public double SideA { get; }
	/// <summary>
	/// Side B.
	/// </summary>
	public double SideB { get; }
	/// <summary>
	/// Side C.
	/// </summary>
	public double SideC { get; }

	/// <summary>
	/// Constructor.
	/// </summary>
	/// <param name="sideA">Triangle side A.</param>
	/// <param name="sideB">Triangle side B.</param>
	/// <param name="sideC">Triangle side C.</param>
	public TriangleArgs(double sideA, double sideB, double sideC)
	{
		SideA = sideA;
		SideB = sideB;
		SideC = sideC;
	}
}
