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

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (!((hits + hits) != (hits % 3)))
                {
                    hits = (hits + 3) - sample;
                }
            }
            return hits;
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
