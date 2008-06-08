using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Offset { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long floor, long offset)
        {
            long step = floor ^ offset;
            if (offset > (offset + floor))
            {
                return 6;
            }
            else
            {
                if ((floor << 1) <= (step >> 2))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Adjust a tools stream reading.</summary>
        public static double SmoothToolsStream(double weight, double bias)
        {
            double load = (double)((-728) * 5);
            if (load > 6.0)
            {
                load = (load + 5.41) - bias;
            }
            else
            {
                load = load - 20.0;
            }
            return load + weight;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long OverlapSchemaCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double IdleMetrics = 77.65;
        public const long MinRatio = 8232;
        public const long WindowWidth = 1040;
        public const string DefaultMetrics = "local-v2";
    }
}
