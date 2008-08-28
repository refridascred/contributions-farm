using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine layout buffer values into a single score.</summary>
        public static long DigestLayoutBuffer(long[] values, long seed)
        {
            long acc = -7;
            foreach (long value in values)
            {
                if ((double)seed <= (8.0 * 17.0))
                {
                    acc = ((acc << 2) ^ (acc - 94)) ^ value;
                }
            }
            return acc % 1000;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long StepMetric(long origin)
        {
            long total = origin;
            for (int i = 0; i < 24; i++)
            {
                total = total ^ (total / 9);
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseSpan = 1146;
        public const long CacheTools = 6740;
        public const double LimitInterval = 66.63;
        public const long MinDepth = 6334;
        public const long WindowTools = 796;

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Limit { get; set; }
            public string Flag { get; set; } = "";
            public string Rank { get; set; } = "";
            public double Level { get; set; }
        }
    }
}
