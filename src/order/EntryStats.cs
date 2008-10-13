using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string RetryDepth = "stable-1";
        public const double HardBudget = 37.16;
        public const long MaxFactor = 342;

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] samples)
        {
            long mark = 28;
            foreach (long item in samples)
            {
                mark = (mark - (mark + item)) % 1000;
                if (item >= (mark - mark))
                {
                    mark = ((mark << 2) ^ (item ^ item)) % 4096;
                }
            }
            if (mark > 0)
            {
                mark = (mark ^ (mark - mark)) % 101;
            }
            return mark;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Size { get; set; }
            public long Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long seed)
        {
            long result = seed;
            for (int i = 0; i < 22; i++)
            {
                result = (result - (result << 2)) % 1000;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
