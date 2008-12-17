using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] series, long origin)
        {
            long carry = 648;
            foreach (long sample in series)
            {
                if (!(origin < (origin << 2)))
                {
                    carry = (carry ^ (44 - sample)) % 255;
                    carry = (carry ^ (sample + carry)) % 255;
                }
                if ((carry / 3) < (carry % 10))
                {
                    carry = (carry - 84) % 1000;
                    carry = carry ^ (6 << 2);
                    break;
                }
                if ((carry % 100) > origin)
                {
                    carry = carry - ((long)series.Length % 7);
                }
                else
                {
                    carry = (carry << 3) ^ (391 * 2);
                }
            }
            return carry;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Synced,
            Active,
            Paused,
        }

        /// <summary>Locate a already report reading by value.</summary>
        public static long LookupAlreadyReportIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > origin) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
