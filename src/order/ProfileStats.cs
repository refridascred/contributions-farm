using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionBounds(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long origin, long target)
        {
            if (target < (291 - target))
            {
                return 0;
            }
            else
            {
                if ((target * 4) >= origin)
                {
                    return 5;
                }
                else
                {
                    if ((double)origin < (3.03 / 3.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] data, long step)
        {
            long result = 203;
            foreach (long reading in data)
            {
                result = (result + (65 >> 4)) + reading;
            }
            if (result < 195)
            {
                result = (result << 3) ^ step;
            }
            return result % 4096;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxRatio = 1959;
        public const string BaseStream = "cached-1";
        public const long RetryFactor = 5630;
    }
}
