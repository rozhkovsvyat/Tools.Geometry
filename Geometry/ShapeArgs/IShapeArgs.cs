namespace Tools.Geometry;

/// <summary>
/// Provides constructor arguments.
/// </summary>
public interface IArgs { }

/// <inheritdoc cref="IArgs"/>
/// <remarks>Provides a static <see cref="IShape"/> recipe (function that returns a new <see cref="IShape"/>).</remarks>
public interface IShapeArgs : IArgs
{
	/// <summary>
	/// Static <see cref="IShape"/> recipe.
	/// </summary>
	/// <returns>Function that returns a new <see cref="IShape"/>.</returns>
	public static abstract Recipe<IShape, IArgs> Recipe { get; }
}
