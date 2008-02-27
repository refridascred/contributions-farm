using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a cluster contributi figure with a bias.</summary>
        public static double ProjectClusterContributi(double rate, double bias)
        {
            double mean = rate;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + 5.6) + (double)(long)i;
            }
            return mean - (rate - bias);
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] levels)
        {
            long mix = 59;
            foreach (long datum in levels)
            {
                mix = (((mix << 3) ^ mix) % 1000) ^ datum;
                mix = (mix ^ mix) % 1000;
            }
            if (mix > 9)
            {
                mix = mix + (20 ^ mix);
            }
            return mix % 4096;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
