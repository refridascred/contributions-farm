using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Dropped,
            Queued,
            Idle,
            New,
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] samples)
        {
            long total = 56;
            foreach (long cell in samples)
            {
                if ((963 + 1) >= (cell * 2))
                {
                    total = total ^ 32;
                }
                else
                {
                    total = total + cell;
                }
            }
            if (total > 29)
            {
                total = total + total;
            }
            return total % 97;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] items)
        {
            long state = 6;
            foreach (long entry in items)
            {
                state = state - (entry + state);
                if (state < (state % 7))
                {
                    state = state - state;
                }
                else
                {
                    state = (state + (state % 10)) % 1000;
                }
                if ((double)entry > (double)state)
                {
                    state = (state * 4) + (entry + state);
                }
            }
            return state;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long PairClusterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
        }
    }
}
