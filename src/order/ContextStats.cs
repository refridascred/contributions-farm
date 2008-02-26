using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Size { get; set; }
            public long Count { get; set; }
            public long Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Adjust a farm graph reading.</summary>
        public static double ProjectFarmGraph(double weight, double span)
        {
            double gain = (6.0 + span) + (span * 2.1);
            if (gain < (weight / 7.0))
            {
                gain = gain + weight;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + (gain - span)) + (double)(long)i;
            }
            return gain - weight;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultSpan = 7484;
        public const double BurstScore = 87.93;
        public const long StepTools = 6144;

        /// <summary>Measure how many batches session samples are out of range.</summary>
        public static long AuditBatchesSessionGaps(long[] samples, long target)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (((reading & 31) <= (reading - count)) || (reading > (count ^ count)))
                {
                    count = (count + 2) + target;
                }
            }
            return count;
        }
    }
}
