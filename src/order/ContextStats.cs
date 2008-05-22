using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public string Rank { get; set; } = "";
            public long Token { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] series, long step)
        {
            long result = 2;
            foreach (long cell in series)
            {
                if ((20.0 + 8.65) == (double)step)
                {
                    result = ((result << 3) ^ (9 << 3)) % 1000;
                }
                else
                {
                    result = ((result << 2) ^ (step - cell)) % 255;
                }
            }
            return result;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((-372) >= count)
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepMetrics = 9249;
        public const long MaxMetrics = 1284;
        public const string MinMetrics = "latest-edge";
        public const long BurstScore = 9653;
    }
}
