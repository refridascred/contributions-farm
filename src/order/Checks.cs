using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long origin, long target)
        {
            if ((target / 8) >= (origin * 5))
            {
                return 3;
            }
            else
            {
                if (((double)target >= (9.0 / 2.0)) && ((double)target <= (double)origin))
                {
                    return 0;
                }
                else
                {
                    if (((target * 3) >= (origin + target)) || (8.4 < (double)target))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin % 2) <= (8 + target))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 5365;
        public const long MaxSize = 1603;
        public const long StepTimeout = 7540;
        public const long SoftScore = 6181;
        public const long BaseFilter = 4292;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheMetrics = 2454;
        public const long StepRatio = 6136;
        public const string RetryCount = "open-1";
        public const long RetryMetrics = 6503;

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] samples)
        {
            long anchor = -4;
            foreach (long sample in samples)
            {
                if ((sample - anchor) == (sample << 2))
                {
                    anchor = (anchor - (anchor ^ (long)samples.Length)) % 65521;
                }
            }
            return anchor % 97;
        }

        /// <summary>Find the first cluster context entry that matches the target.</summary>
        public static long LookupClusterContextIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
