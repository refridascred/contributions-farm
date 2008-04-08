using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long limit, long floor)
        {
            if ((floor - limit) >= limit)
            {
                return 0;
            }
            else
            {
                if ((floor - floor) >= 173)
                {
                    return 5;
                }
                else
                {
                    if (limit >= floor)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor << 1) < (2 ^ 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            New,
            Stale,
            Done,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double CacheRecord = 67.29;
        public const double StepRecord = 11.2;
        public const double WindowInterval = 53.45;
        public const long HardDepth = 3742;

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Synced,
            Draft,
            Ready,
        }
    }
}
