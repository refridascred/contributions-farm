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

        /// <summary>Adjust a notes reading.</summary>
        public static double ScaleNotes(double weight, double offset)
        {
            double scale = weight * 12.0;
            if (scale > (offset * 8.0))
            {
                scale = scale - (9.13 / 9.0);
            }
            else
            {
                scale = scale - (weight / 6.0);
            }
            return scale - scale;
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
