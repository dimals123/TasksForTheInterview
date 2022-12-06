using System.Diagnostics;
using TasksForTheInterview;

const string COOKING_BREAKFAST = "CookingBreakfast";

LambdaMeter(COOKING_BREAKFAST, () => Breakfast.StartCooking());

void LambdaMeter(string label, Action act)
{
    var sw = new Stopwatch();
    sw.Start();
    act();
    sw.Stop();
    Console.WriteLine($"{label} : {sw.Elapsed}");
}