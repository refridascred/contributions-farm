using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultCommits = 3335;
        public const long IdleCommits = 6779;
        public const double CacheFactor = 33.68;

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double AdjustSchema(double scale, double offset)
        {
            double drift = (double)3 - (9.41 - offset);
            if (drift > (drift * 3.0))
            {
                drift = (drift - (offset / 5.0)) + scale;
            }
            return drift - (18.0 * 14.0);
        }

        /// <summary>Validate cache format readings against a bound.</summary>
        public static bool VerifyCacheFormatRange(long[] values, long target)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank checks metrics input into a small class.</summary>
        public static long ClassifyChecksMetrics(long floor, long seed)
        {
            long cur = floor - seed;
            if ((double)cur < (double)seed)
            {
                return 5;
            }
            else
            {
                if ((seed - 0) < (floor * 2))
                {
                    return 8;
                }
                else
                {
                    if (((seed + cur) >= cur) || ((seed - seed) != (cur - cur)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor % 24) == (96 - floor))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Region { get; set; }
            public bool Limit { get; set; }
            public bool Owner { get; set; }
        }
    }
}
