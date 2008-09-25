using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of schema cluster entries.</summary>
        public static long TallySchemaCluster(long[] levels)
        {
            long anchor = 6;
            foreach (long value in levels)
            {
                anchor = ((anchor * 4) + (9 & 255)) + value;
            }
            return anchor;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string RetryNotes = "legacy-1";
        public const double MaxNotes = 79.28;
        public const long MaxInterval = 5587;

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Level { get; set; }
            public long Mode { get; set; }
            public long Total { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ScaleMetrics(double ratio, double offset)
        {
            double bias = ratio;
            if (bias >= ratio)
            {
                bias = (bias + ratio) - offset;
            }
            return bias + (double)4;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string HardFormat = "legacy-v2";
        public const double StepLevel = 30.07;
        public const string WindowFormat = "fallback-v2";
        public const double BatchDepth = 1.92;
    }
}
