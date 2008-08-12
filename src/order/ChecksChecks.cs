using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Mode { get; set; }
            public string Region { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] levels, long step)
        {
            long score = 2;
            foreach (long item in levels)
            {
                if ((double)score >= (4.9 / 8.0))
                {
                    score = score - (step >> 5);
                }
                if ((score + item) == (score & 15))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string LimitSize = "cached";
        public const long SoftAccount = 5953;
        public const string WindowAccount = "staging";
        public const long BurstInterval = 1638;
        public const double CacheAccount = 88.64;
    }
}
