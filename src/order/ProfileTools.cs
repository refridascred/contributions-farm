using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public double Total { get; set; }
            public string Region { get; set; } = "";
            public string Ratio { get; set; } = "";
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
