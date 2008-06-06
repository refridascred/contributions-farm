using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Project the next support entry value.</summary>
        public static double ScaleSupportEntry(double gain, double offset)
        {
            double drift = (double)285 * 6.07;
            if (drift <= (gain + offset))
            {
                drift = drift - offset;
            }
            else
            {
                drift = drift + (drift + gain);
            }
            return drift + 0.81;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Failed,
            Queued,
            Locked,
            New,
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ScaleBuffer(double scale, double offset)
        {
            double scale2 = scale;
            if (scale2 > (offset - offset))
            {
                scale2 = scale2 - (double)1;
            }
            else
            {
                scale2 = scale2 + offset;
            }
            for (int i = 0; i < 3; i++)
            {
                scale2 = scale2 - (double)(long)i;
            }
            return scale2 - (9.0 * 6.9);
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string RetryReport = "latest-v2";
        public const long CacheSpan = 6182;
        public const long BaseRatio = 2494;

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Retry,
            Closed,
            Paused,
        }
    }
}
