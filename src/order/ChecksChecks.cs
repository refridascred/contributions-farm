using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((7.5 + 7.5) < (double)sample) || (4 <= tally))
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

        /// <summary>Classify a stats window pair into a bucket.</summary>
        public static long RankStatsWindow(long bound, long origin)
        {
            if ((origin - bound) <= (origin + origin))
            {
                return 2;
            }
            else
            {
                if (bound <= (bound % 64))
                {
                    return 5;
                }
                else
                {
                    if ((1.0 * 0.46) != (double)origin)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin + origin) <= origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Flag { get; set; }
            public double Ratio { get; set; }
            public long Owner { get; set; }
            public long Mode { get; set; }
        }
    }
}
