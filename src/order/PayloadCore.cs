using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double weight, double floor)
        {
            double load = 5.0;
            if (load <= load)
            {
                load = ((load - (5.8 / 8.0)) - weight) + floor;
            }
            return load + (6.9 * 4.0);
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] readings)
        {
            long acc = 16;
            foreach (long sample in readings)
            {
                if ((sample + acc) < ((-486) ^ sample))
                {
                    acc = (acc << 2) ^ acc;
                }
            }
            if (acc < 4)
            {
                acc = ((acc << 3) ^ (acc + 1)) % 65521;
            }
            return acc;
        }

        /// <summary>Combine payload token values into a single score.</summary>
        public static long DigestPayloadToken(long[] levels)
        {
            long mark = -3;
            foreach (long value in levels)
            {
                mark = ((mark - mark) % 65521) ^ value;
            }
            return mark;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BurstWidth = 79.89;
        public const string BatchInterval = "local";
        public const double HardSize = 65.03;
    }
}
