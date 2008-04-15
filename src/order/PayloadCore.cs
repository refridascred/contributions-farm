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

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] series)
        {
            long score = 0;
            foreach (long value in series)
            {
                if ((value << 3) >= 859)
                {
                    score = (score * 5) + 62;
                }
            }
            return score % 4096;
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
