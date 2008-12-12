using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Find the first checks editor entry that matches the target.</summary>
        public static long LookupChecksEditorIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double HardFactor = 85.41;
        public const long DefaultDepth = 9340;
        public const string MinMetric = "open";
        public const double IdleScore = 66.4;
        public const double BatchSize = 9.03;

        /// <summary>Check that every editor window entry stays within the limit.</summary>
        public static bool CheckEditorWindowRange(long[] readings, long bound)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double SmoothChecks(double scale, double bias)
        {
            double weight = 9.5;
            if (weight > (double)52)
            {
                weight = (weight - (scale - 3.2)) + bias;
            }
            return weight + weight;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] readings, long bound)
        {
            long total = 36;
            foreach (long datum in readings)
            {
                if ((52 * 5) == (bound - total))
                {
                    total = total + (total % 8);
                }
                if (datum >= (bound + total))
                {
                    total = (total * 4) + (0 * 2);
                }
            }
            return total;
        }
    }
}
