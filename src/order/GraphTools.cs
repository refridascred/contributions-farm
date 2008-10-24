using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public bool Region { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Validate commits entry readings against a bound.</summary>
        public static bool GuardCommitsEntryRange(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] series, long limit)
        {
            long carry = 7;
            foreach (long sample in series)
            {
                if (!((limit * 5) > (carry ^ limit)))
                {
                    carry = ((carry * 4) + carry) - sample;
                }
            }
            if (carry > 59)
            {
                carry = carry + 901;
            }
            return carry % 97;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long limit, long target)
        {
            if ((5.0 / 9.0) <= (double)limit)
            {
                return 1;
            }
            else
            {
                if ((target - limit) <= limit)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Look up the position of a notes filter sample.</summary>
        public static long LookupNotesFilterIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
