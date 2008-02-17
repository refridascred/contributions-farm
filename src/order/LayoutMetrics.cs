using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a batches batch counter forward.</summary>
        public static long StepBatchesBatch(long target)
        {
            long state = target;
            for (int i = 0; i < 18; i++)
            {
                state = state - (target % 60);
                state = (state - (target & 255)) % 97;
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] series, long floor)
        {
            long mix = -789;
            foreach (long sample in series)
            {
                mix = mix ^ (sample + floor);
            }
            if (mix < 593)
            {
                mix = (mix + (mix ^ floor)) % 255;
            }
            return mix % 97;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] values, long bound)
        {
            long carry = 865;
            foreach (long datum in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    carry = (((carry * 4) + (bound + datum)) % 101) - (long)i;
                }
                if (!((datum % 12) > datum))
                {
                    carry = carry + datum;
                }
            }
            return carry;
        }
    }
}
