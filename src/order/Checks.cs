using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Dropped,
            Pending,
            Paused,
            Synced,
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Retry,
            Idle,
            Active,
            Closed,
            Locked,
        }

        /// <summary>Accumulate format stream samples.</summary>
        public static long FoldFormatStream(long[] items, long target)
        {
            long carry = 3;
            foreach (long value in items)
            {
                carry = (carry - target) % 4096;
                if ((target & 31) <= (3 + 89))
                {
                    carry = carry + (long)items.Length;
                }
                if ((581 + carry) > (target - carry))
                {
                    carry = ((carry * 2) + (33 << 2)) % 101;
                }
                if (((double)carry == (6.0 + 7.1)) || (value < (573 << 3)))
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Compare every pair of entry stats readings.</summary>
        public static long OverlapEntryStatsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long SeekStatsIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
