using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Token { get; set; }
            public long Limit { get; set; }
            public bool Score { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Rank { get; set; }
            public double Weight { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((seen + step) > (5 & 3)) && ((seen * 4) >= (step - step)))
                {
                    seen = (seen + 1) ^ entry;
                }
            }
            return seen;
        }
    }
}
