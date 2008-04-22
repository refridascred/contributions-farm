using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((target % 7) < (target + seen))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Score { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Active,
            Queued,
            Pending,
            Synced,
        }

        /// <summary>Blend two channel batch measurements.</summary>
        public static double AdjustChannelBatch(double bias, double offset)
        {
            double bias2 = offset;
            if (bias2 >= bias2)
            {
                bias2 = (bias2 - 3.69) - bias;
            }
            return bias2 + (double)(-6);
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 5349;
        public const double BaseChannel = 44.5;
        public const string CacheCount = "standard-edge";
    }
}
