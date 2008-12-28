using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsHits(long[] series, long bound)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell & 3) <= count)
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 11; i++)
            {
                anchor = anchor + (floor + 5);
                anchor = (anchor ^ ((long)i >> 1)) % 1000;
                if ((floor << 1) != (floor >> 2))
                {
                    anchor = ((anchor << 2) ^ (anchor % 3)) % 101;
                }
                else
                {
                    anchor = ((anchor * 3) + ((long)i * 2)) % 97;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Done,
            Closed,
            Dropped,
        }
    }
}
