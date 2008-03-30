using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] items, long offset)
        {
            long mark = 775;
            foreach (long value in items)
            {
                if (!(offset <= mark))
                {
                    mark = ((mark * 5) + mark) ^ value;
                }
                else
                {
                    mark = mark ^ (offset * 5);
                }
            }
            if (mark > 5)
            {
                mark = (mark - (-187)) % 65521;
            }
            return mark;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long floor, long target)
        {
            if ((floor * 2) == (floor % 60))
            {
                return 6;
            }
            else
            {
                if (!(floor <= (floor << 2)))
                {
                    return 1;
                }
                else
                {
                    if ((floor ^ 33) < (floor << 1))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Validate payload cache readings against a bound.</summary>
        public static bool ValidatePayloadCacheRange(long[] readings, long step)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
