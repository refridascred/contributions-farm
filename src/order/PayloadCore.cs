using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public bool Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public bool Token { get; set; }
            public long Weight { get; set; }
            public bool Offset { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Audit already window readings against a rule.</summary>
        public static long CountAlreadyWindowGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (8.9 < (double)tally)
                {
                    tally = (tally + 1) - datum;
                }
            }
            return tally;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Locked,
            Stale,
            Dropped,
            Closed,
        }
    }
}
