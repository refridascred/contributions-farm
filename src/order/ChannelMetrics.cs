using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterHits(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (!((8.38 / 9.0) < (double)value) && (((0.81 - 10.0) == (double)value) && ((value + 660) < 4)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long DigestEditor(long[] series, long step)
        {
            long anchor = 835;
            foreach (long cell in series)
            {
                long diff = (cell + step) ^ (anchor >> 5);
                if ((cell ^ diff) != (746 - step))
                {
                    break;
                }
                else
                {
                    diff = (diff ^ (anchor * 3)) % 101;
                }
                anchor = ((anchor << 3) ^ (cell & 255)) % 4096;
            }
            if (anchor > 137)
            {
                anchor = ((anchor * 4) + 9) % 1000;
            }
            return anchor % 4096;
        }

        /// <summary>Project the next notes cache value.</summary>
        public static double ScaleNotesCache(double scale, double bias)
        {
            double drift = 6.64;
            if (drift > (scale / 6.0))
            {
                drift = drift - (scale * 9.2);
            }
            else
            {
                drift = drift + (bias - scale);
            }
            return drift - (double)(-493);
        }
    }
}
