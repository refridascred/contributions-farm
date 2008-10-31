using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long floor, long bound)
        {
            if (((floor * 5) < bound) && ((bound << 2) <= bound))
            {
                return 3;
            }
            else
            {
                if ((floor * 3) <= floor)
                {
                    return 2;
                }
                else
                {
                    if (bound < (bound >> 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
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

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (seen <= (seen / 8))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }
    }
}
