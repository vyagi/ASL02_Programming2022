//LINQ = language integrated queries

var heights = new []  { 169, 178, 190, 188, 183, 179, 178, 192, 156, 167, 176, 180, 191, 177 };
var persons = new[] {"Johnny Cash", "Elvis Presley", "James Hetfield", "Bono"};
//Old school:

// var max = heights[0];
//
// for (int i = 1; i < heights.Length; i++)
// {
//     if (heights[i] > max)
//     {
//         max = heights[i];
//     }
// }

//Console.WriteLine(max);

//Console.WriteLine(heights.Max());
//Console.WriteLine(heights.Min());
//Console.WriteLine(heights.Count());
//Console.WriteLine(heights.Average());
//Console.WriteLine(heights.Sum());

// Filtering -> Where

var tallPeople = heights.Where(x => x >= 178);
var oddHeights = heights.Where(x => x % 2 == 1);
var withTwoNames = persons.Where(x => x.Split(" ").Length == 2);

// Ordering -> OrderBy

var orderedHeights = heights.OrderBy(x => x);
var orderedPersons = persons.OrderBy(x => x);
var personsByNameLength = persons.OrderBy(x => x.Length);

var orderedHeightsDescending = heights.OrderByDescending(x => x);
var orderedPersonsDescending = persons.OrderByDescending(x => x);
var personsByNameLengthDescending = persons.OrderByDescending(x => x.Length);

// Projection -> Select
var ones = heights.Select(x => x % 10);
var highOrLow = heights.Select(x => x >= 178);
var numberOfNames = persons.Select(x => x.Split(" ").Length);


var combined = heights
    .Where(x => x >= 178)
    .Select(x => x % 10)
    .OrderByDescending(x => x)
    .Distinct();

Display(combined);


void Display<T>(IEnumerable<T> list) => list.ToList().ForEach(x=>Console.WriteLine(x));

