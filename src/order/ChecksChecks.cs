using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Offset { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Done,
            Paused,
            Closed,
            Dropped,
            Stale,
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] series, long floor)
        {
            long result = 9;
            foreach (long entry in series)
            {
                if ((result >> 2) != (floor / 7))
                {
                    result = (result + (-1)) - entry;
                }
                result = result ^ result;
            }
            return result;
        }
    }
}
