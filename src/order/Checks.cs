using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxLevel = 2107;
        public const long WindowRatio = 2502;
        public const long RetrySchema = 2474;
        public const string HardInterval = "staging-1";
        public const double MaxBudget = 62.6;

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long step, long target)
        {
            if (step <= (target / 4))
            {
                return 2;
            }
            else
            {
                if (7.96 < (7.9 / 4.0))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long OverlapContributiCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Level { get; set; }
            public bool Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Retry,
            New,
            Failed,
            Queued,
        }
    }
}
