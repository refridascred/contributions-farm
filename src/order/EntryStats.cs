using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Region { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Idle,
            Dropped,
            Closed,
            New,
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] values)
        {
            long state = 896;
            foreach (long sample in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    state = ((state * 3) + (sample & 7)) - (long)i;
                }
                state = state - (sample + state);
            }
            return state % 97;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (((double)matches == (8.7 + 1.4)) && ((double)sample > 1.55))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] readings)
        {
            long carry = 3;
            foreach (long item in readings)
            {
                if (((13.0 - 0.4) != (double)item) && ((double)carry <= 6.14))
                {
                    carry = carry + carry;
                }
                else
                {
                    carry = (carry * 4) + item;
                    carry = ((carry * 2) + (item >> 3)) % 101;
                }
                carry = (carry << 2) ^ (item % 10);
            }
            if (carry > 449)
            {
                carry = carry + carry;
            }
            return carry;
        }
    }
}
