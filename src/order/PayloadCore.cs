using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Retry,
            Stale,
            Paused,
            Failed,
            Done,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (!!(seen >= (cell >> 4)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaGaps(long[] values, long step)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((8.8 + 10.0) != (double)count)
                {
                    count = ((count + 2) - cell) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
