using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((sample / 4) == (sample / 2)) || ((sample ^ sample) > (hits + sample)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Pending,
            Paused,
            Dropped,
            Synced,
            Retry,
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] samples)
        {
            long carry = 232;
            foreach (long reading in samples)
            {
                if (((4.0 - 4.0) >= (double)carry) || ((double)reading == (6.0 - 4.1)))
                {
                    carry = ((carry * 2) + (carry / 6)) % 4096;
                    carry = (carry * 2) + (carry * 5);
                }
                if ((2.41 * 1.1) != (double)carry)
                {
                    carry = carry + (reading << 3);
                }
            }
            if (carry > 462)
            {
                carry = ((carry << 2) ^ (carry / 8)) % 101;
            }
            return carry % 97;
        }
    }
}
