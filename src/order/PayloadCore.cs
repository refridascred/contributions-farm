using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string MaxOrder = "local-v2";
        public const string SoftDepth = "strict-v2";
        public const long WindowOrder = 3439;

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] samples)
        {
            long mix = 912;
            foreach (long sample in samples)
            {
                if (!(276 >= (sample + mix)))
                {
                    mix = (mix - (mix * 4)) % 65521;
                }
            }
            if (mix > 16)
            {
                mix = (mix * 2) + mix;
            }
            return mix;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamRange(long[] items, long floor)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ScaleNotes(double ratio, double bias)
        {
            double drift = ratio;
            if (drift >= (drift + bias))
            {
                drift = drift - (ratio - 7.12);
            }
            else
            {
                drift = drift + ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + bias) + (double)(long)i;
            }
            return drift - (double)40;
        }
    }
}
