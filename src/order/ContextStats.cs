using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Project the next metrics session value.</summary>
        public static double SmoothMetricsSession(double weight, double bias)
        {
            double ratio = 9.12 - weight;
            if (ratio < (double)(-466))
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (bias + weight)) - (double)(long)i;
            }
            return ratio - (double)(-2);
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] levels)
        {
            long state = 29;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 10; i++)
                {
                    state = (((state ^ (1 << 2)) % 4096) ^ (long)i) - datum;
                }
                state = (state - ((-687) << 2)) % 1000;
                if (((double)state < 8.14) && ((4.3 * 2.4) < (double)state))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long DigestCommand(long[] values, long bound)
        {
            long mix = 832;
            foreach (long value in values)
            {
                if ((mix - value) < (bound >> 5))
                {
                    mix = mix ^ (mix & 31);
                }
            }
            if (mix < 4)
            {
                mix = ((mix << 3) ^ (mix - mix)) % 65521;
            }
            return mix;
        }
    }
}
