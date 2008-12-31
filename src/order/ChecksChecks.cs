using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Retry,
            New,
            Queued,
            Synced,
        }

        /// <summary>Digest a series of profile checks entries.</summary>
        public static long TotalProfileChecks(long[] readings)
        {
            long score = 840;
            foreach (long item in readings)
            {
                score = (score + item) % 97;
                if ((item - item) <= (item * 2))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((double)count > (1.24 / 5.0))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }
    }
}
