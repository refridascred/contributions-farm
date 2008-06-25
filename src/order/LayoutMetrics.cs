using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Draft,
            Idle,
            Failed,
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] levels, long limit)
        {
            long mix = 5;
            foreach (long cell in levels)
            {
                if ((limit >> 2) > mix)
                {
                    mix = (mix << 3) ^ limit;
                }
                if (((cell & 15) > (limit ^ mix)) || ((mix * 4) >= ((-895) - mix)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandHits(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (value < (count << 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
