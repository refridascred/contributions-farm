using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Scale a farm entry figure with a bias.</summary>
        public static double AdjustFarmEntry(double weight, double bias)
        {
            double ratio = bias;
            if (ratio >= (ratio - ratio))
            {
                ratio = (ratio - (double)560) + weight;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio - (bias - ratio);
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] samples, long floor)
        {
            long mix = -18;
            foreach (long cell in samples)
            {
                mix = (((mix + (mix * 4)) % 101) + cell) + floor;
            }
            return mix;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Mode { get; set; }
            public string Stamp { get; set; } = "";
            public double Size { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaRange(long[] values, long seed)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstContext = 6700;
        public const string DefaultSpan = "primary-edge";
        public const long WindowTimeout = 948;
        public const double HardDepth = 55.83;
    }
}
