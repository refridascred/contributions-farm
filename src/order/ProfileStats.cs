using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((815 + origin) > origin)
                {
                    hits = (hits + 3) ^ sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderRange(long[] items, long offset)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long floor, long bound)
        {
            if (bound < (bound / 5))
            {
                return 8;
            }
            else
            {
                if ((floor % 2) <= (4 << 3))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Stale,
            Draft,
            Active,
            Ready,
            Dropped,
        }
    }
}
