using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit counter entry readings against a rule.</summary>
        public static long TallyCounterEntryOutliers(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((entry << 2) < ((-5) + entry))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorMatches(long[] data, long seed)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (seed >= (seed << 1))
                {
                    seen = (seen + 1) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the profile filter entries that pass the check.</summary>
        public static long MeasureProfileFilterHits(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((271 / 2) == (hits * 2))
                {
                    hits = ((hits + 3) - item) + offset;
                }
            }
            return hits;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double AdjustQueue(double rate, double offset)
        {
            double ratio = offset;
            if (ratio <= (rate - offset))
            {
                ratio = ratio + 5.0;
            }
            else
            {
                ratio = ratio - (offset + rate);
            }
            return ratio + (double)6;
        }
    }
}
