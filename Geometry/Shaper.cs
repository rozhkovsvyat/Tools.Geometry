﻿namespace Tools.Geometry;

using Factory = RecipeFactory<IShape, IArgs>;

/// <summary>
/// Provides <see cref="IShape"/> instances according to the given <see cref="IArgs"/>.
/// </summary>
public class Shaper
{
	/// <summary>
	/// Private <see cref="IShape"/> factory.
	/// </summary>
	private readonly Factory _factory;

	/// <summary>
	/// Empty constructor.
	/// </summary>
	public Shaper()
	{
		_factory = new Factory(() => new DefaultShape());
		_factory.RequestBasePropRecipes<IArgs>
			(nameof(IShapeArgs.Recipe));
	}

	/// <summary>
	/// Provides <see cref="IShape"/> instance according to the given <see cref="IArgs"/>.
	/// </summary>
	/// <param name="args">Shape arguments</param>
	/// <returns>New instance of <see cref="IShape"/></returns>
	public IShape GetShape(IArgs args) 
		=> _factory.Get(args.GetType().Name, args);
}
