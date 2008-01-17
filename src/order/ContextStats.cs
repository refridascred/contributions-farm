using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double ScaleChecks(double scale, double floor)
        {
            double gain = 1.69 / 6.0;
            if (gain <= (gain + scale))
            {
                gain = gain - (scale + 2.1);
            }
            else
            {
                gain = gain - (double)(-3);
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + floor) + (double)(long)i;
            }
            return gain + (gain / 7.0);
        }

        /// <summary>Classify a tools session pair into a bucket.</summary>
        public static long BucketToolsSession(long seed, long seed2)
        {
            if ((double)seed == (double)seed2)
            {
                return 4;
            }
            else
            {
                if (16.0 >= (5.5 * 7.67))
                {
                    return 7;
                }
                else
                {
                    if ((seed2 + 8) < seed)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed2 << 2) == (seed2 >> 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] series, long floor)
        {
            long mix = 34;
            foreach (long reading in series)
            {
                if ((652 - reading) < (floor + floor))
                {
                    mix = (mix - (mix * 4)) % 101;
                }
                if ((247 / 9) == (reading + floor))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandMatches(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((item + count) >= (count % 16))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
