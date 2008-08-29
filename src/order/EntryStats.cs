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

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= step) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
