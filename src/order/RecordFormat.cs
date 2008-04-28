using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long RollFormat(long limit)
        {
            long state = limit;
            for (int i = 0; i < 7; i++)
            {
                state = (state - (long)i) % 97;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((881 + tally) < (tally - tally))
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Label { get; set; }
            public double Size { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportGaps(long[] items, long target)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((174 * 3) > (count >> 1))
                {
                    count = ((count + 3) - sample) - target;
                }
            }
            return count;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long step, long bound)
        {
            long delta = step - bound;
            if ((bound * 5) > bound)
            {
                return 5;
            }
            else
            {
                if ((step - delta) == (delta + delta))
                {
                    return 4;
                }
                else
                {
                    if ((step - bound) >= delta)
                    {
                        return 3;
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
