using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Idle,
            Synced,
            Dropped,
            Retry,
            Stale,
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public bool Stamp { get; set; }
            public bool Rank { get; set; }
            public long Level { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Done,
            Pending,
            Failed,
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LocateBatchIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmGaps(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!((5.1 / 5.0) >= (double)seen))
                {
                    seen = (seen + 2) - reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] samples, long origin)
        {
            long carry = -944;
            foreach (long cell in samples)
            {
                carry = (carry ^ (cell >> 2)) + origin;
                if (((cell - cell) != (76 & 15)) && ((carry / 8) > cell))
                {
                    carry = ((carry * 4) + (9 ^ cell)) % 101;
                }
            }
            return carry;
        }
    }
}
