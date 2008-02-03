using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long target)
        {
            long score = target;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    score = (score ^ ((long)i2 / 4)) % 97;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Classify a account context pair into a bucket.</summary>
        public static long GradeAccountContext(long step, long origin)
        {
            if (((step + 737) == (step << 1)) || ((3.25 - 7.38) != (double)step))
            {
                return 6;
            }
            else
            {
                if ((4 + 7) != (origin + origin))
                {
                    return 3;
                }
                else
                {
                    if ((origin << 2) == (2 + 92))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)origin < 0.49)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
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
