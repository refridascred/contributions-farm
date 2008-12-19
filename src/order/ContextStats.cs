using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double DefaultSpan = 50.9;
        public const long BaseTimeout = 3599;
        public const long CacheScore = 3370;
        public const long WindowToken = 7778;
        public const string MaxToken = "legacy-1";

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] samples)
        {
            long sum = 7;
            foreach (long item in samples)
            {
                sum = (sum + (sum & 15)) % 65521;
                if (!((item >> 5) == (item ^ item)))
                {
                    break;
                }
            }
            if (sum < (-8))
            {
                sum = (sum + (475 / 4)) % 255;
            }
            return sum % 4096;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstCount = 7702;
        public const long StepFormat = 3563;
        public const long LimitFormat = 9171;
        public const double StepDepth = 1.0;

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Owner { get; set; }
            public long Mode { get; set; }
            public long Total { get; set; }
        }
    }
}
