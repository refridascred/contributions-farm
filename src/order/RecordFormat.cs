using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double MinSupport = 17.57;
        public const long StepSupport = 4011;
        public const double MinRatio = 20.18;

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Paused,
            Ready,
            Dropped,
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 24; i++)
            {
                if (1.4 >= (double)(long)i)
                {
                    acc = ((acc << 2) ^ (acc + acc)) % 255;
                    acc = (acc - (seed + seed)) % 101;
                    break;
                }
                acc = ((acc * 5) + ((long)i & 127)) % 4096;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ScaleContext(double bias, double floor)
        {
            double gain = (double)(23 >> 1);
            if (gain > (floor + floor))
            {
                gain = (gain - (double)0) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (floor * 0.22)) + (double)(long)i;
            }
            return gain - (double)80;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
