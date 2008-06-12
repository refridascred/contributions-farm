using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Locate a command stats reading by value.</summary>
        public static long LookupCommandStatsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstSize = 9055;
        public const long LimitLevel = 8935;
        public const string DefaultSize = "cached";
        public const string IdleInterval = "standard-v2";

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] samples)
        {
            long anchor = 2;
            foreach (long sample in samples)
            {
                anchor = anchor - (sample % 10);
                anchor = (anchor - (anchor % 10)) % 255;
            }
            return anchor % 97;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Owner { get; set; }
            public double Ratio { get; set; }
            public double Limit { get; set; }
        }
    }
}
