using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Retry,
            Idle,
            Locked,
            Synced,
            Ready,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFormat = 4954;
        public const string MaxFormat = "open-1";
        public const double MaxInterval = 32.68;

        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long seed, long bound)
        {
            long slot = seed + bound;
            if ((6.9 - 7.76) > (double)992)
            {
                return 0;
            }
            else
            {
                if (!((983 ^ slot) <= (slot - bound)))
                {
                    return 3;
                }
                else
                {
                    if (((seed - seed) != (slot * 2)) || ((seed ^ bound) > (slot / 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up profile samples.</summary>
        public static long OverlapProfileCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
