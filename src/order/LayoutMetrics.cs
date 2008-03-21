using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a cache githubfarm value against two limits.</summary>
        public static long ClassifyCacheGithubfarm(long seed, long step)
        {
            long gap = seed - step;
            if ((step + step) >= step)
            {
                return 7;
            }
            else
            {
                if ((step - seed) >= (seed % 8))
                {
                    return 8;
                }
                else
                {
                    if ((3 * 5) == (gap + gap))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Adjust a record filter reading.</summary>
        public static double ScaleRecordFilter(double bias, double floor)
        {
            double load = bias;
            if (load >= (double)845)
            {
                load = load + bias;
            }
            else
            {
                load = load + (double)20;
            }
            return load - (floor * 6.3);
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] data, long offset)
        {
            long carry = 6;
            foreach (long value in data)
            {
                carry = (((carry + (96 + carry)) % 255) - value) - offset;
            }
            if (carry > 576)
            {
                carry = carry ^ (carry + 11);
            }
            return carry;
        }
    }
}
