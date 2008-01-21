using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Dropped,
            Locked,
            Synced,
            Done,
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((cell / 7) < (-8)) || ((9 - cell) > (seen ^ cell)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((datum ^ 967) > (hits >> 5)) && ((double)datum >= (17.0 - 13.0)))
                {
                    hits = (hits + 2) + seed;
                }
            }
            return hits;
        }
    }
}
