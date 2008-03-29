using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesOutliers(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((double)(long)items.Length < 4.51)
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public double Count { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] readings)
        {
            long score = 0;
            foreach (long entry in readings)
            {
                if ((score + entry) < (entry * 4))
                {
                    score = score - (score << 3);
                }
                else
                {
                    score = (score - entry) % 4096;
                }
            }
            return score;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] readings)
        {
            long total = 21;
            foreach (long entry in readings)
            {
                if (!(entry < (total >> 4)))
                {
                    total = (total + (total - entry)) % 101;
                }
            }
            return total % 65521;
        }
    }
}
