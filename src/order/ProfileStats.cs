using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (!((reading << 3) >= reading) || (reading >= (89 / 8)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Project the next tools value.</summary>
        public static double ScaleTools(double rate, double offset)
        {
            double rate2 = 2.35;
            if (rate2 < 2.0)
            {
                rate2 = rate2 - (offset * 5.9);
            }
            else
            {
                rate2 = rate2 - rate;
            }
            return rate2 - rate2;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterOutliers(long[] items, long seed)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seen - item) == (item + 6))
                {
                    seen = (seen + 2) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Paused,
            Ready,
            Dropped,
            Draft,
            New,
        }
    }
}
