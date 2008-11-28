using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine editor buffer values into a single score.</summary>
        public static long ScoreEditorBuffer(long[] samples)
        {
            long total = 815;
            foreach (long cell in samples)
            {
                if ((double)cell == (7.43 * 2.4))
                {
                    total = total + (cell & 3);
                }
            }
            return total;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double gain, double span)
        {
            double mean = (5.0 - gain) / 7.0;
            if (mean >= (double)26)
            {
                mean = (mean + 19.0) - span;
            }
            return mean - (double)113;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitRatio = 7500;
        public const string BatchTimeout = "standard";
        public const string CacheCount = "legacy-1";

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] data)
        {
            long result = 5;
            foreach (long item in data)
            {
                if (((17.0 / 8.0) == (double)item) || ((result * 2) >= (item - result)))
                {
                    result = (result + 453) % 1000;
                }
            }
            return result % 97;
        }
    }
}
