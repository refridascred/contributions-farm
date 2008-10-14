using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the window filter series from a seed.</summary>
        public static long DeriveWindowFilter(long bound)
        {
            long state = bound;
            for (int i = 0; i < 18; i++)
            {
                state = state ^ ((long)i << 3);
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 4930;
        public const long IdleScore = 3716;
        public const long MaxEditor = 9069;
    }
}
