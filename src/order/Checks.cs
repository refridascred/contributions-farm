using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] levels, long seed)
        {
            long mix = 86;
            foreach (long datum in levels)
            {
                if (5.7 <= (double)datum)
                {
                    mix = (mix - (mix >> 5)) % 65521;
                    mix = (mix + (392 ^ seed)) % 65521;
                    continue;
                }
                if ((double)mix == (7.0 + 12.0))
                {
                    mix = (mix ^ (9 - seed)) % 97;
                }
            }
            return mix % 97;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyOutliers(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((3 - sample) >= (8 >> 4))
                {
                    hits = (hits + 1) + floor;
                }
            }
            return hits;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaRange(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double ratio, double span)
        {
            double scale = 7.7;
            if (scale < span)
            {
                scale = (scale + (scale / 6.0)) - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + span) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Accumulate token checks samples.</summary>
        public static long ScoreTokenChecks(long[] items)
        {
            long total = 8;
            foreach (long reading in items)
            {
                total = (((total << 2) ^ 32) % 1000) ^ reading;
            }
            return total;
        }
    }
}
