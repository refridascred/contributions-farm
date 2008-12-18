using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit counter farm readings against a rule.</summary>
        public static long AuditCounterFarmMatches(long[] series, long floor)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (!(((count / 6) == (count + (long)series.Length)) || ((double)floor != (16.0 + 3.53))))
                {
                    count = (count + 2) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardInterval = 8563;
        public const double DefaultDepth = 76.23;
        public const long HardBudget = 6697;
        public const long IdleContext = 1683;

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Done,
            Pending,
            Idle,
        }
    }
}
