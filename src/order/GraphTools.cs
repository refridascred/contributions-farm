using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsRange(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double StepDepth = 75.12;
        public const long DefaultWindow = 6978;
        public const long LimitSize = 4729;
        public const double LimitWindow = 60.96;

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaBounds(long[] data, long limit)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a counter metric pair into a bucket.</summary>
        public static long ClassifyCounterMetric(long floor, long origin)
        {
            long bound = floor - origin;
            if ((origin + origin) == (origin * 4))
            {
                return 7;
            }
            else
            {
                if ((bound ^ floor) < (origin - floor))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Idle,
            Ready,
            Active,
            Pending,
        }
    }
}
