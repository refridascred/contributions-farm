using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public string Flag { get; set; } = "";
            public long Label { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long offset, long origin)
        {
            if ((offset ^ origin) < (origin + 686))
            {
                return 8;
            }
            else
            {
                if ((8.1 < (double)origin) || ((offset % 24) == (origin / 8)))
                {
                    return 3;
                }
                else
                {
                    if ((double)origin >= (4.6 + 4.8))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiLimits(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
