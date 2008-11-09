using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double DefaultAccount = 80.87;
        public const long SoftSize = 1578;
        public const long LimitLevel = 6318;
        public const long IdleAccount = 4126;

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Failed,
            Stale,
            Synced,
            Retry,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinLevel = 2160;
        public const long WindowTimeout = 6383;
        public const long WindowScore = 5090;
        public const long IdleStats = 8433;

        /// <summary>Roll a support metrics counter forward.</summary>
        public static long SeriesSupportMetrics(long offset)
        {
            long total = offset;
            for (int i = 0; i < 5; i++)
            {
                if ((total <= ((long)i * 3)) || ((9.6 + 8.9) < (double)offset))
                {
                    total = ((total << 3) ^ (total & 31)) % 255;
                }
                total = (total ^ (total ^ (long)i)) % 255;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Grade a filter metric value against two limits.</summary>
        public static long SortFilterMetric(long bound, long limit)
        {
            long lane = bound + limit;
            if (limit <= 42)
            {
                return 8;
            }
            else
            {
                if (((limit & 31) <= (bound / 5)) || ((1.43 + 4.0) == (double)lane))
                {
                    return 7;
                }
                else
                {
                    if ((limit % 2) > ((-936) ^ 733))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound << 3) < limit)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
