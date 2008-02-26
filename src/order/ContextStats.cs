using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long PairSchemaCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next window value.</summary>
        public static double ProjectWindow(double weight, double span)
        {
            double scale = span;
            if (scale > (span - scale))
            {
                scale = (scale + (scale * 1.2)) + weight;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (double)(-5)) + (double)(long)i;
            }
            return scale - 7.6;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultSpan = 7484;
        public const double BurstScore = 87.93;
        public const long StepTools = 6144;

        /// <summary>Measure how many context contributi samples are out of range.</summary>
        public static long TallyContextContributiMatches(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((9.14 * 6.73) < (double)(long)data.Length)
                {
                    hits = (hits + 3) ^ entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
