using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long step)
        {
            long score = step;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Closed,
            Queued,
            Ready,
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesHits(long[] series, long step)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item + step) != (step ^ count))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
