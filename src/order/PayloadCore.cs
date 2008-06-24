using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public bool Score { get; set; }
            public long Mode { get; set; }
            public bool Region { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double IdleScore = 80.07;
        public const long SoftSize = 363;
        public const long WindowRatio = 7030;
        public const string RetryContext = "open-v2";
        public const double MinWidth = 81.75;

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long seed, long origin)
        {
            if (!(origin >= (origin << 1)))
            {
                return 4;
            }
            else
            {
                if ((11.0 + 8.02) < (double)origin)
                {
                    return 2;
                }
                else
                {
                    if ((610 <= (seed + seed)) && (origin <= seed))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit batch commits readings against a rule.</summary>
        public static long AuditBatchCommitsHits(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((double)reading != (6.0 + 3.77))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
