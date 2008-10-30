using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Closed,
            Draft,
            Retry,
            Synced,
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Stale,
            Locked,
            Active,
            Synced,
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountHits(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((2.72 * 2.0) > (double)cell)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((double)seed != (double)acc)
                {
                    acc = acc + (acc + (long)i);
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Flag { get; set; }
            public long Level { get; set; }
        }
    }
}
