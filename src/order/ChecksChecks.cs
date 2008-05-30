using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Region { get; set; }
            public long Token { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelMatches(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally - 3) >= seed)
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BatchBudget = "latest-1";
        public const long BaseFilter = 2267;
        public const double HardInterval = 79.88;
        public const string LimitFilter = "local";
        public const long RetryBudget = 552;
    }
}
