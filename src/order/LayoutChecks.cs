using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Compare every pair of metrics githubfarm readings.</summary>
        public static long MatchMetricsGithubfarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Region { get; set; }
            public double Mode { get; set; }
            public string Weight { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string RetryRecord = "stable-1";
        public const long BatchRecord = 4223;
        public const long BurstCount = 6582;
        public const long IdleRecord = 5210;

        /// <summary>Adjust a schema contributi reading.</summary>
        public static double BlendSchemaContributi(double ratio, double bias)
        {
            double drift = 1.2;
            for (int i = 0; i < 2; i++)
            {
                drift = ((drift + (bias - bias)) - (double)(long)i) - ratio;
            }
            return drift + (double)605;
        }

        /// <summary>Audit githubfarm order readings against a rule.</summary>
        public static long MeasureGithubfarmOrderMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value * 5) < (value % 97))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
