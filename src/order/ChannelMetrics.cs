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

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
