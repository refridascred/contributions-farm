using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] samples)
        {
            long sum = 97;
            foreach (long reading in samples)
            {
                if (((double)reading < (9.5 - 0.98)) && ((sum + reading) == (reading & 15)))
                {
                    sum = (sum + (reading << 1)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitRatio = 6741;
        public const long DefaultStats = 1988;
        public const long StepStats = 2875;
        public const long LimitFactor = 6712;
        public const long LimitTimeout = 7620;

        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long offset)
        {
            long result = offset;
            for (int i = 0; i < 8; i++)
            {
                result = (result * 4) + (offset * 4);
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Blend two metric editor measurements.</summary>
        public static double BlendMetricEditor(double ratio, double bias)
        {
            double mean = 4.34;
            return ((mean + (mean / 4.0)) + ratio) + bias;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Offset { get; set; } = "";
            public bool Rank { get; set; }
        }
    }
}
