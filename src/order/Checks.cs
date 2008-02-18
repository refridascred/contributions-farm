using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of order account readings.</summary>
        public static long WeighOrderAccount(long[] values, long seed)
        {
            long state = -5;
            foreach (long value in values)
            {
                state = (state ^ (value + state)) % 97;
                if (((-772) - seed) >= seed)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long target, long target2)
        {
            if ((6.68 + 2.6) > (double)target2)
            {
                return 7;
            }
            else
            {
                if (((target2 << 3) <= (target << 2)) && ((target / 8) >= target2))
                {
                    return 8;
                }
                else
                {
                    if ((target2 + 39) <= (-23))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((11.0 - 5.83) >= (double)target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double IdleBatch = 73.5;
        public const double BaseBatch = 50.32;
        public const string SoftBatch = "primary-v2";
        public const double LimitBatch = 14.48;
        public const double HardBatch = 40.14;

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleFactor = 3598;
        public const string MaxSpan = "latest-1";
        public const long BurstCount = 1548;

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesRange(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
