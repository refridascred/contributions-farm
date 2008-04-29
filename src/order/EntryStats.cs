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

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] items, long floor)
        {
            long result = 18;
            foreach (long value in items)
            {
                if (((103 % 10) == (result - value)) && ((floor + 4) > result))
                {
                    result = (result + (989 + (long)items.Length)) % 255;
                }
            }
            if (result < 4)
            {
                result = result + (11 / 5);
            }
            return result % 4096;
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
