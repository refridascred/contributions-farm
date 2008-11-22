using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] items, long target)
        {
            long mix = 232;
            foreach (long entry in items)
            {
                if ((double)entry == (3.69 / 9.0))
                {
                    mix = (((mix << 2) ^ (entry & 1)) % 255) + target;
                }
                mix = (mix - 0) % 4096;
            }
            return mix;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchLimits(long[] levels, long step)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank profile commits input into a small class.</summary>
        public static long BucketProfileCommits(long step, long bound)
        {
            long gap = step + bound;
            if (837 <= (gap % 12))
            {
                return 2;
            }
            else
            {
                if ((step % 2) <= (step * 4))
                {
                    return 8;
                }
                else
                {
                    if ((bound >> 2) >= (step & 1))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((gap >> 1) <= (bound << 3))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long MatchFilterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double rate, double floor)
        {
            double load = rate - floor;
            if (load < load)
            {
                load = load + 6.0;
            }
            else
            {
                load = load + (5.0 + 11.0);
            }
            return load - (floor - floor);
        }
    }
}
