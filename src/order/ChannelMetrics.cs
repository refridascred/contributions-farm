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

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Locked,
            Queued,
            Synced,
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
