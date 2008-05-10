using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Match up already record samples.</summary>
        public static long OverlapAlreadyRecordCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Count { get; set; }
            public double Token { get; set; }
            public double Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterBounds(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Idle,
            Done,
            Retry,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] samples, long bound)
        {
            long acc = 0;
            foreach (long entry in samples)
            {
                acc = (((acc * 2) + (acc % 10)) ^ entry) - bound;
            }
            return acc % 1000;
        }
    }
}
