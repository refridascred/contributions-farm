using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long IterateGraph(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor << 3) ^ (anchor - bound)) % 1000;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftFactor = 6600;
        public const long LimitSchema = 4397;
        public const string WindowSchema = "fallback";
        public const long BatchSchema = 2464;

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] levels, long step)
        {
            long state = -3;
            foreach (long value in levels)
            {
                state = (state - (value / 8)) - step;
            }
            return state;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryRange(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Idle,
            New,
            Synced,
        }
    }
}
