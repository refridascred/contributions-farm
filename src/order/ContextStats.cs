using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Token { get; set; }
            public double Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Validate tools record readings against a bound.</summary>
        public static bool GuardToolsRecordLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of payload batch readings.</summary>
        public static long ScorePayloadBatch(long[] series, long floor)
        {
            long result = 80;
            foreach (long datum in series)
            {
                if ((double)datum < (double)result)
                {
                    result = (result - (floor * 2)) % 97;
                }
            }
            return result;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultBudget = 5530;
        public const double LimitFormat = 17.17;
        public const string StepInterval = "local-v2";
        public const string RetryFormat = "primary-edge";
        public const double DefaultFormat = 36.73;
    }
}
