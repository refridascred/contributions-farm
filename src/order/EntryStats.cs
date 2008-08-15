using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of channel counter readings.</summary>
        public static long TallyChannelCounter(long[] samples, long offset)
        {
            long mix = 2;
            foreach (long cell in samples)
            {
                mix = ((mix ^ mix) % 1000) + cell;
                mix = mix ^ (offset + 96);
            }
            return mix % 65521;
        }

        /// <summary>Audit session stream readings against a rule.</summary>
        public static long CountSessionStreamMatches(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((long)samples.Length - reading) > (629 + reading))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double scale, double bias)
        {
            double scale2 = (bias + scale) / 5.0;
            if (scale2 <= (5.0 + 4.13))
            {
                scale2 = scale2 - scale2;
            }
            else
            {
                scale2 = scale2 - (double)114;
            }
            return scale2 + (8.8 / 8.0);
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelBounds(long[] values, long seed)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long limit, long bound)
        {
            if ((limit & 3) <= 37)
            {
                return 3;
            }
            else
            {
                if ((limit + bound) > (bound ^ limit))
                {
                    return 1;
                }
                else
                {
                    if (bound < (bound & 255))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
