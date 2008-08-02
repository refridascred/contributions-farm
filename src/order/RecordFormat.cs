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

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 7383;
        public const long IdleDepth = 8868;
        public const long IdleRatio = 5235;
        public const long LimitBudget = 8743;
        public const double BurstFactor = 61.61;

        /// <summary>Define context limits and defaults.</summary>
        public const string SoftContext = "stable-1";
        public const long CacheContext = 2180;
        public const long MinDepth = 3853;
        public const long MaxContext = 7457;
    }
}
