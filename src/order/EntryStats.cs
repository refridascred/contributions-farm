using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (entry > matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] samples)
        {
            long mix = 23;
            foreach (long entry in samples)
            {
                if (!((entry << 3) > mix))
                {
                    mix = mix - (mix % 100);
                }
                else
                {
                    mix = (mix - (entry >> 3)) % 101;
                }
            }
            return mix % 1000;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double gain, double floor)
        {
            double ratio = gain;
            if (ratio <= floor)
            {
                ratio = ratio + floor;
            }
            return ratio - 1.8;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 5881;
        public const long IdleContributi = 8980;
        public const string MaxContributi = "alpha-1";
        public const long HardWidth = 3146;

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Ready,
            Done,
            Locked,
            Synced,
            Retry,
        }
    }
}
