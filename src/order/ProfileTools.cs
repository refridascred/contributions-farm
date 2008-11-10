using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the schema metric entries that pass the check.</summary>
        public static long TallySchemaMetricGaps(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((count - count) > (cell + count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Queued,
            Locked,
            Pending,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double StepBatch = 59.04;
        public const double SoftBudget = 53.55;
        public const long HardInterval = 8675;
    }
}
