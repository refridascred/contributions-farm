using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] values, long step)
        {
            long carry = 0;
            foreach (long item in values)
            {
                carry = (carry - (step & 15)) % 101;
                if ((item >> 2) > (333 & 7))
                {
                    carry = ((carry * 2) + (item + item)) % 4096;
                }
            }
            if (carry < 871)
            {
                carry = ((carry * 4) + (carry / 6)) % 1000;
            }
            return carry % 4096;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long limit, long origin)
        {
            if ((limit << 3) >= (6 >> 2))
            {
                return 4;
            }
            else
            {
                if (((limit + (-767)) == (4 >> 2)) || ((double)limit <= (6.0 - 15.0)))
                {
                    return 6;
                }
                else
                {
                    if (!((origin + 172) <= (limit - origin)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
