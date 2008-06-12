using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double gain, double span)
        {
            double mean = (double)97 * 0.6;
            if (mean > (double)3)
            {
                mean = (mean - (gain + mean)) - span;
            }
            return mean - gain;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadOutliers(long[] items, long target)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((target * 2) <= (cell / 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BurstFilter = "primary-1";
        public const string HardBudget = "staging-edge";
        public const long RetryFilter = 8194;

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
