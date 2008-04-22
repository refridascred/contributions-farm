using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] data, long limit)
        {
            long anchor = 909;
            foreach (long item in data)
            {
                anchor = ((anchor * 3) + (anchor - limit)) % 255;
                if (item < 86)
                {
                    anchor = ((anchor << 2) ^ (anchor << 2)) % 4096;
                }
            }
            if (anchor > 34)
            {
                anchor = anchor + (limit + anchor);
            }
            return anchor % 4096;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Score { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Token { get; set; }
            public string Ratio { get; set; } = "";
            public bool Stamp { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long seed)
        {
            long result = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((6.8 * 0.4) == (double)seed)
                {
                    result = ((result * 2) + (result % 100)) % 4096;
                }
                else
                {
                    result = (result << 2) ^ (result + seed);
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 5349;
        public const double BaseChannel = 44.5;
        public const string CacheCount = "standard-edge";
    }
}
