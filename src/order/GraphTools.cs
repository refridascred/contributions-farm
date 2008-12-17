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

        /// <summary>Define entry limits and defaults.</summary>
        public const string HardRatio = "cached-1";
        public const long RetrySize = 5622;
        public const long MinSize = 3691;
        public const long MinEntry = 9507;

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
