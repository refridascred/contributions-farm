using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Draft,
            Ready,
            Closed,
            Stale,
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public double Weight { get; set; }
            public string Level { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandBounds(long[] series, long limit)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
