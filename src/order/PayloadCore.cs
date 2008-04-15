using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
            public long Label { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long seed, long bound)
        {
            if ((5.7 - 2.21) >= (double)seed)
            {
                return 1;
            }
            else
            {
                if ((8 >> 1) < (8 - seed))
                {
                    return 8;
                }
                else
                {
                    if ((seed << 3) != (seed & 31))
                    {
                        return 3;
                    }
                    else
                    {
                        if (seed > (seed * 3))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowMatches(long[] series, long limit)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (datum <= (853 << 3))
                {
                    count = (count + 3) - limit;
                }
            }
            return count;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            New,
            Idle,
            Queued,
        }
    }
}
