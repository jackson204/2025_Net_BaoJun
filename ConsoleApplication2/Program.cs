using System;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Create a new instance of the DbContext
            
            var connectionString = "Server=localhost;Database=YourDatabase;User Id=sa;Password=YourStrong!Passw0rd";
            
            using (var context = new YourDbContext(connectionString))
            {
                var withdrawalTimeRange = new WithdrawalTimeRange
                {
                    //withdrawalTimeRange.StartTime is a TimeSpan
                    StartTime = new TimeSpan(9, 0, 0), // 9:00 AM
                    //withdrawalTimeRange.EndTime is a TimeSpan
                    EndTime = new TimeSpan(17, 0, 0)   // 5:00 PM
                };
                
                // Add the new entity to the context
                context.WithdrawalTimeRanges.Add(withdrawalTimeRange);
                // Save changes to the database
                context.SaveChanges();
            }
        }
    }
}
