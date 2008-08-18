using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 17; i++)
            {
                sum = sum - 968;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
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
