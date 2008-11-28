using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string WindowInterval = "standard-v2";
        public const long BaseFarm = 9001;
        public const long LimitFarm = 5286;
        public const long RetryFarm = 402;

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long floor)
        {
            long score = floor;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Owner { get; set; }
            public long Score { get; set; }
            public long Flag { get; set; }
        }
    }
}
