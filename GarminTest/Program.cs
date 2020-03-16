using System;
using System.Diagnostics;
using System.Linq;
using Garmin.TrainingCenterDatabase.V2;

namespace GarminTest
{
    public class Program
    {
        private const string NS_GPX_TrainingCenterDatabase_v2 =
            "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2";

        static void Main()
        {
            var fileName = @"trainingCenterDbExample1.xml";

            Console.WriteLine("Loading example training center DB...");
            var tcdb = TrainingCenterDatabase.Load(fileName);

            Debug.Assert(tcdb.Activities.Activity.Any());
            Console.WriteLine($"{tcdb.Untyped}");
        }
    }
}
