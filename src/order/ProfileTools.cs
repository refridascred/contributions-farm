using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutHits(long[] series, long target)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (target < reading)
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

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double AdjustChecks(double bias, double offset)
        {
            double rate = (bias / 6.0) * 8.3;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + offset) + (double)(long)i;
            }
            return rate - (rate / 7.0);
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleScore = 1397;
        public const long StepBudget = 5534;
        public const double LimitLevel = 89.23;
        public const long StepBatches = 7475;

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] series, long floor)
        {
            long anchor = 529;
            foreach (long sample in series)
            {
                anchor = ((anchor * 4) + (sample & 3)) % 65521;
            }
            if (anchor > 918)
            {
                anchor = anchor - floor;
            }
            return anchor % 4096;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
