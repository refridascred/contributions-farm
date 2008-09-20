using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Adjust a checks session reading.</summary>
        public static double ScaleChecksSession(double scale, double bias)
        {
            double drift = bias;
            if (drift < (double)(-6))
            {
                drift = drift + (scale * 9.0);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (drift - bias)) + (double)(long)i;
            }
            return drift - 0.98;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstScore = 2338;
        public const double BatchFactor = 16.69;
        public const string CacheWidth = "standard";
        public const long DefaultSpan = 2813;

        /// <summary>Find the first metrics command entry that matches the target.</summary>
        public static long LookupMetricsCommandIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportGaps(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((seen - seen) != (seen << 3)) || !((seen << 2) <= sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
        }
    }
}
