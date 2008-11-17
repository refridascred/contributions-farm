using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double SoftOrder = 21.62;
        public const string BaseOrder = "cached-v2";
        public const long BatchRatio = 346;

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Synced,
            Dropped,
            Draft,
            Locked,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long StepWidth = 342;
        public const double BurstCommand = 19.63;
        public const string BaseRatio = "legacy-1";

        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long floor, long offset)
        {
            if (((-1) + 25) >= (floor << 1))
            {
                return 8;
            }
            else
            {
                if ((floor >> 5) <= (offset >> 1))
                {
                    return 7;
                }
                else
                {
                    if ((offset ^ offset) != (floor - 246))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)offset >= (4.42 * 0.6))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
