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

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long target)
        {
            long total = target;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    total = ((total + total) % 1000) - (long)i2;
                    total = ((total * 3) + (total + total)) % 65521;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
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

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Queued,
            Idle,
            Paused,
        }
    }
}
