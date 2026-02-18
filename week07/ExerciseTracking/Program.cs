using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        DateTime date1 = new DateTime(2022, 11, 3);

        activities.Add(new Running(date1, 30, 3.0));
        activities.Add(new Cycling(date1, 30, 6.0));
        activities.Add(new Swimming(date1, 30, 20));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}