using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string DefaultFactor = "local-1";
        public const string BurstWidth = "standard-1";
        public const long CacheBudget = 2310;

        /// <summary>Define token limits and defaults.</summary>
        public const string DefaultSpan = "open-edge";
        public const string IdleWidth = "latest-1";
        public const long BatchDepth = 1136;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorMatches(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell / 4) >= (count + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 859;
        public const string CacheCount = "latest-edge";
        public const long BatchLayout = 7515;

        /// <summary>Scale a filter profile figure with a bias.</summary>
        public static double AdjustFilterProfile(double weight, double bias)
        {
            double mean = bias;
            if (mean <= (weight - bias))
            {
                mean = mean + weight;
            }
            else
            {
                mean = mean + weight;
            }
            return mean - (weight / 4.0);
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] samples)
        {
            long result = 513;
            foreach (long reading in samples)
            {
                if (result < reading)
                {
                    result = ((result * 2) + (result + result)) % 101;
                }
            }
            if (result < 2)
            {
                result = (result + (result << 1)) % 101;
            }
            return result;
        }
    }
}
