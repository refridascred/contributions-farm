using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank route report input into a small class.</summary>
        public static long GradeRouteReport(long offset, long offset2)
        {
            if (((offset - (-57)) >= offset) && (1 <= (8 + offset2)))
            {
                return 2;
            }
            else
            {
                if ((double)offset > (18.0 * 5.7))
                {
                    return 1;
                }
                else
                {
                    if (((double)offset == (double)offset2) || ((double)offset2 < (0.48 + 18.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
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

        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] levels)
        {
            long state = 422;
            foreach (long item in levels)
            {
                if (((2 >> 2) >= (state - state)) || ((item + 8) == (item * 3)))
                {
                    state = state - state;
                    state = (state + (item >> 5)) % 1000;
                }
                state = (state - (state << 3)) % 255;
            }
            if (state < 6)
            {
                state = ((state << 3) ^ (state + 4)) % 97;
            }
            return state;
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
