# Tools : Geometry

<img align="right" width="100" height="100" src="https://github.com/rozhkovsvyat/Tools.Geometry/assets/71471748/8b327452-8d36-43c8-afca-6c34e76450de">

**#v1.0.1 #net7.0.10**

Geometry working toolkit

> :eye_speech_bubble: https://www.nuget.org/packages/RozhkovSvyat.Tools.Geometry/

Provides the ability to calculate shape properties:
* **Triangle** -- perimeter, area based on three sides (using different formulas according to the type of triangle)
* **Circle** -- perimeter, area based on radius

---

### SHAPER

* Provides shape instances according to the given arguments using [RecipeFactory](https://github.com/rozhkovsvyat/Tools.RecipeFactory)
* Populates the factory with all shape implementations from the same or a specific assembly when created
* Does not know the returned shape specific type

---

### SHAPES

* **IShape** -- interface providing shape properties, default implementation with zero properties
* **Triangle, Circle** -- shape implementations containing static and non-static calculation methods

---

### SHAPE ARGS

* **IArgs, IShapeArgs** -- interfaces providing shape arguments and a static recipe (func that returns a new shape)
* **TriangleArgs, CircleArgs** -- implementations of shape arguments

---

### GEOMETRY TESTS

* **ShaperTests, ShapesTests, ShapeArgsTests** -- unit test classes based on [MSTest](https://www.nuget.org/packages/MSTest)
* **Tests** -- abstract class containing testing constants
