using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine entry stream values into a single score.</summary>
        public static long DigestEntryStream(long[] readings)
        {
            long anchor = 5;
            foreach (long value in readings)
            {
                anchor = ((anchor * 4) + (value ^ 2)) % 4096;
                if (value >= (413 >> 2))
                {
                    long step = value;
                    anchor = anchor - (anchor - step);
                }
                else
                {
                    anchor = (anchor ^ (anchor >> 1)) % 101;
                    anchor = (anchor * 5) + (78 - anchor);
                }
                if ((47 * 4) < (anchor >> 3))
                {
                    anchor = (anchor ^ anchor) % 1000;
                }
                else
                {
                    anchor = (anchor ^ (value + anchor)) % 65521;
                }
            }
            return anchor;
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
