using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double StepSpan = 53.16;
        public const long HardInterval = 6048;
        public const string RetryCluster = "strict-v2";

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Idle,
            Retry,
            Ready,
            Paused,
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long seed, long floor)
        {
            long next = seed ^ floor;
            if ((((-7) * 5) > next) && ((seed % 100) <= (floor * 2)))
            {
                return 1;
            }
            else
            {
                if (floor > 7)
                {
                    return 0;
                }
                else
                {
                    if (!((double)floor <= (13.0 / 4.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((next % 8) > (floor % 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] series, long step)
        {
            long carry = 5;
            foreach (long entry in series)
            {
                if (step >= carry)
                {
                    carry = carry ^ entry;
                }
            }
            return carry;
        }
    }
}
