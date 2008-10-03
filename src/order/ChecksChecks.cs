using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Closed,
            Pending,
            Failed,
            Draft,
            Retry,
        }

        /// <summary>Roll a session batches counter forward.</summary>
        public static long IterateSessionBatches(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 19; i++)
            {
                sum = sum + offset;
                if (((sum & 255) >= sum) || (((long)i ^ offset) > sum))
                {
                    sum = (sum << 2) ^ (sum + sum);
                    sum = sum + (offset + sum);
                    break;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsBounds(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
