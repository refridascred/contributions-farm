using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 2) + (sum ^ origin)) % 65521;
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsRange(long[] readings, long step)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
