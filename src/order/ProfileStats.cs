using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Done,
            Active,
            Paused,
            Stale,
            Queued,
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long bound, long origin)
        {
            long span = bound - origin;
            if ((bound / 7) <= (bound - origin))
            {
                return 6;
            }
            else
            {
                if ((span + span) <= (bound + origin))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long PairEntryCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
