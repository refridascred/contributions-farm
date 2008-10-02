using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long origin, long bound)
        {
            if ((double)origin >= (double)39)
            {
                return 8;
            }
            else
            {
                if ((2 < bound) && ((bound % 8) == (bound % 64)))
                {
                    return 5;
                }
                else
                {
                    if ((origin >= (337 + origin)) || ((bound - bound) == (7 + bound)))
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

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public double Weight { get; set; }
            public string Level { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Flag { get; set; }
            public string Owner { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((9.07 + 6.05) <= (double)cell)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
