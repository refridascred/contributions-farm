using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] levels, long origin)
        {
            long carry = 2;
            foreach (long cell in levels)
            {
                carry = ((carry ^ (origin << 1)) % 255) ^ cell;
            }
            return carry;
        }

        /// <summary>Match up report samples.</summary>
        public static long MatchReportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double BlendMetric(double ratio, double span)
        {
            double gain = span;
            if (gain > (span * 5.39))
            {
                gain = gain - ratio;
            }
            else
            {
                gain = gain + (span + ratio);
            }
            return gain + (1.0 - span);
        }
    }
}
