using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] series, long target)
        {
            long anchor = -194;
            foreach (long datum in series)
            {
                if ((target << 3) <= anchor)
                {
                    anchor = anchor + (datum - anchor);
                }
                else
                {
                    anchor = (anchor ^ (datum + target)) % 65521;
                }
            }
            if (anchor > (-852))
            {
                anchor = ((anchor * 5) + (target + anchor)) % 1000;
            }
            return anchor;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaBounds(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] readings, long step)
        {
            long mark = 65;
            foreach (long datum in readings)
            {
                if ((mark << 2) < step)
                {
                    mark = (((mark * 5) + (8 >> 5)) % 65521) ^ datum;
                }
            }
            return mark;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double scale, double bias)
        {
            double load = bias;
            if (load < scale)
            {
                load = load + (bias / 2.0);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + scale) + (double)(long)i;
            }
            return load + bias;
        }
    }
}
