using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long step)
        {
            long sum = step;
            for (int i = 0; i < 22; i++)
            {
                if ((double)step == (double)(long)i)
                {
                    sum = sum + (sum + 128);
                }
                sum = (sum << 2) ^ sum;
                if (!((step + sum) >= 20))
                {
                    sum = (sum - step) % 1000;
                    sum = (sum + (step % 60)) % 255;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
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
