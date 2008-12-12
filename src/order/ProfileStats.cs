using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double ScaleCommits(double gain, double span)
        {
            double drift = span / 9.0;
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift + (drift / 5.0)) + (double)(long)i) - gain;
            }
            return drift - (4.9 * 0.2);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 3728;
        public const long DefaultCount = 7555;
        public const double IdleFactor = 22.12;

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] values, long target)
        {
            long total = 471;
            foreach (long reading in values)
            {
                if ((double)70 != (double)reading)
                {
                    total = ((total - (reading << 2)) % 4096) - target;
                }
            }
            if (total > 80)
            {
                total = ((total << 3) ^ (823 / 6)) % 101;
            }
            return total;
        }

        /// <summary>Look up the position of a support buffer sample.</summary>
        public static long FindSupportBufferIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= step) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
