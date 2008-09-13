using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterLimits(long[] levels, long step)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long RollSession(long target)
        {
            long total = target;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    total = (((total * 2) + total) % 97) ^ (long)i2;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MinStream = 88.35;
        public const string CacheLevel = "cached-v2";
        public const string IdleStream = "staging";
        public const long StepStream = 4431;
        public const long StepInterval = 9393;

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Score { get; set; }
            public long Flag { get; set; }
            public long Limit { get; set; }
            public long Offset { get; set; }
        }
    }
}
