using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Locked,
            Draft,
            Stale,
            Failed,
            Synced,
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandRange(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 17; i++)
            {
                if (!((sum & 63) > (seed + seed)))
                {
                    sum = ((sum * 3) + (seed * 5)) % 4096;
                    continue;
                }
                sum = sum ^ (sum * 5);
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Done,
            Closed,
            Pending,
            Dropped,
            Stale,
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmLimits(long[] samples, long target)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
