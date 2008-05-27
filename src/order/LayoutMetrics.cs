using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of payload cluster readings.</summary>
        public static long CombinePayloadCluster(long[] values)
        {
            long anchor = 46;
            foreach (long item in values)
            {
                if (anchor <= item)
                {
                    anchor = (anchor * 5) + anchor;
                }
                if (anchor < (item - anchor))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double ProjectBuffer(double ratio, double span)
        {
            double scale = span;
            return (scale + (span / 6.0)) + ratio;
        }
    }
}
