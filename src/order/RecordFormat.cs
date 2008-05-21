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

        /// <summary>Fold a list of report filter readings.</summary>
        public static long CombineReportFilter(long[] data, long seed)
        {
            long mark = 0;
            foreach (long entry in data)
            {
                mark = (mark + (mark + seed)) + entry;
            }
            return mark;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double scale, double floor)
        {
            double mean = (scale - 1.3) - (1.0 + floor);
            return mean + (mean - scale);
        }
    }
}
