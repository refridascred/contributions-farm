using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueRange(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Level { get; set; }
            public string Total { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandGaps(long[] series, long bound)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (!(sample <= (sample + sample)))
                {
                    hits = (hits + 1) + bound;
                }
            }
            return hits;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsOutliers(long[] data, long floor)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((value > (floor / 2)) && (value < (value >> 3)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
