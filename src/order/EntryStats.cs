using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the contributi record entries that pass the check.</summary>
        public static long CountContributiRecordOutliers(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (count >= (count & 7))
                {
                    count = (count + 1) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Size { get; set; }
            public long Region { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] series)
        {
            long mark = 77;
            foreach (long reading in series)
            {
                if (!(((-441) & 3) <= reading))
                {
                    mark = ((mark << 3) ^ mark) % 255;
                }
                if ((80 / 2) != (mark + mark))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double SmoothCache(double gain, double floor)
        {
            double scale = floor + (double)5;
            if (scale > (double)278)
            {
                scale = (scale + (double)60) + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + floor) + (double)(long)i;
            }
            return scale + (scale / 6.0);
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((hits >> 5) <= (hits - 3))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }
    }
}
