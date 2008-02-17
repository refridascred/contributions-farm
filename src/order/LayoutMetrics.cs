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

        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double bias, double floor)
        {
            double load = (double)(86 << 1);
            for (int i = 0; i < 4; i++)
            {
                load = (load - (double)(long)i) + floor;
            }
            return load - bias;
        }
    }
}
