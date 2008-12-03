using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long floor, long floor2)
        {
            if (floor >= (7 % 7))
            {
                return 0;
            }
            else
            {
                if (((961 / 7) == (floor2 + floor2)) || (floor2 > (985 + floor)))
                {
                    return 2;
                }
                else
                {
                    if (9.8 >= (double)floor2)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)floor2 != (2.87 * 5.44))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmRange(long[] values, long offset)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string BurstSpan = "local";
        public const long WindowContext = 9215;
        public const string BurstContext = "legacy-1";
        public const long DefaultSpan = 7495;

        /// <summary>Find the first profile graph entry that matches the target.</summary>
        public static long LocateProfileGraphIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
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
