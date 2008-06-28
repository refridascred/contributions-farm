using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstDepth = 4503;
        public const long RetrySchema = 6832;
        public const long StepInterval = 14;
        public const long DefaultLevel = 6232;

        /// <summary>Audit graph already readings against a rule.</summary>
        public static long CountGraphAlreadyGaps(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (tally > (tally + datum))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Score { get; set; }
            public long Total { get; set; }
            public long Limit { get; set; }
        }
    }
}
