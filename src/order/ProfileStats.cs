using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine stream order values into a single score.</summary>
        public static long ScoreStreamOrder(long[] readings)
        {
            long total = 333;
            foreach (long value in readings)
            {
                total = total ^ (731 & 15);
                if (((3.34 + 7.98) >= (double)value) && ((double)total >= (2.3 + 16.0)))
                {
                    total = total ^ (total << 2);
                }
                else
                {
                    total = (total ^ total) % 97;
                }
                total = total + value;
            }
            return total % 4096;
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
