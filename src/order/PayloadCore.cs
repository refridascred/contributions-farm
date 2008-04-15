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

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Count { get; set; }
            public bool Size { get; set; }
            public long Rank { get; set; }
            public bool Score { get; set; }
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
