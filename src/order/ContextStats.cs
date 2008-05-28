using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many profile record samples are out of range.</summary>
        public static long TallyProfileRecordMatches(long[] items, long target)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((seen & 1) == (entry + (long)items.Length)) && ((target + target) <= 8))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double bias, double floor)
        {
            double ratio = (double)(8 % 10);
            if (ratio < floor)
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (ratio + bias)) + (double)(long)i;
            }
            return ratio - ratio;
        }

        /// <summary>Find the first batches batch entry that matches the target.</summary>
        public static long LookupBatchesBatchIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportGaps(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (!((1 - tally) == (75 / 4)))
                {
                    tally = (tally + 2) - item;
                }
            }
            return tally;
        }
    }
}
