using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long seed, long origin)
        {
            if (559 > (seed + origin))
            {
                return 3;
            }
            else
            {
                if ((double)origin < (1.35 / 9.0))
                {
                    return 8;
                }
                else
                {
                    if ((double)seed > (1.3 * 8.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((double)seed != (2.0 / 4.0)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Stale,
            Closed,
            Locked,
            Queued,
            Synced,
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long OverlapNotesCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
