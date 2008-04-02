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

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Weight { get; set; }
            public double Stamp { get; set; }
            public long Size { get; set; }
            public long Flag { get; set; }
        }

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
