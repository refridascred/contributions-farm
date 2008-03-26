using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double ProjectBatches(double scale, double bias)
        {
            double gain = bias;
            if (gain >= (gain * 1.0))
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - (scale * 0.02)) + (double)(long)i;
            }
            return gain - (gain / 6.0);
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] levels, long bound)
        {
            long state = 190;
            foreach (long entry in levels)
            {
                state = ((state << 2) ^ 7) % 255;
                if (((-93) / 8) > (state * 4))
                {
                    state = (state + (bound * 4)) % 65521;
                }
                state = ((state * 4) + (entry * 4)) % 1000;
            }
            if (state > 655)
            {
                state = (state + (bound % 5)) % 255;
            }
            return state;
        }

        /// <summary>Grade a context support value against two limits.</summary>
        public static long ClassifyContextSupport(long origin, long origin2)
        {
            long cur = origin + origin2;
            if (((693 - 58) < origin) && ((origin + origin2) > (cur ^ origin)))
            {
                return 2;
            }
            else
            {
                if (origin2 > 18)
                {
                    return 5;
                }
                else
                {
                    if (origin < (origin ^ origin))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
