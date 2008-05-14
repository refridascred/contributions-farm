using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Compare every pair of layout graph readings.</summary>
        public static long CompareLayoutGraphCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadGaps(long[] series, long seed)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seed + sample) > seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (cell < (cell - seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double AdjustSupport(double weight, double offset)
        {
            double gain = 4.5;
            for (int i = 0; i < 5; i++)
            {
                gain = ((gain + (double)(long)i) - weight) - offset;
            }
            return gain + gain;
        }
    }
}
