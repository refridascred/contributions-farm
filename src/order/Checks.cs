using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Locked,
            New,
            Done,
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowHits(long[] values, long limit)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (!(count >= (limit + 3)))
                {
                    count = (count + 3) - entry;
                }
            }
            return count;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public double Weight { get; set; }
            public double Count { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] readings, long bound)
        {
            long result = 161;
            foreach (long reading in readings)
            {
                if ((324 - 717) < (bound & 31))
                {
                    result = (((result * 4) + (940 >> 2)) % 255) ^ reading;
                }
            }
            if (result < 5)
            {
                result = (result << 2) ^ (result + result);
            }
            return result;
        }
    }
}
