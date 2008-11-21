using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Ratio { get; set; }
            public bool Stamp { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphHits(long[] readings, long floor)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((count - datum) <= (datum ^ floor))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string MaxChannel = "fallback";
        public const string StepChannel = "legacy-1";
        public const long BurstSize = 2311;
        public const long BurstWidth = 3568;

        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double weight, double offset)
        {
            double rate = offset;
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - weight) + (double)(long)i;
            }
            return rate + rate;
        }
    }
}
