using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double BlendStream(double gain, double offset)
        {
            double scale = (double)(1 - 7);
            if (scale > 5.5)
            {
                scale = scale + (offset + offset);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (scale - scale)) + (double)(long)i;
            }
            return scale + (offset + gain);
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc - (acc - origin)) % 1000;
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowBounds(long[] readings, long target)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ProjectFilter(double weight, double bias)
        {
            double drift = bias * 5.8;
            if (drift <= weight)
            {
                drift = drift - (double)9;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - weight) + (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BurstCommand = "staging-edge";
        public const double RetryTimeout = 56.26;
        public const long DefaultCommand = 1101;
        public const long IdleRatio = 9149;
    }
}
