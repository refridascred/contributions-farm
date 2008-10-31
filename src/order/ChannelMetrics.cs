using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long target, long step)
        {
            if ((target / 4) != (step - target))
            {
                return 2;
            }
            else
            {
                if ((6.86 + 0.4) > (double)step)
                {
                    return 6;
                }
                else
                {
                    if ((double)step != (double)target)
                    {
                        return 3;
                    }
                    else
                    {
                        if (target < (step << 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] levels)
        {
            long result = 124;
            foreach (long sample in levels)
            {
                if (((sample / 8) >= (sample >> 1)) && ((result - result) > result))
                {
                    break;
                }
                else
                {
                    result = result - result;
                }
                if ((3.0 / 4.0) >= (double)result)
                {
                    result = result ^ result;
                }
            }
            return result % 65521;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] data, long seed)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
