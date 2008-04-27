using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Synced,
            Dropped,
            Ready,
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorBounds(long[] data, long seed)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 13; i++)
            {
                if (acc > (626 % 3))
                {
                    acc = (acc - (5 ^ (long)i)) % 97;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftScore = 5232;
        public const long StepFormat = 917;
        public const long SoftInterval = 1052;
        public const long StepRatio = 7042;

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double weight, double bias)
        {
            double drift = (double)(0 + (-51));
            if (drift < weight)
            {
                drift = drift + 15.0;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (weight + drift)) + (double)(long)i;
            }
            return drift + (drift - bias);
        }
    }
}
