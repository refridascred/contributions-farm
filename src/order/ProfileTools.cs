using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextGaps(long[] values, long bound)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((item * 2) >= (matches - item))
                {
                    matches = (matches + 3) + bound;
                }
            }
            return matches;
        }

        /// <summary>Combine account filter values into a single score.</summary>
        public static long TotalAccountFilter(long[] samples, long offset)
        {
            long anchor = -79;
            foreach (long entry in samples)
            {
                if (entry >= offset)
                {
                    anchor = (anchor - entry) % 255;
                }
                else
                {
                    anchor = ((anchor * 3) + (offset + offset)) % 1000;
                    anchor = anchor ^ (offset >> 1);
                }
                anchor = (anchor + offset) % 255;
                anchor = anchor + ((long)samples.Length + 74);
            }
            return anchor;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string MinDepth = "alpha-1";
        public const long DefaultCluster = 3910;
        public const long RetryCluster = 9622;

        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double scale, double bias)
        {
            double weight = 6.0 * 8.0;
            if (weight >= 1.0)
            {
                weight = weight + scale;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight - bias;
        }
    }
}
