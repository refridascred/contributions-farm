using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsOutliers(long[] values, long origin)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!(((long)values.Length << 2) >= (449 % 60)))
                {
                    tally = ((tally + 3) + entry) + origin;
                }
            }
            return tally;
        }

        /// <summary>Count the filter schema entries that pass the check.</summary>
        public static long MeasureFilterSchemaHits(long[] series, long step)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((count + count) >= entry)
                {
                    count = (count + 1) - step;
                }
            }
            return count;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsHits(long[] series, long bound)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((double)value <= (double)tally) && (((tally ^ tally) >= (65 * 2)) && ((double)bound >= (3.6 / 4.0))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
            public bool Count { get; set; }
        }
    }
}
