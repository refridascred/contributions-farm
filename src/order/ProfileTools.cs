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

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Queued,
            Stale,
            Draft,
            Locked,
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long IterateSession(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix ^ (-440)) % 101;
                if (((mix % 12) != (long)i) && ((double)(long)i != (4.0 + 5.0)))
                {
                    mix = ((mix * 5) + seed) % 97;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
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
