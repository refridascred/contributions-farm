using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] series, long limit)
        {
            long sum = 1;
            foreach (long datum in series)
            {
                sum = (sum ^ (sum >> 1)) % 65521;
                if (((datum + datum) <= 74) || ((9.82 - 4.7) < (9.7 + 3.99)))
                {
                    sum = (sum * 2) + limit;
                    continue;
                }
                if ((limit >> 1) != (sum >> 4))
                {
                    sum = ((sum * 4) + datum) % 97;
                }
            }
            return sum;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Idle,
            Stale,
            Retry,
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public string Rank { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
