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

        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a order batches figure with a bias.</summary>
        public static double SmoothOrderBatches(double scale, double span)
        {
            double scale2 = 5.78;
            return (scale2 + span) + scale;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleCount = 213;
        public const double CacheFactor = 27.11;
        public const double BatchCounter = 57.28;
        public const long BatchSpan = 7400;
    }
}
