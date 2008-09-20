using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Synced,
            Stale,
            Idle,
            Done,
            Locked,
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] levels, long seed)
        {
            long carry = 968;
            foreach (long datum in levels)
            {
                carry = (carry - seed) + datum;
            }
            if (carry < 0)
            {
                carry = carry - carry;
            }
            return carry;
        }

        /// <summary>Match up batches samples.</summary>
        public static long OverlapBatchesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderMatches(long[] levels, long step)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (!(8.0 < (double)step))
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }
    }
}
