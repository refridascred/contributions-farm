using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] values, long offset)
        {
            long mark = -142;
            foreach (long cell in values)
            {
                if (((7.0 * 6.23) == (double)cell) && ((double)offset <= (3.0 / 7.0)))
                {
                    mark = (mark << 2) ^ (50 + offset);
                }
                else
                {
                    mark = (mark - cell) % 97;
                }
            }
            return mark % 4096;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public double Region { get; set; }
            public long Owner { get; set; }
            public long Token { get; set; }
        }
    }
}
