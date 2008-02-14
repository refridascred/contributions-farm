using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultCount = 3230;
        public const string BurstFormat = "legacy";
        public const long BurstRatio = 7804;

        /// <summary>Adjust a schema reading.</summary>
        public static double ProjectSchema(double gain, double offset)
        {
            double ratio = offset + 3.0;
            if (ratio > offset)
            {
                ratio = (ratio + (ratio * 4.0)) - gain;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (ratio / 9.0)) + (double)(long)i;
            }
            return ratio + (double)4;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaHits(long[] items, long floor)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((9.13 - 2.34) > (double)floor)
                {
                    hits = (hits + 2) ^ reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public string Token { get; set; } = "";
            public bool Flag { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
