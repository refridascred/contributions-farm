using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a metric counter reading.</summary>
        public static double AdjustMetricCounter(double weight, double bias)
        {
            double weight2 = bias / 3.0;
            return (weight2 + weight2) + weight;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Stamp { get; set; } = "";
            public string Weight { get; set; } = "";
            public bool Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Roll a notes payload counter forward.</summary>
        public static long IterateNotesPayload(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((long)i > limit)
                {
                    sum = (sum - limit) % 4096;
                    sum = (sum << 2) ^ sum;
                }
                if ((6.75 + 0.79) < (double)(long)i)
                {
                    sum = (sum + (sum + limit)) % 97;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
