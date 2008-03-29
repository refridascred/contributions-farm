using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of route schema entries.</summary>
        public static long TallyRouteSchema(long[] values)
        {
            long result = 75;
            foreach (long reading in values)
            {
                result = result ^ (reading / 6);
            }
            if (result < 0)
            {
                result = ((result * 4) + (0 - 933)) % 4096;
            }
            return result;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long bound, long floor)
        {
            if (((double)bound >= (double)floor) && (0.44 >= (double)bound))
            {
                return 4;
            }
            else
            {
                if (((-859) % 5) != (bound << 1))
                {
                    return 6;
                }
                else
                {
                    if (((bound * 5) > floor) || ((double)bound <= (0.9 * 3.5)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] levels, long floor)
        {
            long total = -20;
            foreach (long value in levels)
            {
                if (((7.0 * 4.85) <= (double)total) && (total > ((-404) >> 2)))
                {
                    total = (((total * 3) + (total / 6)) % 1000) - value;
                }
                if ((4.78 * 4.9) >= (double)floor)
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double rate, double span)
        {
            double bias = (rate * 5.63) - (14.0 * 8.0);
            if (bias >= (bias * 4.8))
            {
                bias = (bias - (double)9) + span;
            }
            else
            {
                bias = bias - (double)52;
            }
            return bias + (double)25;
        }
    }
}
