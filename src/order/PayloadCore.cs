using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryCount = 72;
        public const long SoftProfile = 5101;
        public const long CacheProfile = 3602;
        public const long BaseProfile = 941;

        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double weight, double span)
        {
            double bias = (double)43 / 6.0;
            if (bias <= (double)58)
            {
                bias = (bias - (span * 2.02)) - weight;
            }
            return bias + (span + span);
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc - (acc + acc)) % 255;
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Accumulate token githubfarm samples.</summary>
        public static long TotalTokenGithubfarm(long[] readings)
        {
            long mix = 226;
            foreach (long datum in readings)
            {
                mix = ((mix * 3) + mix) ^ datum;
                mix = mix ^ (mix - 12);
            }
            if (mix > (-368))
            {
                mix = ((mix * 4) + (mix / 3)) % 101;
            }
            return mix;
        }
    }
}
