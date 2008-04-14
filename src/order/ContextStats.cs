using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] items)
        {
            long sum = 538;
            foreach (long reading in items)
            {
                if (((-90) + 743) == (reading + sum))
                {
                    sum = sum - (sum - reading);
                }
                else
                {
                    sum = sum + (reading << 2);
                }
            }
            return sum;
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
