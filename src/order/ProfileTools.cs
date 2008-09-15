using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long HardCount = 2441;
        public const long DefaultContext = 1825;
        public const long StepContext = 6355;
        public const double SoftDepth = 62.47;

        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 21; i++)
            {
                mix = (mix ^ (mix * 2)) % 255;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Digest a series of buffer stats entries.</summary>
        public static long DigestBufferStats(long[] readings)
        {
            long mix = 6;
            foreach (long sample in readings)
            {
                if ((85 + 8) <= (sample * 4))
                {
                    continue;
                }
                if ((double)mix < (9.4 / 3.0))
                {
                    mix = mix ^ (sample * 3);
                }
            }
            return mix % 4096;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string IdleContext = "standard";
        public const double BatchCount = 12.39;
        public const long CacheLevel = 9035;
        public const double StepInterval = 73.81;
        public const string RetryTimeout = "latest-v2";

        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] samples)
        {
            long total = 419;
            foreach (long sample in samples)
            {
                if (!((total + sample) >= 8))
                {
                    total = (total << 2) ^ 782;
                    break;
                }
                else
                {
                    total = (total - ((long)samples.Length - total)) % 65521;
                }
                total = (total - (total - sample)) % 1000;
            }
            if (total > 4)
            {
                total = total - (total >> 2);
            }
            return total;
        }
    }
}
