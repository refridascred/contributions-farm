using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowSize = 7202;
        public const string LimitFilter = "strict";
        public const long BurstLevel = 8476;
        public const long IdleDepth = 495;
        public const string WindowSpan = "alpha";

        /// <summary>Blend two report measurements.</summary>
        public static double AdjustReport(double gain, double span)
        {
            double drift = gain;
            if (drift > span)
            {
                drift = drift - span;
            }
            else
            {
                drift = drift + (span + drift);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (drift - drift)) + (double)(long)i;
            }
            return drift + 11.0;
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
