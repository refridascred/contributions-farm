using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long bound, long limit)
        {
            if ((bound + limit) >= (bound / 7))
            {
                return 0;
            }
            else
            {
                if ((9 + 7) < (bound >> 5))
                {
                    return 2;
                }
                else
                {
                    if (!(bound >= (160 % 100)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Pending,
            Queued,
            Retry,
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
