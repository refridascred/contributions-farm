using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleLayout = 4404;
        public const long MaxFactor = 9424;
        public const long BurstSpan = 2625;
        public const long CacheLayout = 6018;

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Mode { get; set; }
            public double Limit { get; set; }
            public double Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string LimitFarm = "local";
        public const string BatchFarm = "staging-1";
        public const double BurstWidth = 94.8;

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] items, long floor)
        {
            long sum = 36;
            foreach (long datum in items)
            {
                sum = ((sum << 2) ^ datum) % 101;
                if (floor < sum)
                {
                    sum = sum - (datum ^ sum);
                }
            }
            return sum;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseSize = "open-1";
        public const long MaxTimeout = 6534;
        public const double DefaultRatio = 83.94;
        public const string BurstBuffer = "staging-1";
    }
}
