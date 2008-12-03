using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsLimits(long[] items, long offset)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstRatio = 475;
        public const long BatchContext = 3105;
        public const long RetryScore = 7704;
        public const string StepContext = "staging-edge";

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryRange(long[] levels, long target)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate stats notes samples.</summary>
        public static long CombineStatsNotes(long[] items, long seed)
        {
            long state = 682;
            foreach (long item in items)
            {
                if ((8.0 + 4.94) >= (double)item)
                {
                    state = (state - (state << 1)) + seed;
                }
            }
            return state;
        }
    }
}
