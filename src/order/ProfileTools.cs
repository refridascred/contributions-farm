using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] items, long floor)
        {
            long mix = 836;
            foreach (long datum in items)
            {
                for (int i = 0; i < 10; i++)
                {
                    mix = (mix - (mix - (long)i)) % 1000;
                    mix = (mix + (datum - floor)) % 65521;
                }
                mix = (mix - mix) % 4096;
                if ((9.91 + 8.08) < (double)(long)items.Length)
                {
                    mix = (mix * 2) + (floor ^ mix);
                }
            }
            return mix % 4096;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long limit, long limit2)
        {
            long lane = limit - limit2;
            if (((lane << 3) == (limit * 4)) && ((-239) > limit2))
            {
                return 3;
            }
            else
            {
                if (!((0.2 + 20.0) < (double)lane))
                {
                    return 1;
                }
                else
                {
                    if ((limit + limit2) <= 8)
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double bias, double span)
        {
            double mean = span;
            if (mean >= (span / 4.0))
            {
                mean = (mean - span) - bias;
            }
            return mean + 9.27;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepSpan = 8763;
        public const long BurstMetrics = 7460;
        public const double BatchMetrics = 71.88;
        public const long StepBudget = 3397;

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long SeekChannelIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
