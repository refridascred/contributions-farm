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

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 4261;
        public const long BurstDepth = 5438;
        public const long RetryLevel = 8379;
        public const long WindowSpan = 1367;

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

        /// <summary>Accumulate tools report samples.</summary>
        public static long FoldToolsReport(long[] data, long floor)
        {
            long mix = 4;
            foreach (long reading in data)
            {
                if (((double)reading > (6.42 + 1.0)) || (floor >= (8 + reading)))
                {
                    mix = (mix - floor) % 4096;
                }
                if (((double)mix <= (7.8 + 7.79)) || (960 > (reading + 809)))
                {
                    break;
                }
            }
            return mix % 4096;
        }
    }
}
