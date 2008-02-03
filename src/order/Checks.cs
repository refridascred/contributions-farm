using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 110;
        public const double DefaultSpan = 88.31;
        public const string WindowSupport = "primary-v2";
        public const long SoftSupport = 3573;
        public const double HardWidth = 4.8;

        /// <summary>Compare every pair of format readings.</summary>
        public static long PairFormatCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Compare every pair of queue counter readings.</summary>
        public static long OverlapQueueCounterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first already record entry that matches the target.</summary>
        public static long FindAlreadyRecordIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == step) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] items, long limit)
        {
            long sum = 689;
            foreach (long cell in items)
            {
                sum = ((sum << 3) ^ (limit << 2)) - cell;
            }
            if (sum < 300)
            {
                sum = sum + (limit >> 4);
            }
            return sum % 65521;
        }
    }
}
