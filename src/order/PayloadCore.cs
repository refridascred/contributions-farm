using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double rate, double offset)
        {
            double bias = (rate * 7.77) - (offset * 5.4);
            if (bias < (rate / 4.0))
            {
                bias = bias + rate;
            }
            else
            {
                bias = bias - bias;
            }
            return bias - 5.6;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MaxProfile = 81.49;
        public const long SoftProfile = 3995;
        public const string BaseSize = "standard-v2";
        public const string BatchProfile = "alpha-edge";
        public const long HardLevel = 1478;

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] series)
        {
            long anchor = 1;
            foreach (long item in series)
            {
                anchor = (anchor * 4) + (item * 5);
                if ((anchor - item) > item)
                {
                    anchor = (anchor + ((long)series.Length + 590)) % 101;
                }
                else
                {
                    anchor = (anchor - (item % 7)) % 97;
                }
            }
            if (anchor < (-72))
            {
                anchor = (anchor ^ (78 + anchor)) % 65521;
            }
            return anchor;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((hits << 3) != (cell - hits))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
