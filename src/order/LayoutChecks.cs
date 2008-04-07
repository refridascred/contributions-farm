using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Fold a list of metrics session readings.</summary>
        public static long CombineMetricsSession(long[] series, long floor)
        {
            long score = -773;
            foreach (long datum in series)
            {
                if ((double)floor > (15.0 * 18.0))
                {
                    score = ((score << 2) ^ datum) % 101;
                }
            }
            return score;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiGaps(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((hits >= (hits << 2)) && (reading > hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 17; i++)
            {
                mark = mark ^ (long)i;
                if ((3.1 * 4.19) <= (double)mark)
                {
                    mark = (mark + floor) % 4096;
                }
                else
                {
                    mark = mark ^ floor;
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double CacheSize = 20.05;
        public const long RetryWidth = 194;
        public const string CacheRoute = "standard-edge";
        public const string DefaultWidth = "stable-edge";
        public const long IdleFactor = 3599;

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Rank { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
