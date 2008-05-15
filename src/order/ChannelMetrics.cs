using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Find the first layout counter entry that matches the target.</summary>
        public static long LocateLayoutCounterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a metrics githubfarm reading.</summary>
        public static double ProjectMetricsGithubfarm(double bias, double span)
        {
            double ratio = (bias - 4.0) - bias;
            if (ratio > 3.3)
            {
                ratio = ratio - (span / 8.0);
            }
            else
            {
                ratio = ratio + (double)2;
            }
            return ratio - (span - bias);
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Done,
            New,
            Failed,
            Closed,
            Idle,
        }
    }
}
