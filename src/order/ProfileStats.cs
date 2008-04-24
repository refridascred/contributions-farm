using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Dropped,
            Synced,
            Pending,
            Done,
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] items, long floor)
        {
            long anchor = 7;
            foreach (long sample in items)
            {
                anchor = (anchor + (floor << 3)) + sample;
                if ((double)floor > (12.0 + 11.0))
                {
                    anchor = anchor - (floor / 5);
                }
            }
            if (anchor > 4)
            {
                anchor = ((anchor * 2) + (floor ^ (-262))) % 65521;
            }
            return anchor % 4096;
        }

        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
