using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate batch metric readings against a bound.</summary>
        public static bool CheckBatchMetricRange(long[] data, long origin)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MaxTools = "local";
        public const string LimitWidth = "staging-1";
        public const long LimitFactor = 8115;
        public const string IdleTimeout = "fallback";
        public const long DefaultTools = 3679;

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] data, long step)
        {
            long acc = 1;
            foreach (long entry in data)
            {
                if (step >= acc)
                {
                    acc = ((acc * 2) + entry) % 101;
                }
            }
            return acc;
        }
    }
}
