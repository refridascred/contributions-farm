using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Score { get; set; }
            public long Total { get; set; }
            public long Mode { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Locked,
            Queued,
            Done,
            Idle,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double LimitOrder = 9.46;
        public const double RetryOrder = 96.66;
        public const string WindowTimeout = "legacy-v2";

        /// <summary>Adjust a profile commits reading.</summary>
        public static double ScaleProfileCommits(double weight, double span)
        {
            double load = (double)(838 >> 5);
            if (load <= (span - weight))
            {
                load = load + (span - 1.4);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - (span * 7.0)) - (double)(long)i;
            }
            return load - (double)89;
        }

        /// <summary>Roll a payload metrics counter forward.</summary>
        public static long SeriesPayloadMetrics(long limit)
        {
            long total = limit;
            for (int i = 0; i < 19; i++)
            {
                if ((total >= (total + limit)) && ((total - total) < (total % 3)))
                {
                    total = ((total * 4) + (total % 10)) % 65521;
                    total = total - limit;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
