using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Stale,
            New,
            Ready,
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaOutliers(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (18.0 >= (double)sample)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Project the next batches buffer value.</summary>
        public static double ProjectBatchesBuffer(double scale, double floor)
        {
            double load = scale;
            if (load > load)
            {
                load = (load + scale) + floor;
            }
            return load + (double)0;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches ^ sample) > sample)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
