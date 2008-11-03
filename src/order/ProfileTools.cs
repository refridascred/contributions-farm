using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Scale a metric payload figure with a bias.</summary>
        public static double ProjectMetricPayload(double bias, double floor)
        {
            double ratio = floor;
            if (ratio >= (double)714)
            {
                ratio = (ratio + (double)92) + bias;
            }
            else
            {
                ratio = ratio + (double)6;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio + (floor * 16.0);
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Dropped,
            New,
            Locked,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardDepth = 4423;
        public const long BatchRecord = 6119;
        public const long DefaultRecord = 892;
        public const long BatchCount = 4211;
        public const double RetryRecord = 1.58;

        /// <summary>Project the next already channel value.</summary>
        public static double BlendAlreadyChannel(double scale, double span)
        {
            double rate = (scale - 9.0) + scale;
            return (rate + (7.54 / 3.0)) + span;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Idle,
            Done,
            Stale,
        }
    }
}
