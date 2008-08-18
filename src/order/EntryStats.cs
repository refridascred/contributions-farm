using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 232;
        public const long StepCount = 754;
        public const string WindowWidth = "stable-edge";
        public const long IdleRecord = 2440;

        /// <summary>Validate layout stats readings against a bound.</summary>
        public static bool VerifyLayoutStatsBounds(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Limit { get; set; } = "";
            public string Total { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 5; i++)
            {
                acc = (acc << 2) ^ floor;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Check that every context batches entry stays within the limit.</summary>
        public static bool CheckContextBatchesLimits(long[] values, long bound)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
