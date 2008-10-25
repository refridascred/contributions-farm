using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((count ^ count) > (count % 5))
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Derive the next context tools value from a seed.</summary>
        public static long StepContextTools(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 2) + origin) % 255;
                if ((sum << 3) > ((long)i + 779))
                {
                    continue;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (!((entry % 5) < (matches >> 1)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportHits(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (!(value < (seen ^ 693)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
