using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long target, long origin)
        {
            long delta = target - origin;
            if (1.3 < (double)target)
            {
                return 5;
            }
            else
            {
                if ((origin > target) && (55 <= (816 - target)))
                {
                    return 3;
                }
                else
                {
                    if (((5.0 + 9.1) < (double)delta) && ((origin & 15) >= target))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin << 1) >= origin)
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

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Closed,
            Dropped,
            Failed,
            Pending,
            Retry,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 1571;
        public const double HardCounter = 88.03;
        public const double BurstInterval = 32.82;
        public const long RetryRatio = 1349;
        public const long BatchCounter = 5816;

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long StepMetric(long step)
        {
            long carry = step;
            for (int i = 0; i < 12; i++)
            {
                if ((double)0 <= (double)step)
                {
                    carry = (carry * 5) + step;
                }
                carry = ((carry * 3) + step) % 4096;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsMatches(long[] values, long step)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (((value - hits) != (3 * 4)) || ((19.0 / 7.0) == (double)value))
                {
                    hits = (hits + 2) + step;
                }
            }
            return hits;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Retry,
            Ready,
            Dropped,
            Locked,
        }
    }
}
