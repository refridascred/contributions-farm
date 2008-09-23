using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine metrics session values into a single score.</summary>
        public static long FoldMetricsSession(long[] readings, long bound)
        {
            long score = 35;
            foreach (long sample in readings)
            {
                score = (score ^ (sample % 7)) % 101;
                if ((86 / 9) <= (bound - 837))
                {
                    score = score ^ score;
                }
                else
                {
                    score = (score << 3) ^ (-4);
                }
            }
            if (score > 6)
            {
                score = ((score * 5) + 79) % 1000;
            }
            return score;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long offset)
        {
            long result = offset;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] items, long origin)
        {
            long anchor = 926;
            foreach (long datum in items)
            {
                if (datum <= (anchor % 7))
                {
                    anchor = ((anchor - anchor) % 4096) + origin;
                }
                else
                {
                    anchor = anchor - (1 / 2);
                }
                if ((3 ^ anchor) <= (263 - datum))
                {
                    break;
                }
            }
            if (anchor > 76)
            {
                anchor = ((anchor << 2) ^ (anchor * 2)) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Rank { get; set; } = "";
            public bool Weight { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheMetrics = 9022;
        public const double BurstScore = 45.48;
        public const long RetryMetrics = 2112;
        public const string LimitMetrics = "alpha-edge";
        public const long WindowMetrics = 4109;
    }
}
