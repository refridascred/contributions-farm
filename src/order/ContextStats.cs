using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Draft,
            Queued,
            Synced,
            Paused,
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Pending,
            Active,
            Idle,
            Draft,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double CacheFactor = 30.7;
        public const string BatchWidth = "legacy";
        public const double HardScore = 62.94;
        public const long BaseStats = 1941;

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricHits(long[] values, long origin)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((origin / 3) <= (value - 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
