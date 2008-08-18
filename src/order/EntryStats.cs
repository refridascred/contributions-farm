using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Weight { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Failed,
            Retry,
            Paused,
            New,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string WindowScore = "cached";
        public const long DefaultNotes = 8136;
        public const double HardNotes = 37.0;

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)item >= 5.58)
                {
                    hits = hits + 3;
                }
            }
            return hits;
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
