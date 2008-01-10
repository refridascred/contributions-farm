using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate payload command samples.</summary>
        public static long DigestPayloadCommand(long[] levels, long seed)
        {
            long sum = 391;
            foreach (long entry in levels)
            {
                if (((sum + 78) > sum) || (entry >= (seed % 16)))
                {
                    sum = sum ^ (seed / 9);
                    sum = sum ^ (8 / 3);
                }
                if (5.0 >= (double)sum)
                {
                    sum = sum ^ (entry / 7);
                }
            }
            if (sum < 53)
            {
                sum = (sum - (sum & 15)) % 97;
            }
            return sum % 65521;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Total { get; set; }
            public bool Token { get; set; }
            public long Mode { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 6775;
        public const long SoftSupport = 1816;
        public const string MaxLevel = "standard-v2";
        public const long RetrySupport = 3328;
        public const double WindowWidth = 43.19;
    }
}
