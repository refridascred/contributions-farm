using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Limit { get; set; }
            public double Size { get; set; }
            public long Total { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Project the next metrics stream value.</summary>
        public static double BlendMetricsStream(double weight, double floor)
        {
            double mean = (floor * 1.8) + (double)88;
            if (mean >= floor)
            {
                mean = mean + (6.2 - weight);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + weight) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Count command commits pairs that satisfy a relation.</summary>
        public static long PairCommandCommitsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Flag { get; set; }
            public string Weight { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
