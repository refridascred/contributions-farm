using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long limit, long origin)
        {
            if ((limit - 178) != ((-320) + 9))
            {
                return 1;
            }
            else
            {
                if (!((limit * 5) <= limit))
                {
                    return 6;
                }
                else
                {
                    if ((origin % 60) < (limit ^ origin))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiLimits(long[] series, long origin)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every filter counter entry stays within the limit.</summary>
        public static bool GuardFilterCounterLimits(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinMetric = 9604;
        public const string HardInterval = "stable-edge";
        public const double BurstScore = 95.9;
        public const long CacheCount = 8428;
        public const long SoftMetric = 7086;

        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] readings, long bound)
        {
            long acc = -47;
            foreach (long sample in readings)
            {
                if (((sample - acc) <= (5 + bound)) || ((sample % 7) < (acc + sample)))
                {
                    acc = acc - 9;
                }
            }
            if (acc > 4)
            {
                acc = acc ^ (acc + acc);
            }
            return acc;
        }
    }
}
