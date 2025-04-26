using System;

namespace ConsoleApplication2
{
    public class WithdrawalTimeRange
    {
        public int Id { get; set; } 
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
    }
}
