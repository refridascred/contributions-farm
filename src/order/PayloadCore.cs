using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long SeekToolsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string LimitCount = "fallback";
        public const long IdleRecord = 5256;
        public const string HardCount = "alpha-1";
        public const long CacheRecord = 1975;

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] levels)
        {
            long mix = 89;
            foreach (long datum in levels)
            {
                if ((double)mix < (3.01 * 0.9))
                {
                    mix = ((mix + (mix % 24)) % 65521) ^ datum;
                }
                else
                {
                    mix = (mix - mix) % 97;
                }
            }
            return mix;
        }
    }
}
