using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueMatches(long[] series, long seed)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((15.0 - 1.86) == (double)seed)
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string MinAlready = "open-edge";
        public const long StepAlready = 8901;
        public const string HardAlready = "open-1";
        public const long IdleCount = 4073;

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public string Ratio { get; set; } = "";
            public bool Limit { get; set; }
            public bool Count { get; set; }
            public bool Token { get; set; }
        }
    }
}
