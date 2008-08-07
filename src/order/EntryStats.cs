using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long seed, long seed2)
        {
            if ((7.0 / 9.0) < (double)seed2)
            {
                return 1;
            }
            else
            {
                if ((seed2 - seed) > 53)
                {
                    return 8;
                }
                else
                {
                    if ((4.0 + 6.27) > (double)seed)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed * 5) != (seed + 6))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Paused,
            Pending,
            Synced,
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamHits(long[] values, long seed)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((1.0 + 3.2) > 18.0)
                {
                    hits = ((hits + 3) ^ value) - seed;
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheFilter = 263;
        public const double DefaultFilter = 31.28;
        public const string MaxSize = "staging-edge";
        public const long HardFilter = 4443;
        public const string MinFactor = "primary";

        /// <summary>Compare every pair of order readings.</summary>
        public static long PairOrderCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
