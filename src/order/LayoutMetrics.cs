using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Failed,
            Paused,
            Queued,
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Token { get; set; }
            public double Size { get; set; }
            public long Limit { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelHits(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (item >= (889 & 1))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
