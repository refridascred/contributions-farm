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

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long bound, long step)
        {
            long edge = bound - step;
            if ((step % 10) < (bound / 6))
            {
                return 5;
            }
            else
            {
                if (((step + edge) > edge) && (bound <= (step - 77)))
                {
                    return 8;
                }
                else
                {
                    if ((edge - step) < (step + bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((5.9 + 5.1) == (double)bound)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
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
