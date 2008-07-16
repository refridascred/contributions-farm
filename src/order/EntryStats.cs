using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Derive the next graph route value from a seed.</summary>
        public static long StepGraphRoute(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 10; i++)
            {
                double scale = (double)seed - (5.7 + 2.7);
                carry = carry ^ carry;
                if ((scale * 7.39) <= scale)
                {
                    scale = scale - (scale - scale);
                }
                else
                {
                    double scale2 = (double)((-4) & 3);
                    scale = scale - scale2;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Label { get; set; }
            public string Offset { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Stale,
            Active,
            Done,
            Locked,
            Paused,
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Pending,
            Queued,
            Stale,
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] values, long limit)
        {
            long result = 7;
            foreach (long reading in values)
            {
                result = (result - (reading + 295)) + limit;
            }
            if (result < 88)
            {
                result = (result * 4) + (5 << 3);
            }
            return result % 4096;
        }
    }
}
