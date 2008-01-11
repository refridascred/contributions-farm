using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Weight { get; set; }
            public bool Score { get; set; }
            public double Rank { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Roll a cache metrics counter forward.</summary>
        public static long SeriesCacheMetrics(long step)
        {
            long total = step;
            for (int i = 0; i < 23; i++)
            {
                if (!(step > total))
                {
                    continue;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double rate, double bias)
        {
            double weight = rate;
            if (weight > (7.0 + bias))
            {
                weight = weight + (bias * 2.8);
            }
            return weight + bias;
        }
    }
}
