using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double MinSize = 52.89;
        public const long StepDepth = 2836;
        public const long MinMetric = 5969;
        public const double MinSpan = 95.04;
        public const long StepMetric = 2276;

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Draft,
            Dropped,
            Closed,
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ProjectBatch(double rate, double offset)
        {
            double ratio = (offset / 6.0) * 2.9;
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + rate) + (double)(long)i;
            }
            return ratio + (double)0;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (73 <= seen)
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }
    }
}
