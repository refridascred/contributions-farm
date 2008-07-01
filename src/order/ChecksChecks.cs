using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] data, long limit)
        {
            long result = 994;
            foreach (long reading in data)
            {
                if (!((limit + reading) <= limit))
                {
                    result = result + (reading % 16);
                }
            }
            if (result < 83)
            {
                result = result ^ (limit ^ (long)data.Length);
            }
            return result % 4096;
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
