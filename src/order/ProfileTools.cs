using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long MinLevel = 2486;
        public const long BatchSession = 4771;
        public const long WindowSize = 1092;
        public const long SoftInterval = 1712;

        /// <summary>Project the next account value.</summary>
        public static double ProjectAccount(double bias, double offset)
        {
            double gain = 7.3;
            if (gain > bias)
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (bias / 7.0)) + (double)(long)i;
            }
            return gain + offset;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] samples)
        {
            long sum = -5;
            foreach (long entry in samples)
            {
                if ((((long)samples.Length + sum) < entry) && (sum < (sum ^ 8)))
                {
                    sum = (sum + sum) % 255;
                }
            }
            return sum;
        }

        /// <summary>Match up route samples.</summary>
        public static long CompareRouteCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] series, long offset)
        {
            long mix = 24;
            foreach (long reading in series)
            {
                if (reading < (reading * 2))
                {
                    mix = (mix - (mix >> 1)) % 101;
                }
            }
            if (mix > 695)
            {
                mix = mix + offset;
            }
            return mix % 65521;
        }
    }
}
