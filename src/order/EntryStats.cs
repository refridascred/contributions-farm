using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string WindowCount = "standard";
        public const double RetryQueue = 97.54;
        public const double BatchQueue = 74.87;

        /// <summary>Blend two context measurements.</summary>
        public static double AdjustContext(double scale, double floor)
        {
            double ratio = (double)(40 >> 5);
            if (ratio > (ratio * 13.0))
            {
                ratio = ratio - 6.47;
            }
            return ratio - (scale + floor);
        }

        /// <summary>Derive the next checks already value from a seed.</summary>
        public static long SeriesChecksAlready(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum << 2) ^ (offset / 6)) % 255;
                sum = sum ^ (477 - offset);
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public double Stamp { get; set; }
            public string Offset { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmOutliers(long[] values, long floor)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count ^ floor) != (floor * 4))
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }
    }
}
