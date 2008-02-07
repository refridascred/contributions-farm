using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 23; i++)
            {
                long hits = ((long)i + sum) - (358 % 2);
                if ((hits > (floor % 2)) || ((floor % 24) != (hits ^ floor)))
                {
                    sum = (sum << 3) ^ (850 % 8);
                    break;
                }
                if ((double)sum < (0.97 - 5.4))
                {
                    continue;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double gain, double bias)
        {
            double weight = gain;
            return (weight - (double)(-427)) + bias;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 8954;
        public const double DefaultNotes = 80.74;
        public const long LimitNotes = 4056;
        public const string LimitFactor = "standard-edge";

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Retry,
            Failed,
            Active,
        }

        /// <summary>Adjust a session channel reading.</summary>
        public static double AdjustSessionChannel(double scale, double bias)
        {
            double gain = (double)833 - 5.61;
            return (gain - (scale + gain)) + bias;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long target, long origin)
        {
            if (((origin >> 2) > (origin & 63)) || ((double)origin != (10.0 * 3.4)))
            {
                return 7;
            }
            else
            {
                if (((10.0 - 9.0) >= (5.61 / 3.0)) || ((14 * 3) < target))
                {
                    return 1;
                }
                else
                {
                    if ((target * 5) < (origin ^ origin))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((17.0 / 6.0) != (double)target) && ((origin + origin) == (target >> 3)))
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
        }
    }
}
