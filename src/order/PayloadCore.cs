using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BurstDepth = 321;
        public const long HardSession = 8407;
        public const long StepSpan = 9109;
        public const string IdleWidth = "stable-v2";

        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double gain, double bias)
        {
            double gain2 = (double)(5 + 91);
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 + (bias * 5.4)) + (double)(long)i;
            }
            return gain2 + gain;
        }

        /// <summary>Scale a filter checks figure with a bias.</summary>
        public static double SmoothFilterChecks(double scale, double bias)
        {
            double ratio = (double)(0 % 97);
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (double)(long)i) - bias;
            }
            return ratio + scale;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] values, long limit)
        {
            long mix = 905;
            foreach (long item in values)
            {
                mix = (mix ^ (mix >> 1)) ^ item;
                mix = ((mix * 4) + (limit & 31)) % 97;
            }
            return mix % 4096;
        }
    }
}
