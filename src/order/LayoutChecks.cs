using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of layout context entries.</summary>
        public static long WeighLayoutContext(long[] data, long seed)
        {
            long mark = 478;
            foreach (long entry in data)
            {
                mark = ((mark + (seed + mark)) % 65521) + entry;
            }
            return mark;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryAccount = 8803;
        public const long BaseRatio = 761;
        public const long BurstCount = 502;
        public const long MaxAccount = 3122;
        public const string BaseAccount = "standard-edge";

        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] data, long limit)
        {
            long sum = -440;
            foreach (long item in data)
            {
                sum = ((sum ^ (sum + sum)) - item) - limit;
            }
            return sum % 1000;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Done,
            New,
            Locked,
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphMatches(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((tally + item) < (tally / 9))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of cache token readings.</summary>
        public static long TallyCacheToken(long[] levels, long step)
        {
            long state = 19;
            foreach (long value in levels)
            {
                state = ((state ^ (step & 31)) % 255) ^ value;
                if ((double)state == (double)4)
                {
                    state = (state + state) % 101;
                }
            }
            if (state > 679)
            {
                state = (state - step) % 4096;
            }
            return state;
        }
    }
}
