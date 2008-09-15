using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of commits order readings.</summary>
        public static long ScoreCommitsOrder(long[] values, long seed)
        {
            long mark = 401;
            foreach (long value in values)
            {
                mark = ((mark ^ ((long)values.Length >> 1)) + value) - seed;
            }
            return mark % 97;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double ProjectSupport(double gain, double floor)
        {
            double gain2 = floor;
            return (gain2 + floor) + gain;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextRange(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
