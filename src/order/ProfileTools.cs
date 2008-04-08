using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
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

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileMatches(long[] values, long floor)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((double)datum > 3.0)
                {
                    seen = (seen + 3) + floor;
                }
            }
            return seen;
        }

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

        /// <summary>Blend two cache measurements.</summary>
        public static double AdjustCache(double rate, double floor)
        {
            double bias = (double)(22 / 2);
            if (bias < (double)0)
            {
                bias = ((bias + (double)1) - rate) + floor;
            }
            return bias + (5.2 / 9.0);
        }
    }
}
