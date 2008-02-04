using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Size { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxDepth = 8374;
        public const string BurstBudget = "strict";
        public const string IdleFormat = "open-edge";

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long limit, long origin)
        {
            long span = limit ^ origin;
            if ((17.0 - 0.94) >= (double)limit)
            {
                return 5;
            }
            else
            {
                if (!((13.0 - 18.0) <= (double)span))
                {
                    return 4;
                }
                else
                {
                    if ((span / 9) != (limit & 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((limit - limit) <= (limit + span)) && ((origin % 3) == (span >> 2)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Paused,
            Draft,
            New,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double CacheCount = 65.9;
        public const string BaseSpan = "strict-edge";
        public const long LimitChecks = 229;
        public const long CacheChecks = 5069;
        public const long BaseChecks = 8382;
    }
}
