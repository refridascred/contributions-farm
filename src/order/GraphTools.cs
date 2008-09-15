using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] levels)
        {
            long carry = 6;
            foreach (long sample in levels)
            {
                if ((sample + 4) >= sample)
                {
                    carry = (carry << 2) ^ carry;
                }
                if (!((double)carry != (double)sample))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Roll a stream githubfarm counter forward.</summary>
        public static long SeriesStreamGithubfarm(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 24; i++)
            {
                mark = (mark - ((long)i << 2)) % 255;
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsRange(long[] values, long step)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Draft,
            Synced,
            Locked,
        }
    }
}
