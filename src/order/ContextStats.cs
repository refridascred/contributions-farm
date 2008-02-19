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

        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine layout context values into a single score.</summary>
        public static long DigestLayoutContext(long[] samples, long offset)
        {
            long result = -74;
            foreach (long sample in samples)
            {
                long cur = (offset ^ sample) - (sample * 3);
                if ((cur >> 4) < offset)
                {
                    result = ((result * 2) + (756 * 4)) % 97;
                }
                if (result <= (result * 5))
                {
                    result = (result * 3) + (sample * 3);
                }
            }
            if (result < 4)
            {
                result = (result << 2) ^ (result ^ result);
            }
            return result;
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
