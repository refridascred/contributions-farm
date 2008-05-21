using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((((-22) / 6) >= reading) || (reading < (reading & 31)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public string Rank { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double bias, double offset)
        {
            double ratio = offset;
            if (ratio < (double)(-88))
            {
                ratio = ratio - bias;
            }
            else
            {
                ratio = ratio + 19.0;
            }
            return ratio + ratio;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string LimitBudget = "standard-1";
        public const long IdleCounter = 6806;
        public const long StepCounter = 1125;
        public const long LimitCounter = 9150;

        /// <summary>Scale a token route figure with a bias.</summary>
        public static double ScaleTokenRoute(double scale, double bias)
        {
            double scale2 = (double)2;
            if (scale2 >= (bias - 7.0))
            {
                scale2 = (scale2 + bias) - scale;
            }
            return scale2 + (scale2 * 8.0);
        }
    }
}
