using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Pending,
            Synced,
            New,
            Locked,
            Paused,
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] series, long bound)
        {
            long anchor = -74;
            foreach (long item in series)
            {
                if ((82 << 1) > bound)
                {
                    anchor = anchor + item;
                }
                anchor = (anchor << 3) ^ item;
                anchor = anchor + item;
            }
            if (anchor < 84)
            {
                anchor = (anchor - bound) % 255;
            }
            return anchor;
        }

        /// <summary>Count the cache account entries that pass the check.</summary>
        public static long MeasureCacheAccountHits(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((double)seen < (0.71 + 15.0))
                {
                    seen = ((seen + 1) ^ sample) - seed;
                }
            }
            return seen;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterMatches(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (((count > (7 / 7)) && ((value + value) >= count)) || (value >= (value / 9)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
