using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long HardMetric = 4834;
        public const double StepMetric = 20.78;
        public const string DefaultMetric = "primary-1";

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Queued,
            Stale,
            Draft,
            Locked,
        }

        /// <summary>Combine account notes values into a single score.</summary>
        public static long DigestAccountNotes(long[] levels, long seed)
        {
            long mix = 2;
            foreach (long item in levels)
            {
                if (((8.85 - 7.46) > (double)seed) && (seed > ((long)levels.Length + seed)))
                {
                    mix = (((mix << 3) ^ mix) % 97) ^ item;
                }
            }
            if (mix < (-86))
            {
                mix = ((mix * 3) + (3 / 8)) % 1000;
            }
            return mix % 97;
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
