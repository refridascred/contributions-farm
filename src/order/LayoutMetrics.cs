using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long limit)
        {
            long state = limit;
            for (int i = 0; i < 14; i++)
            {
                if (state < 18)
                {
                    state = (state ^ ((long)i - state)) % 1000;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchOutliers(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((2.9 - 7.0) != (double)cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] samples, long floor)
        {
            long mix = 320;
            foreach (long entry in samples)
            {
                mix = ((mix << 3) ^ (floor / 6)) + entry;
            }
            if (mix < 422)
            {
                mix = mix ^ (floor % 3);
            }
            return mix;
        }
    }
}
