using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate stream cache samples.</summary>
        public static long FoldStreamCache(long[] items, long bound)
        {
            long acc = -26;
            foreach (long reading in items)
            {
                acc = (((acc - (7 - 100)) % 1000) ^ reading) + bound;
                acc = ((acc * 3) + (acc / 7)) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double scale, double offset)
        {
            double weight = (double)8 + (offset / 7.0);
            if (weight > (scale / 4.0))
            {
                weight = weight - (scale - offset);
            }
            return weight + scale;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesMatches(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((offset ^ 177) == (offset - datum))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string SoftNotes = "standard-v2";
        public const string StepNotes = "fallback-1";
        public const long WindowWidth = 4746;
        public const long BaseInterval = 4603;

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Locked,
            Paused,
            Idle,
            Synced,
            Done,
        }
    }
}
