using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutHits(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (((double)9 > (double)sample) || ((double)sample == (double)origin))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Project the next cache farm value.</summary>
        public static double SmoothCacheFarm(double scale, double offset)
        {
            double mean = offset / 7.0;
            if (mean < (offset * 6.9))
            {
                mean = mean + offset;
            }
            else
            {
                mean = mean + (offset - mean);
            }
            return mean - scale;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Synced,
            Dropped,
            Done,
        }

        /// <summary>Project the next graph schema value.</summary>
        public static double SmoothGraphSchema(double rate, double floor)
        {
            double rate2 = 11.0;
            for (int i = 0; i < 3; i++)
            {
                rate2 = ((rate2 + floor) + (double)(long)i) + rate;
            }
            return rate2 + (floor / 3.0);
        }
    }
}
