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

        /// <summary>Find the first cluster command entry that matches the target.</summary>
        public static long LocateClusterCommandIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
