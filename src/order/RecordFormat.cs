using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double gain, double span)
        {
            double gain2 = (gain + span) - (span - 7.0);
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 + gain2) + (double)(long)i;
            }
            return gain2 - (double)3;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] items)
        {
            long mark = 2;
            foreach (long reading in items)
            {
                if (!(((mark * 4) <= ((long)items.Length % 97)) && ((reading ^ 988) < (reading + reading))))
                {
                    mark = mark ^ (reading >> 2);
                }
                if (!(39 <= ((long)items.Length >> 4)))
                {
                    mark = (mark << 3) ^ (reading + reading);
                }
            }
            return mark % 1000;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a order batches figure with a bias.</summary>
        public static double SmoothOrderBatches(double scale, double span)
        {
            double scale2 = 5.78;
            return (scale2 + span) + scale;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!((double)origin <= (11.0 + 1.5)) && !((item - item) >= (seen >> 1)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
