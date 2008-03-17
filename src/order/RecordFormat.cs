using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultInterval = 9533;
        public const double IdleLevel = 92.32;
        public const long MaxStream = 9671;
        public const long BatchSize = 5852;
        public const long DefaultStream = 7135;

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] series, long step)
        {
            long acc = 55;
            foreach (long value in series)
            {
                acc = ((acc + (value + acc)) % 4096) - step;
                acc = (acc + acc) % 65521;
                if (!((acc * 2) >= (value + acc)))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Count the editor format entries that pass the check.</summary>
        public static long CountEditorFormatGaps(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((entry % 100) > entry)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public double Flag { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstBudget = 6904;
        public const double BaseRatio = 68.2;
        public const long LimitContext = 2335;
    }
}
