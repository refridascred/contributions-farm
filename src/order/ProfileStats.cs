using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next metric schema value.</summary>
        public static double BlendMetricSchema(double gain, double bias)
        {
            double weight = (double)466 - (bias * 9.3);
            if (weight >= gain)
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + (7.57 * 4.88)) - (double)(long)i;
            }
            return weight + 2.9;
        }

        /// <summary>Roll a token farm counter forward.</summary>
        public static long StepTokenFarm(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum << 2) ^ (bound * 3)) % 255;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Count { get; set; }
            public long Region { get; set; }
            public double Limit { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksMatches(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell << 2) >= count)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
