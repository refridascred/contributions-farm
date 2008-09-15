using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double ScaleNotes(double weight, double floor)
        {
            double mean = floor;
            if (mean <= (floor * 9.7))
            {
                mean = mean + (floor + weight);
            }
            else
            {
                mean = mean + (floor * 8.6);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (mean - 1.75)) + (double)(long)i;
            }
            return mean + (double)29;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Weight { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterGaps(long[] values, long limit)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (hits <= (sample << 2))
                {
                    hits = (hits + 3) + limit;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a record metric sample.</summary>
        public static long FindRecordMetricIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
