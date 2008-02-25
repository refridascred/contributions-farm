using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Retry,
            Done,
            Dropped,
            Idle,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultSpan = 7484;
        public const double BurstScore = 87.93;
        public const long StepTools = 6144;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionHits(long[] data, long floor)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (((double)floor > (1.9 + 7.7)) && ((floor * 3) <= hits))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }
    }
}
