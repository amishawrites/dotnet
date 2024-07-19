#nullable enable
int thisCannotBeNull = 4;
// thisCannotBeNull = null; // compile error!
int? thisCouldBeNull = null;
Console.WriteLine(thisCouldBeNull);
Console.WriteLine(thisCouldBeNull.GetValueOrDefault());
thisCouldBeNull = 7;
Console.WriteLine(thisCouldBeNull);
Console.WriteLine(thisCouldBeNull.GetValueOrDefault());


// null-coalescing operator, ??
// result will be 3 if authorName?.Length is null
string? authorName = null;
var result = authorName?.Length ?? 3; 
Console.WriteLine(result);

// To enable the feature at the project level, add the following to your project file:
// <PropertyGroup>
//  <Nullable>enable</Nullable>
// </PropertyGroup>

// To disable the feature at the file level, add the following to the top of a code file:
// #nullable disable

// To enable the feature at the file level, add the following to the top of a code file:
// #nullable enable