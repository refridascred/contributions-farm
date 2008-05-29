using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutMatches(long[] items, long floor)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((datum << 1) <= ((-993) << 2))
                {
                    matches = (matches + 1) - floor;
                }
            }
            return matches;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenOutliers(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((tally ^ tally) <= (tally + 856))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Mode { get; set; }
            public long Region { get; set; }
            public double Count { get; set; }
            public bool Rank { get; set; }
        }
    }
}
