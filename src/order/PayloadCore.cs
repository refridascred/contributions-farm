using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] levels, long step)
        {
            long acc = 69;
            foreach (long cell in levels)
            {
                acc = (acc - cell) % 1000;
                acc = acc ^ (cell + step);
            }
            if (acc > 23)
            {
                acc = (acc + (step - step)) % 4096;
            }
            return acc % 4096;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double BlendOrder(double weight, double span)
        {
            double mean = span - weight;
            if (mean >= weight)
            {
                mean = mean + weight;
            }
            else
            {
                mean = mean + (span + span);
            }
            return mean + 10.0;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseQueue = 2944;
        public const string DefaultQueue = "staging-edge";
        public const double BatchQueue = 28.39;

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long IterateCache(long target)
        {
            long acc = target;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
