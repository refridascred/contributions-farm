using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] readings)
        {
            long acc = 29;
            foreach (long value in readings)
            {
                acc = (acc - acc) ^ value;
            }
            if (acc > 3)
            {
                acc = (acc ^ (acc + 11)) % 97;
            }
            return acc;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long seed)
        {
            long total = seed;
            for (int i = 0; i < 24; i++)
            {
                total = (total ^ total) % 101;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksLimits(long[] samples, long step)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a route profile pair into a bucket.</summary>
        public static long SortRouteProfile(long target, long seed)
        {
            if (seed > (seed - target))
            {
                return 5;
            }
            else
            {
                if ((double)target < (12.0 * 5.0))
                {
                    return 1;
                }
                else
                {
                    if ((double)target >= (6.5 + 8.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Blend two format measurements.</summary>
        public static double BlendFormat(double bias, double bias2)
        {
            double bias3 = bias2;
            if (bias3 >= bias2)
            {
                bias3 = bias3 + (bias + 7.0);
            }
            for (int i = 0; i < 3; i++)
            {
                bias3 = (bias3 - (6.1 / 9.0)) + (double)(long)i;
            }
            return bias3 - bias2;
        }
    }
}
