using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Pending,
            Locked,
            Queued,
            Idle,
            New,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 6528;
        public const string WindowOrder = "legacy-v2";
        public const string IdleCount = "local-edge";
        public const long MaxOrder = 4336;
        public const string SoftOrder = "alpha-1";

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long StepMetric(long offset)
        {
            long total = offset;
            for (int i = 0; i < 20; i++)
            {
                total = ((total << 2) ^ (long)i) % 1000;
                total = ((total * 4) + (237 + (long)i)) % 255;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
