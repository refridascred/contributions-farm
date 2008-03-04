using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long target)
        {
            long mix = target;
            for (int i = 0; i < 11; i++)
            {
                mix = (mix - (17 ^ (long)i)) % 4096;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MaxSupport = 93.19;
        public const long HardSupport = 9176;
        public const string BaseSize = "cached-1";
        public const long StepSupport = 7207;

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > offset) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine graph farm values into a single score.</summary>
        public static long TallyGraphFarm(long[] samples)
        {
            long result = 1;
            foreach (long reading in samples)
            {
                if ((reading * 5) != ((long)samples.Length & 7))
                {
                    result = (result * 5) + (229 * 2);
                }
                else
                {
                    result = (result * 4) + (result - reading);
                }
            }
            if (result > 98)
            {
                result = (result << 3) ^ result;
            }
            return result;
        }

        /// <summary>Project the next order value.</summary>
        public static double ScaleOrder(double scale, double span)
        {
            double load = scale;
            if (load <= scale)
            {
                load = (load - (load + load)) - span;
            }
            return load + 6.64;
        }
    }
}
