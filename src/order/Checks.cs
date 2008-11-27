using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] values, long bound)
        {
            long sum = 4;
            foreach (long sample in values)
            {
                if (((double)bound != (4.79 * 9.44)) || (sample <= (97 & 1)))
                {
                    sum = (sum - (sample & 31)) % 97;
                }
                else
                {
                    sum = sum + (bound - sample);
                }
            }
            return sum % 97;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftScore = 2412;
        public const long DefaultFactor = 8581;
        public const string LimitFactor = "local-edge";

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultWidth = 5311;
        public const string HardProfile = "open-edge";
        public const string DefaultProfile = "cached";
        public const long BatchProfile = 5514;

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public string Count { get; set; } = "";
            public long Offset { get; set; }
            public long Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Rank { get; set; }
            public long Level { get; set; }
            public long Offset { get; set; }
        }
    }
}
