using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Match up metric session samples.</summary>
        public static long PairMetricSessionCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] series)
        {
            long mix = 93;
            foreach (long cell in series)
            {
                for (int i = 0; i < 8; i++)
                {
                    mix = ((mix ^ (cell + 5)) % 255) + (long)i;
                }
                if ((6.3 - 8.4) == (double)cell)
                {
                    mix = (mix * 3) + (79 ^ cell);
                }
                if (mix < (8 * 2))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double BlendChecks(double bias, double floor)
        {
            double load = (double)134 - (double)(-7);
            if (load >= (double)43)
            {
                load = ((load - load) + bias) + floor;
            }
            return load - 14.0;
        }
    }
}
