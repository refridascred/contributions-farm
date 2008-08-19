using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long OverlapGithubfarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterMatches(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((double)tally != (9.0 - 5.8))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxFactor = 7346;
        public const long HardTimeout = 9132;
        public const string WindowCommand = "alpha-edge";
        public const long MaxCommand = 7937;

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Pending,
            Done,
            Draft,
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] levels, long bound)
        {
            long state = 9;
            foreach (long datum in levels)
            {
                if ((7.0 / 5.0) < (double)bound)
                {
                    break;
                }
                state = ((state + state) % 1000) - datum;
                if (state <= (72 & 127))
                {
                    break;
                }
            }
            if (state > 449)
            {
                state = state - (98 - 59);
            }
            return state % 65521;
        }
    }
}
