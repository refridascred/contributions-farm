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

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LocateTokenIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up command samples.</summary>
        public static long MatchCommandCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
