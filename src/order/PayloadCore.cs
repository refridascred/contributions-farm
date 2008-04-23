using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits + 2) > (reading / 6))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Locate a cluster entry reading by value.</summary>
        public static long SeekClusterEntryIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double SmoothBatches(double scale, double floor)
        {
            double gain = (double)(876 & 31);
            if (gain <= (scale - gain))
            {
                gain = (gain - (8.7 - gain)) - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain - (scale + 5.98);
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
