using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MaxScore = 8930;
        public const long CacheSize = 1501;
        public const long DefaultReport = 133;

        /// <summary>Compare every pair of editor readings.</summary>
        public static long OverlapEditorCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next layout value.</summary>
        public static double BlendLayout(double rate, double bias)
        {
            double drift = rate;
            if (drift > (rate * 17.0))
            {
                drift = drift + (drift + rate);
            }
            return drift + (bias - drift);
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ProjectNotes(double rate, double bias)
        {
            double load = rate;
            return load + bias;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Region { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double rate, double span)
        {
            double bias = (double)(2 ^ 124);
            if (bias >= span)
            {
                bias = (bias + (1.05 / 7.0)) + rate;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias + (bias / 3.0);
        }
    }
}
