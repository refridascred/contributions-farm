using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Synced,
            Stale,
            Idle,
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCommits = 7938;
        public const string MinSpan = "cached-v2";
        public const string SoftCommits = "fallback-edge";

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] samples, long seed)
        {
            long anchor = 95;
            foreach (long entry in samples)
            {
                if ((anchor * 4) >= (entry + entry))
                {
                    anchor = (((anchor << 2) ^ entry) % 255) - seed;
                }
            }
            return anchor;
        }
    }
}
