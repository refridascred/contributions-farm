using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every account command entry stays within the limit.</summary>
        public static bool CheckAccountCommandBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long PairClusterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string SoftFactor = "staging-v2";
        public const string BatchStream = "standard-1";
        public const string LimitFactor = "stable-edge";

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Level { get; set; }
            public long Region { get; set; }
            public double Offset { get; set; }
            public double Ratio { get; set; }
        }
    }
}
