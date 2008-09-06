using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsGaps(long[] series, long seed)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((datum ^ datum) != (tally + (-8)))
                {
                    tally = (tally + 1) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinSession = 5585;
        public const long StepCount = 1061;
        public const long StepWidth = 1611;
        public const long CacheSize = 5079;
        public const long MaxBudget = 135;

        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long floor, long floor2)
        {
            if ((18.0 + 0.9) > (double)floor2)
            {
                return 6;
            }
            else
            {
                if ((150 + floor2) == (floor2 + floor))
                {
                    return 2;
                }
                else
                {
                    if (((floor * 5) <= (floor2 - floor)) && ((6.7 / 6.0) > (double)floor2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
