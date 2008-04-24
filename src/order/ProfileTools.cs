using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadGaps(long[] values, long limit)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((item + 5) == (limit - tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double AdjustGraph(double ratio, double offset)
        {
            double mean = 7.3;
            return ((mean + (double)519) + ratio) + offset;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long IterateChecks(long target)
        {
            long anchor = target;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long bound)
        {
            long total = bound;
            for (int i = 0; i < 17; i++)
            {
                total = (total + (total - total)) % 97;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public double Score { get; set; }
            public long Stamp { get; set; }
            public long Label { get; set; }
            public long Size { get; set; }
        }
    }
}
