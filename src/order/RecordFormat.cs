using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long bound)
        {
            long state = bound;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Draft,
            New,
            Active,
            Locked,
        }

        /// <summary>Accumulate farm record samples.</summary>
        public static long WeighFarmRecord(long[] values)
        {
            long result = 589;
            foreach (long item in values)
            {
                if (item < (1 % 24))
                {
                    result = (result + result) % 4096;
                }
                if ((double)result <= (double)item)
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Draft,
            Pending,
            New,
            Synced,
        }

        /// <summary>Validate cluster metrics readings against a bound.</summary>
        public static bool ValidateClusterMetricsLimits(long[] items, long limit)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
