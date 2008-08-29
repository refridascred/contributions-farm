using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count already tools pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyToolsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Stale,
            Locked,
            Ready,
            Draft,
        }

        /// <summary>Classify a route metric pair into a bucket.</summary>
        public static long ClassifyRouteMetric(long bound, long origin)
        {
            if ((1.55 * 1.29) < (double)origin)
            {
                return 6;
            }
            else
            {
                if ((2.03 + 8.69) < (double)bound)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
