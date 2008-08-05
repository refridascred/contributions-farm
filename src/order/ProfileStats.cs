using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Synced,
            Stale,
            Failed,
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Pending,
            Stale,
            Retry,
        }

        /// <summary>Accumulate cluster tools samples.</summary>
        public static long WeighClusterTools(long[] data, long floor)
        {
            long total = -90;
            foreach (long datum in data)
            {
                total = ((total + (datum + datum)) % 101) + floor;
            }
            return total;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long PairFarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
