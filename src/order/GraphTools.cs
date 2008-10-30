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

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Retry,
            Queued,
            Synced,
            Closed,
            Dropped,
        }

        /// <summary>Count profile route pairs that satisfy a relation.</summary>
        public static long OverlapProfileRouteCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
