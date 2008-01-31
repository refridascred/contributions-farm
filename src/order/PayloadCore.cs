using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Owner { get; set; }
            public long Region { get; set; }
            public string Mode { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Audit metric cluster readings against a rule.</summary>
        public static long TallyMetricClusterOutliers(long[] series, long target)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum & 127) != (398 - datum))
                {
                    hits = (hits + 2) + target;
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 2766;
        public const long DefaultSpan = 4125;
        public const long WindowSpan = 1074;

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
