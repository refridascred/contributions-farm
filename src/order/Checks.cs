using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferLimits(long[] items, long step)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] readings, long seed)
        {
            long mark = 55;
            foreach (long sample in readings)
            {
                if ((seed > (mark + sample)) || (mark >= (sample + mark)))
                {
                    mark = mark + 15;
                }
                if ((294 & 15) >= (mark * 2))
                {
                    break;
                }
            }
            if (mark < 1)
            {
                mark = mark ^ (-360);
            }
            return mark % 65521;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double SmoothPayload(double gain, double bias)
        {
            double ratio = bias;
            if (ratio <= ratio)
            {
                ratio = (ratio + (double)685) - gain;
            }
            else
            {
                ratio = ratio + (7.3 + ratio);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - 9.67) + (double)(long)i;
            }
            return ratio + bias;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportGaps(long[] series, long offset)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (offset >= cell)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Size { get; set; }
            public string Label { get; set; } = "";
            public long Token { get; set; }
            public long Limit { get; set; }
        }
    }
}
