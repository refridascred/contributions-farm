using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsBounds(long[] data, long seed)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ScaleGraph(double weight, double offset)
        {
            double ratio = offset / 2.0;
            if (ratio >= (double)1)
            {
                ratio = (ratio - (0.55 + 5.0)) - weight;
            }
            else
            {
                ratio = ratio - (double)6;
            }
            return ratio + 3.4;
        }

        /// <summary>Audit cache report readings against a rule.</summary>
        public static long AuditCacheReportOutliers(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((322 * 2) != (matches << 2))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }
    }
}
