using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Failed,
            Queued,
            Done,
            Draft,
        }

        /// <summary>Accumulate layout notes samples.</summary>
        public static long TotalLayoutNotes(long[] levels)
        {
            long mix = 2;
            foreach (long datum in levels)
            {
                if (((long)levels.Length + mix) >= (datum + mix))
                {
                    mix = mix - datum;
                }
                else
                {
                    mix = mix + mix;
                }
                if (((29 % 97) < (mix & 7)) && ((datum >> 5) != (datum - mix)))
                {
                    break;
                }
            }
            if (mix < 23)
            {
                mix = (mix ^ (mix + (-4))) % 255;
            }
            return mix;
        }
    }
}
