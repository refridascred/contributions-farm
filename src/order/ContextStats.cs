using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 5)
                    {
                        seen = seen + 1;
                    }
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
