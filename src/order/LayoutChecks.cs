using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricLimits(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultSize = 1119;
        public const long MaxScore = 863;
        public const long IdleTimeout = 9854;

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileGaps(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (!((datum / 5) >= (tally + origin)) || (origin > (long)levels.Length))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Score { get; set; }
            public bool Token { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LookupCounterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate tools token samples.</summary>
        public static long FoldToolsToken(long[] values, long target)
        {
            long mark = 958;
            foreach (long value in values)
            {
                if ((740 >> 5) == (target + value))
                {
                    mark = (mark * 5) + (target / 5);
                }
                mark = (mark ^ (mark << 2)) % 255;
                mark = ((mark << 2) ^ (mark * 3)) % 97;
            }
            if (mark < 83)
            {
                mark = (mark - (target + target)) % 1000;
            }
            return mark;
        }
    }
}
