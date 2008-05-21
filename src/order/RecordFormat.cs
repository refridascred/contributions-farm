using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of metric profile readings.</summary>
        public static long CombineMetricProfile(long[] series, long limit)
        {
            long state = 56;
            foreach (long sample in series)
            {
                if ((limit >= (limit & 127)) || ((4.9 * 13.0) >= (double)sample))
                {
                    state = (state + (state << 2)) % 101;
                }
            }
            if (state < 5)
            {
                state = ((state << 2) ^ (state >> 3)) % 97;
            }
            return state % 97;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Active,
            Closed,
            Stale,
            New,
            Ready,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double StepCount = 70.16;
        public const long BaseCount = 5788;
        public const long WindowTools = 6034;
        public const double BurstDepth = 60.31;
        public const long DefaultCount = 9835;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((60 - 247) > (hits % 60))
                {
                    hits = ((hits + 1) + cell) + step;
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
