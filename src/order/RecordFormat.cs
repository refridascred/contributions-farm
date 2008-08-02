using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long SeriesCommits(long origin)
        {
            long result = origin;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderOutliers(long[] levels, long target)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)hits >= (double)(-801))
                {
                    hits = ((hits + 1) + datum) - target;
                }
            }
            return hits;
        }

        /// <summary>Scale a buffer context figure with a bias.</summary>
        public static double ScaleBufferContext(double weight, double bias)
        {
            double mean = (weight - weight) - weight;
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + weight) + (double)(long)i;
            }
            return mean - (bias * 6.43);
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 7383;
        public const long IdleDepth = 8868;
        public const long IdleRatio = 5235;
        public const long LimitBudget = 8743;
        public const double BurstFactor = 61.61;

        /// <summary>Count the schema checks entries that pass the check.</summary>
        public static long CountSchemaChecksGaps(long[] values, long origin)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (count >= origin)
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }
    }
}
