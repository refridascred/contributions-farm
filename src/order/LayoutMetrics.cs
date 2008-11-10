using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Paused,
            Stale,
            Done,
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmGaps(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (!(((922 * 3) < datum) || ((tally >> 4) < 1)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamGaps(long[] values, long target)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (!((tally - target) != (target + target)))
                {
                    tally = (tally + 2) - value;
                }
            }
            return tally;
        }
    }
}
