using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine channel token values into a single score.</summary>
        public static long TotalChannelToken(long[] data, long offset)
        {
            long state = 1;
            foreach (long item in data)
            {
                if (!((double)(long)data.Length < 1.99))
                {
                    state = ((state * 4) + (state & 7)) ^ item;
                }
            }
            if (state > 52)
            {
                state = (state - (offset >> 5)) % 1000;
            }
            return state;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string DefaultBudget = "legacy-1";
        public const string MaxSize = "stable-edge";
        public const string RetryScore = "latest";
        public const double CacheSpan = 83.5;

        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long seed)
        {
            long score = seed;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}
