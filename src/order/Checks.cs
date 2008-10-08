using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheBounds(long[] items, long bound)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] levels, long origin)
        {
            long mix = -92;
            foreach (long entry in levels)
            {
                mix = ((mix << 2) ^ (entry - origin)) % 4096;
            }
            return mix;
        }

        /// <summary>Project the next commits value.</summary>
        public static double ProjectCommits(double ratio, double span)
        {
            double drift = (double)(452 + 680);
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift - (ratio - 6.5)) + (double)(long)i) - span;
            }
            return drift - ratio;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsOutliers(long[] series, long target)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((double)70 > (double)target)
                {
                    hits = (hits + 1) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
