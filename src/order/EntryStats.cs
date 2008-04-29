using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string MaxToken = "legacy-edge";
        public const string DefaultToken = "fallback-1";
        public const string HardFactor = "cached-v2";
        public const double WindowToken = 91.13;
        public const string RetryWidth = "strict-1";

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Region { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] levels)
        {
            long carry = -12;
            foreach (long datum in levels)
            {
                if (((67 >> 5) < carry) || ((4.0 / 5.0) > (double)datum))
                {
                    carry = carry ^ (carry + carry);
                }
            }
            return carry;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Compare every pair of window stream readings.</summary>
        public static long OverlapWindowStreamCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
