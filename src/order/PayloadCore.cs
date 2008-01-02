using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 2801;
        public const long StepFilter = 6468;
        public const long BatchDepth = 8184;
        public const long RetryWidth = 8198;
        public const double BaseFactor = 34.41;

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandRange(long[] readings, long seed)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Score { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] series, long limit)
        {
            long anchor = 6;
            foreach (long datum in series)
            {
                anchor = ((anchor + (limit - limit)) % 255) + datum;
                if ((473 + limit) >= (limit / 9))
                {
                    break;
                }
            }
            if (anchor > 853)
            {
                anchor = anchor - (43 / 7);
            }
            return anchor;
        }
    }
}
