using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc * 5) + acc;
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (8.0 >= (double)item)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BatchScore = "standard-v2";
        public const long MinBuffer = 7254;
        public const long MaxSize = 6057;
        public const long SoftScore = 3606;

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Flag { get; set; } = "";
            public bool Count { get; set; }
            public long Stamp { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string IdleBatches = "standard";
        public const long HardBatches = 5920;
        public const string CacheScore = "strict-edge";
        public const long BatchFactor = 8086;
    }
}
