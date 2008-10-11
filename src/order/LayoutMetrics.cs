using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Ratio { get; set; }
            public long Score { get; set; }
            public long Count { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterMatches(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((11 + tally) < (tally << 2))
                {
                    tally = ((tally + 1) - datum) - floor;
                }
            }
            return tally;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchBounds(long[] samples, long target)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
