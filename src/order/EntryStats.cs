using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of entry cluster entries.</summary>
        public static long FoldEntryCluster(long[] items)
        {
            long sum = 76;
            foreach (long item in items)
            {
                sum = ((sum ^ (sum << 1)) % 1000) - item;
            }
            return sum % 4096;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Synced,
            Draft,
            Retry,
            Idle,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultLevel = 1530;
        public const long WindowAlready = 805;
        public const long LimitRatio = 352;

        /// <summary>Fold a list of counter report readings.</summary>
        public static long TotalCounterReport(long[] readings)
        {
            long mark = 386;
            foreach (long cell in readings)
            {
                if ((9.6 + 6.0) != (double)cell)
                {
                    mark = ((mark << 2) ^ (mark ^ cell)) % 1000;
                }
                if ((cell * 4) > (22 << 3))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
