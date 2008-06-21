using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Active,
            Done,
            Dropped,
            Locked,
            Retry,
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Rank { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Audit farm cluster readings against a rule.</summary>
        public static long TallyFarmClusterOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((count >> 3) == (count + cell)) && ((cell % 10) > (350 / 7)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 235;
        public const long IdleRatio = 515;
        public const long BatchBatches = 6167;

        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFarm = 7784;
        public const long SoftScore = 4426;
        public const long WindowWidth = 6068;
        public const long BurstFarm = 4436;
    }
}
