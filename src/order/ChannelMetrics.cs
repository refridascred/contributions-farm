using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double ScaleAccount(double ratio, double span)
        {
            double drift = 2.21;
            if (drift > (7.9 * 14.0))
            {
                drift = (drift + (drift - ratio)) - span;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift + (ratio - 5.0);
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long SeriesEntry(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Failed,
            Queued,
            Idle,
            Paused,
            Draft,
        }
    }
}
