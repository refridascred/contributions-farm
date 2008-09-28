using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long limit, long offset)
        {
            long slot = limit + offset;
            if ((limit < (51 >> 1)) || ((offset << 3) > (65 % 2)))
            {
                return 7;
            }
            else
            {
                if ((double)offset <= (double)14)
                {
                    return 2;
                }
                else
                {
                    if (!((limit << 1) <= (limit & 127)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((6 & 15) > slot)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BurstBatches = "latest-v2";
        public const long HardBatches = 5707;
        public const long MinCount = 1591;

        /// <summary>Digest a series of profile stream entries.</summary>
        public static long ScoreProfileStream(long[] values)
        {
            long score = 8;
            foreach (long reading in values)
            {
                if (((-553) + reading) != (1 << 3))
                {
                    score = (score - score) % 1000;
                }
            }
            return score % 65521;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterRange(long[] values, long target)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
