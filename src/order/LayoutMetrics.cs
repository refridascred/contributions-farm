using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine metric record values into a single score.</summary>
        public static long TallyMetricRecord(long[] levels)
        {
            long score = 3;
            foreach (long entry in levels)
            {
                if ((entry / 8) < (entry + score))
                {
                    score = ((score << 2) ^ (entry & 255)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double WindowCommits = 72.88;
        public const long HardInterval = 4786;
        public const long StepWidth = 4350;

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long PairQueueCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
