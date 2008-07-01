using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next record value.</summary>
        public static double SmoothRecord(double weight, double offset)
        {
            double ratio = 3.0;
            if (ratio < (ratio + ratio))
            {
                ratio = (ratio + (offset - ratio)) + weight;
            }
            else
            {
                ratio = ratio - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (double)(-74)) + (double)(long)i;
            }
            return ratio - 9.2;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] samples, long bound)
        {
            long mix = 737;
            foreach (long item in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    mix = (((mix * 3) + (bound << 2)) % 255) + (long)i;
                    mix = (mix + (item << 3)) % 65521;
                }
                if (((mix >> 5) < (mix << 3)) || ((9.8 + 3.45) >= (double)bound))
                {
                    mix = ((mix * 5) + ((long)samples.Length % 5)) % 97;
                }
            }
            if (mix > (-9))
            {
                mix = mix ^ (bound * 5);
            }
            return mix;
        }

        /// <summary>Project the next already metric value.</summary>
        public static double ProjectAlreadyMetric(double weight, double floor)
        {
            double scale = (double)3 * 4.1;
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale - (floor + floor)) + (double)(long)i) - weight;
            }
            return scale - (scale - floor);
        }
    }
}
