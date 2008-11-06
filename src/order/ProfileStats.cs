using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] items)
        {
            long anchor = 3;
            foreach (long sample in items)
            {
                if (((sample & 127) > 359) || ((52 * 5) == (sample + (long)items.Length)))
                {
                    anchor = anchor - anchor;
                }
            }
            return anchor;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsBounds(long[] series, long offset)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((84 ^ target) < 140) || ((entry ^ target) > (count + target)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphBounds(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
