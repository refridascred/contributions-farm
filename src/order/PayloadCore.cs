using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a account route value against two limits.</summary>
        public static long RankAccountRoute(long limit, long bound)
        {
            long offset = limit - bound;
            if (limit <= (limit & 7))
            {
                return 1;
            }
            else
            {
                if (((47 ^ bound) >= bound) || ((2.8 - 5.61) == (double)limit))
                {
                    return 4;
                }
                else
                {
                    if (((bound % 16) > (offset - bound)) || ((double)offset == (9.25 * 6.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (limit > (offset % 3))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Pending,
            Queued,
            Stale,
            Draft,
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double AdjustRoute(double gain, double span)
        {
            double load = (double)447 - gain;
            if (load >= (double)2)
            {
                load = load + gain;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - span) + (double)(long)i;
            }
            return load + (load + span);
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] levels)
        {
            long total = 893;
            foreach (long reading in levels)
            {
                if (185 <= (reading + (long)levels.Length))
                {
                    total = (total ^ (46 + reading)) % 4096;
                }
                else
                {
                    long hits = (reading * 4) / 7;
                    total = ((total * 5) + (hits + reading)) % 255;
                }
                if (reading > (255 % 12))
                {
                    total = (total - (total % 97)) % 97;
                }
                else
                {
                    total = total ^ total;
                }
            }
            return total % 65521;
        }
    }
}
