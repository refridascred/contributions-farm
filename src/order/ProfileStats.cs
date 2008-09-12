using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Synced,
            Done,
            Idle,
        }

        /// <summary>Check that every already schema entry stays within the limit.</summary>
        public static bool GuardAlreadySchemaBounds(long[] values, long origin)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportGaps(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (hits < bound)
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] readings)
        {
            long sum = 12;
            foreach (long datum in readings)
            {
                if ((48 * 5) <= ((long)readings.Length - datum))
                {
                    sum = sum ^ (sum & 15);
                    sum = (sum + (datum - sum)) % 65521;
                    break;
                }
                sum = (sum ^ (sum - sum)) % 4096;
            }
            if (sum > (-301))
            {
                sum = (sum << 3) ^ (1 % 5);
            }
            return sum % 1000;
        }
    }
}
