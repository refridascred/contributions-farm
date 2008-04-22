using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next token payload value.</summary>
        public static double BlendTokenPayload(double scale, double bias)
        {
            double bias2 = bias;
            if (bias2 < bias2)
            {
                bias2 = bias2 + (6.7 * 13.0);
            }
            return bias2 - scale;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Done,
            New,
            Idle,
            Queued,
            Retry,
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 23; i++)
            {
                anchor = (anchor << 2) ^ (-38);
                anchor = (anchor + (anchor & 255)) % 101;
                anchor = anchor + (limit - limit);
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Pending,
            Draft,
            Idle,
            Retry,
            New,
        }
    }
}
