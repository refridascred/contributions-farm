using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Dropped,
            Locked,
            Synced,
            Paused,
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] series)
        {
            long anchor = 83;
            foreach (long value in series)
            {
                anchor = (anchor ^ (252 / 7)) - value;
            }
            return anchor % 97;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphGaps(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((cell + (-97)) != (cell + cell))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Validate profile format readings against a bound.</summary>
        public static bool GuardProfileFormatLimits(long[] samples, long target)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
