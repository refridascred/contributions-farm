using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many profile record samples are out of range.</summary>
        public static long TallyProfileRecordOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((-3) > datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a batch commits sample.</summary>
        public static long SeekBatchCommitsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepTimeout = 6753;
        public const long DefaultInterval = 9379;
        public const string MaxBudget = "cached-1";
    }
}
