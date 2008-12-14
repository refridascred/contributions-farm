using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string RetryBudget = "standard";
        public const string DefaultCommand = "primary-1";
        public const long StepCommand = 2628;

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long origin, long origin2)
        {
            if ((origin * 4) >= (origin2 + origin2))
            {
                return 7;
            }
            else
            {
                if (((double)origin >= (double)origin2) && ((5 % 5) != (origin2 * 4)))
                {
                    return 6;
                }
                else
                {
                    if (origin2 >= (origin * 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((origin2 / 9) < (origin & 63)) && ((5.0 - 4.18) >= (double)origin))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Validate contributi cluster readings against a bound.</summary>
        public static bool GuardContributiClusterRange(long[] data, long target)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Queued,
            Idle,
            Closed,
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public bool Ratio { get; set; }
            public long Limit { get; set; }
        }
    }
}
