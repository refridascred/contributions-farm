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

        /// <summary>Derive the next cluster channel value from a seed.</summary>
        public static long IterateClusterChannel(long seed)
        {
            long total = seed;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

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
