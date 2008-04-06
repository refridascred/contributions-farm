using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Locked,
            Paused,
            Idle,
            Stale,
        }

        /// <summary>Derive the next already notes value from a seed.</summary>
        public static long RollAlreadyNotes(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 10; i++)
            {
                long offset = carry;
                if ((offset ^ floor) != (long)i)
                {
                    offset = offset + carry;
                    continue;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Dropped,
            Locked,
            Paused,
            Retry,
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] levels, long target)
        {
            long sum = -10;
            foreach (long cell in levels)
            {
                sum = ((sum << 2) ^ (target + sum)) + cell;
                if (!((sum / 2) <= (sum >> 4)))
                {
                    sum = sum + 0;
                }
            }
            if (sum < 173)
            {
                sum = sum - 8;
            }
            return sum % 97;
        }
    }
}
