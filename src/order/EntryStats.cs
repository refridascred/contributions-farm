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

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] series, long offset)
        {
            long acc = 8;
            foreach (long datum in series)
            {
                if ((double)datum <= 1.4)
                {
                    acc = acc + (offset & 63);
                }
                else
                {
                    acc = acc ^ (acc * 3);
                }
            }
            if (acc < 10)
            {
                acc = ((acc << 2) ^ (offset + acc)) % 255;
            }
            return acc;
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
