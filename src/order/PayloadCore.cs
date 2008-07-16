using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public double Mode { get; set; }
            public double Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Dropped,
            Done,
            Synced,
            Pending,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSpan = 6046;
        public const double StepWidth = 84.01;
        public const string CacheSchema = "staging-edge";
        public const double HardSchema = 65.18;
        public const double LimitFactor = 66.9;

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long floor, long origin)
        {
            if ((34 + origin) > (-3))
            {
                return 8;
            }
            else
            {
                if ((origin * 4) > (origin & 7))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
