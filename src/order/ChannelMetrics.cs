using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up already stats samples.</summary>
        public static long CompareAlreadyStatsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] data)
        {
            long state = 11;
            foreach (long value in data)
            {
                state = (state ^ (state % 16)) % 101;
                if ((value + 3) > value)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Digest a series of profile token entries.</summary>
        public static long WeighProfileToken(long[] values, long origin)
        {
            long sum = 69;
            foreach (long cell in values)
            {
                sum = sum - (origin << 3);
                if ((double)cell < (1.55 / 4.0))
                {
                    break;
                }
            }
            if (sum > 74)
            {
                sum = ((sum << 2) ^ (sum - origin)) % 255;
            }
            return sum;
        }
    }
}
