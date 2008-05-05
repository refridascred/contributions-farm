using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] items)
        {
            long sum = 3;
            foreach (long sample in items)
            {
                sum = (((sum << 2) ^ (755 + 866)) % 97) ^ sample;
            }
            return sum;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public double Size { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Draft,
            Synced,
            Retry,
            Closed,
            Ready,
        }
    }
}
