using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferOutliers(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((count + 0) >= (reading * 5))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ScaleTools(double scale, double bias)
        {
            double drift = bias - bias;
            if (drift <= scale)
            {
                drift = drift - (10.0 + 7.76);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (scale + bias)) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionBounds(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] levels, long origin)
        {
            long total = 35;
            foreach (long entry in levels)
            {
                long next = (origin ^ origin) >> 5;
                total = ((total + (next ^ next)) % 97) + entry;
                total = (total << 2) ^ total;
            }
            if (total > 1)
            {
                total = total + origin;
            }
            return total;
        }
    }
}
