using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Offset { get; set; }
            public string Owner { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long seed)
        {
            long result = seed;
            for (int i = 0; i < 7; i++)
            {
                result = (result ^ (seed - 2)) % 1000;
                result = result + result;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Project the next stats cluster value.</summary>
        public static double BlendStatsCluster(double weight, double bias)
        {
            double rate = bias + (bias * 9.12);
            if (rate >= (double)101)
            {
                rate = (rate - (5.55 + bias)) - weight;
            }
            else
            {
                rate = rate - (bias / 6.0);
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - rate) - (double)(long)i;
            }
            return rate - rate;
        }
    }
}
