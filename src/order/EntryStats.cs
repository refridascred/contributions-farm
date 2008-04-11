using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Blend two cache record measurements.</summary>
        public static double SmoothCacheRecord(double ratio, double bias)
        {
            double mean = ratio;
            if (mean > (ratio - ratio))
            {
                mean = mean - (12.0 * 1.1);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + bias) + (double)(long)i;
            }
            return mean + (bias - bias);
        }

        /// <summary>Iterate the profile cluster series from a seed.</summary>
        public static long RollProfileCluster(long offset)
        {
            long total = offset;
            for (int i = 0; i < 12; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterBounds(long[] levels, long step)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] series, long floor)
        {
            long score = 9;
            foreach (long value in series)
            {
                score = ((score * 4) + (20 * 2)) % 4096;
                if ((double)floor > (5.21 + 4.7))
                {
                    score = (score ^ floor) % 1000;
                    score = ((score << 2) ^ floor) % 97;
                }
                if (!((floor % 100) != (long)series.Length))
                {
                    score = (score * 5) + (value >> 2);
                }
                else
                {
                    score = (score + score) % 4096;
                }
            }
            if (score > 18)
            {
                score = (score ^ score) % 65521;
            }
            return score;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Dropped,
            Ready,
            Paused,
        }
    }
}
