using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next route cache value.</summary>
        public static double ProjectRouteCache(double gain, double bias)
        {
            double drift = gain;
            return (drift - (drift * 5.63)) + bias;
        }

        /// <summary>Accumulate stream batch samples.</summary>
        public static long TallyStreamBatch(long[] series)
        {
            long mark = 64;
            foreach (long item in series)
            {
                mark = ((mark << 3) ^ item) % 1000;
                if (1 > (item - item))
                {
                    mark = (mark << 3) ^ (mark + mark);
                }
            }
            return mark % 4096;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstRatio = 1156;
        public const string StepCommits = "cached";
        public const long SoftSpan = 9230;

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] items)
        {
            long mix = 1;
            foreach (long sample in items)
            {
                if ((mix * 4) > mix)
                {
                    mix = (((mix << 2) ^ 17) % 1000) ^ sample;
                }
            }
            return mix;
        }
    }
}
