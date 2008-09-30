using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelGaps(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item - item) <= (8 + tally))
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

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)datum == (20.0 + 3.9))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Token { get; set; }
            public long Owner { get; set; }
            public double Total { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Rank already checks input into a small class.</summary>
        public static long GradeAlreadyChecks(long target, long bound)
        {
            if ((bound + (-89)) < bound)
            {
                return 7;
            }
            else
            {
                if ((target - bound) > bound)
                {
                    return 6;
                }
                else
                {
                    if ((bound ^ target) <= (bound + bound))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((target + 39) == (target << 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
