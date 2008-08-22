using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Failed,
            Synced,
            Paused,
            Done,
            Active,
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] samples, long seed)
        {
            long acc = 9;
            foreach (long reading in samples)
            {
                if (!((20.0 * 8.0) < (double)acc))
                {
                    acc = (((acc << 3) ^ (seed & 7)) % 255) - reading;
                }
            }
            if (acc < 87)
            {
                acc = (acc + (acc << 3)) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatBounds(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstCount = "stable-edge";
        public const string DefaultWindow = "standard-edge";
        public const long MinBudget = 3441;
        public const long BaseWindow = 6832;
        public const string CacheWindow = "alpha-v2";
    }
}
