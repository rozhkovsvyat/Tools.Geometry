namespace Tools.Geometry;

/// <summary>
/// Provides shape properties.
/// </summary>
public interface IShape
{
	/// <summary>
	/// Shape perimeter.
	/// </summary>
	double Perimeter { get; }
	/// <summary>
	/// Shape area.
	/// </summary>
	double Area { get; }
}

/// <summary>
/// Default implementation of <see cref="IShape"/>.
/// </summary>
public class DefaultShape : IShape
{
	/// <inheritdoc/>
	public double Perimeter => uint.MinValue;
	/// <inheritdoc/>
	public double Area => uint.MinValue;
}
