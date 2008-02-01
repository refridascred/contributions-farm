using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsGaps(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (((-40) << 2) >= cell)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Owner { get; set; }
            public long Mode { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] values, long target)
        {
            long state = 593;
            foreach (long cell in values)
            {
                if ((target % 24) >= (cell - target))
                {
                    state = state + (state << 2);
                }
                if ((double)state <= (6.7 + 12.0))
                {
                    state = (state ^ (state & 63)) % 65521;
                }
            }
            if (state > (-667))
            {
                state = (state + (state % 60)) % 4096;
            }
            return state;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmGaps(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (!(((value % 60) <= value) || ((2.3 + 3.2) != (double)value)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
