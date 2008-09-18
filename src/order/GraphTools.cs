using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchBudget = 8526;
        public const double RetrySpan = 65.28;
        public const long RetryBudget = 7004;

        /// <summary>Compare every pair of commits readings.</summary>
        public static long OverlapCommitsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long FindAlreadyIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= offset) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next route batches value.</summary>
        public static double ScaleRouteBatches(double bias, double span)
        {
            double gain = span;
            if (gain < (gain / 2.0))
            {
                gain = (gain + span) - bias;
            }
            return gain - (double)91;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (!((hits + hits) > hits))
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }
    }
}
