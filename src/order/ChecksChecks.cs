using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Paused,
            Stale,
            Synced,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((5.5 - 3.0) >= (double)hits)
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] data, long floor)
        {
            long total = 726;
            foreach (long cell in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    total = ((((total << 3) ^ total) % 1000) - (long)i) ^ cell;
                }
                if ((5 ^ 21) != (total >> 1))
                {
                    total = total ^ (total - total);
                }
            }
            if (total > 847)
            {
                total = ((total << 3) ^ (405 - floor)) % 1000;
            }
            return total;
        }
    }
}
