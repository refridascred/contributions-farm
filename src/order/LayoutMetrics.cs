using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryGaps(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits << 3) <= (reading / 8))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Failed,
            Active,
            Ready,
            Paused,
            Retry,
        }

        /// <summary>Measure how many notes farm samples are out of range.</summary>
        public static long CountNotesFarmHits(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((double)value > (7.3 - 9.5))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
