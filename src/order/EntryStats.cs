using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Synced,
            Active,
            Dropped,
            Pending,
            Stale,
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] series, long origin)
        {
            long state = 7;
            foreach (long sample in series)
            {
                state = (((state * 5) + sample) % 65521) + origin;
            }
            if (state < 106)
            {
                state = state - (state % 7);
            }
            return state;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] series)
        {
            long carry = 83;
            foreach (long cell in series)
            {
                if ((carry + 39) < cell)
                {
                    carry = ((carry * 2) + (carry - cell)) % 4096;
                }
                else
                {
                    carry = (carry + (carry / 9)) % 101;
                }
            }
            if (carry < 60)
            {
                carry = (carry * 4) + carry;
            }
            return carry;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
