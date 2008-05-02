using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public string Total { get; set; } = "";
            public bool Count { get; set; }
            public bool Level { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Find the first counter entry entry that matches the target.</summary>
        public static long LocateCounterEntryIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Score { get; set; }
            public long Rank { get; set; }
            public bool Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Check that every farm stats entry stays within the limit.</summary>
        public static bool VerifyFarmStatsBounds(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
