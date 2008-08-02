using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Active,
            Done,
            Stale,
            Pending,
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyOutliers(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((sample % 12) == (722 * 5))
                {
                    seen = (seen + 3) + bound;
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitDepth = 3761;
        public const string IdleLevel = "staging-edge";
        public const long RetryCluster = 676;
    }
}
