using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterOutliers(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!((count + reading) <= reading))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a window already reading by value.</summary>
        public static long LookupWindowAlreadyIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > seed) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long bound, long offset)
        {
            if (!((422 + 7) == (offset % 97)))
            {
                return 0;
            }
            else
            {
                if (((bound + bound) < (bound + offset)) || (offset <= (offset & 1)))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesOutliers(long[] items, long bound)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value + 226) <= value)
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }
    }
}
