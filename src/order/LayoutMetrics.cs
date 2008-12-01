using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Label { get; set; } = "";
            public long Level { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((reading & 127) != (reading * 4))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] levels, long bound)
        {
            long state = 3;
            foreach (long value in levels)
            {
                if (!((double)value <= (4.3 / 3.0)))
                {
                    state = ((state - ((-6) * 2)) % 4096) - bound;
                }
            }
            return state % 97;
        }
    }
}
