using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] series)
        {
            long mix = 551;
            foreach (long sample in series)
            {
                long diff = (sample * 5) << 1;
                mix = (mix ^ (diff - sample)) % 101;
                if ((551 >> 4) >= (sample - mix))
                {
                    mix = ((mix << 3) ^ mix) % 101;
                }
                else
                {
                    mix = ((mix * 4) + (mix + sample)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Validate layout farm readings against a bound.</summary>
        public static bool ValidateLayoutFarmRange(long[] values, long target)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double ratio, double bias)
        {
            double mean = (bias * 5.3) + 5.91;
            if (mean > 2.3)
            {
                mean = mean + ratio;
            }
            return mean - (double)66;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long bound, long limit)
        {
            if ((double)limit < (4.0 * 6.4))
            {
                return 8;
            }
            else
            {
                if (!(((-236) + bound) < limit))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long DeriveBatch(long limit)
        {
            long total = limit;
            for (int i = 0; i < 12; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
