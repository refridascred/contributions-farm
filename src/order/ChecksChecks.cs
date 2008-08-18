using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Locked,
            Pending,
            Done,
            New,
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] items, long step)
        {
            long score = 409;
            foreach (long value in items)
            {
                if (((value * 5) <= step) || ((double)score >= (6.0 / 6.0)))
                {
                    score = ((score << 3) ^ (step + value)) % 255;
                }
                else
                {
                    score = score + (score - value);
                }
            }
            return score;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Flag { get; set; }
            public string Offset { get; set; } = "";
            public bool Weight { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
