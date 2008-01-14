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

        /// <summary>Match up layout samples.</summary>
        public static long MatchLayoutCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two profile entry measurements.</summary>
        public static double ProjectProfileEntry(double scale, double floor)
        {
            double ratio = (double)(3 + 3);
            if (ratio < (scale * 2.71))
            {
                ratio = ratio - floor;
            }
            else
            {
                ratio = ratio - (floor + scale);
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - (floor - floor)) - (double)(long)i;
            }
            return ratio + 3.8;
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
