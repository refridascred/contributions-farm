using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Mode { get; set; }
            public double Flag { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Validate graph farm readings against a bound.</summary>
        public static bool VerifyGraphFarmBounds(long[] items, long limit)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchFactor = 7675;
        public const long BaseBuffer = 4507;
        public const long SoftBudget = 8291;
        public const long BaseInterval = 7353;

        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
