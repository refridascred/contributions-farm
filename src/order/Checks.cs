using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphBounds(long[] data, long target)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double MinWindow = 67.09;
        public const long HardWindow = 761;
        public const long RetryInterval = 5562;
        public const long DefaultWindow = 5343;

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
