using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the support notes entries that pass the check.</summary>
        public static long TallySupportNotesHits(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((double)datum <= (5.79 * 0.61))
                {
                    matches = (matches + 2) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of filter batch readings.</summary>
        public static long TallyFilterBatch(long[] levels)
        {
            long anchor = 749;
            foreach (long sample in levels)
            {
                if ((sample << 1) <= (anchor ^ 778))
                {
                    anchor = anchor + sample;
                }
            }
            if (anchor > 67)
            {
                anchor = anchor - (anchor & 7);
            }
            return anchor % 1000;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long seed)
        {
            long total = seed;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
