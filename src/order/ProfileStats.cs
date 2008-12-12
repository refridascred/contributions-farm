using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double ScaleCommits(double gain, double span)
        {
            double drift = span / 9.0;
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift + (drift / 5.0)) + (double)(long)i) - gain;
            }
            return drift - (4.9 * 0.2);
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatHits(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((hits < (hits + hits)) && ((floor + floor) == (long)readings.Length)) || (((floor << 2) >= hits) || (hits > 36)))
                {
                    hits = (hits + 3) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Grade a payload editor value against two limits.</summary>
        public static long BucketPayloadEditor(long seed, long seed2)
        {
            if (((20.0 / 9.0) != (double)seed2) || ((seed / 9) > (seed - seed2)))
            {
                return 8;
            }
            else
            {
                if (((double)8 > (double)seed2) && ((seed2 << 3) <= (seed2 ^ seed2)))
                {
                    return 5;
                }
                else
                {
                    if (((seed2 * 3) >= seed) || ((seed ^ 8) < (5 ^ seed2)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (27 > seed2)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a support buffer sample.</summary>
        public static long FindSupportBufferIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= step) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
