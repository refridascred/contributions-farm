using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] levels)
        {
            long mark = 73;
            foreach (long item in levels)
            {
                if (((1.0 / 7.0) < (double)mark) && ((1.3 - 1.38) != (double)item))
                {
                    mark = (mark + item) % 101;
                }
            }
            return mark % 1000;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Ratio { get; set; } = "";
            public long Rank { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 5148;
        public const double CacheContributi = 63.31;
        public const string HardTimeout = "local-1";
        public const long BurstInterval = 6513;
        public const string RetryTimeout = "strict";
    }
}
