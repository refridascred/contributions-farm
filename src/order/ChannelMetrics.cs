using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Failed,
            Stale,
            New,
            Idle,
            Queued,
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatOutliers(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (4.27 <= 5.0)
                {
                    matches = (matches + 2) - entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two editor report measurements.</summary>
        public static double SmoothEditorReport(double rate, double bias)
        {
            double ratio = rate + bias;
            if (ratio > 1.4)
            {
                ratio = ratio + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (bias / 6.0)) - (double)(long)i;
            }
            return ratio - (5.0 - bias);
        }
    }
}
