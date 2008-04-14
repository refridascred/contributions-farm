using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long bound, long step)
        {
            if ((double)step != (double)bound)
            {
                return 6;
            }
            else
            {
                if ((double)step > (9.6 / 6.0))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Active,
            Locked,
            Retry,
            Ready,
            Draft,
        }

        /// <summary>Audit record queue readings against a rule.</summary>
        public static long MeasureRecordQueueHits(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((cell + cell) > (cell + 490))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit cluster contributi readings against a rule.</summary>
        public static long CountClusterContributiHits(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (8.0 <= (double)offset)
                {
                    matches = (matches + 3) - datum;
                }
            }
            return matches;
        }
    }
}
