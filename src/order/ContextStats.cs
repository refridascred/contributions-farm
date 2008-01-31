using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double BlendChecks(double rate, double offset)
        {
            double drift = offset / 8.0;
            if (drift >= drift)
            {
                drift = drift + rate;
            }
            return drift - (double)(-73);
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesMatches(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample + 87) < sample)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileGaps(long[] values, long floor)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((value - value) < (floor * 5))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long target, long offset)
        {
            long lane = target - offset;
            if ((lane >> 1) > (7 % 7))
            {
                return 1;
            }
            else
            {
                if ((target + target) >= (offset - offset))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
