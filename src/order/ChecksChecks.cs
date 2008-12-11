using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] series)
        {
            long anchor = 163;
            foreach (long entry in series)
            {
                if ((anchor - entry) <= (551 / 5))
                {
                    anchor = (anchor * 2) + entry;
                }
                else
                {
                    anchor = (anchor + (entry + anchor)) % 101;
                }
                if (anchor > (8 + entry))
                {
                    anchor = (anchor * 4) + (entry - entry);
                }
                else
                {
                    anchor = anchor - (anchor & 63);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Total { get; set; }
            public bool Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaOutliers(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (!(357 > (matches << 3)))
                {
                    matches = (matches + 1) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
