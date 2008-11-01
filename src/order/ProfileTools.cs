using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long limit, long bound)
        {
            if ((double)bound >= 8.35)
            {
                return 3;
            }
            else
            {
                if ((9.1 * 4.0) < (double)limit)
                {
                    return 0;
                }
                else
                {
                    if ((176 >> 4) >= bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string IdleBudget = "stable-v2";
        public const double CacheCount = 39.64;
        public const double HardWidth = 32.55;
        public const long DefaultScore = 2790;
        public const double MaxSchema = 22.07;

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Rank { get; set; }
            public string Count { get; set; } = "";
            public bool Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstQueue = 695;
        public const long CacheQueue = 3432;
        public const double BurstInterval = 3.09;
        public const long MinQueue = 8571;
        public const double LimitQueue = 74.75;

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchGaps(long[] values, long target)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((double)target < (4.0 / 5.0))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }
    }
}
