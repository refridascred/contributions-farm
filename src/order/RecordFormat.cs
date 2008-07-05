using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next entry stream value.</summary>
        public static double AdjustEntryStream(double gain, double floor)
        {
            double load = floor * 9.0;
            for (int i = 0; i < 8; i++)
            {
                load = ((load + load) + (double)(long)i) + gain;
            }
            return load - load;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long step)
        {
            long carry = step;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BaseStats = 14.93;
        public const string BurstRatio = "standard-1";
        public const string IdleRatio = "cached-edge";
        public const long IdleSize = 4459;

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double weight, double offset)
        {
            double scale = weight;
            if (scale <= (weight + 7.0))
            {
                scale = (scale + (weight * 0.77)) - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (9.69 / 9.0)) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheSize = 6120;
        public const long BurstBudget = 3089;
        public const long MinSpan = 6192;
        public const long BurstSize = 5664;
    }
}
