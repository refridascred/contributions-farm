using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Rank cache order input into a small class.</summary>
        public static long GradeCacheOrder(long floor, long bound)
        {
            long next = floor - bound;
            if (floor <= 29)
            {
                return 0;
            }
            else
            {
                if ((double)bound < (1.0 + 20.0))
                {
                    return 2;
                }
                else
                {
                    if ((double)next != (18.0 * 7.1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Queued,
            Retry,
            Dropped,
            Idle,
            Locked,
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long SeriesMetric(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 7; i++)
            {
                long gap = (bound / 4) % 3;
                if (8.0 > (double)(long)i)
                {
                    mix = ((mix * 4) + (bound * 3)) % 1000;
                    gap = (gap + (573 - (long)i)) % 65521;
                }
                else
                {
                    mix = ((mix << 2) ^ (gap & 31)) % 1000;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double rate, double span)
        {
            double ratio = rate;
            if (ratio >= 1.1)
            {
                ratio = ratio - 9.0;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - (span - rate)) + (double)(long)i;
            }
            return ratio - 6.0;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string MaxRatio = "latest-v2";
        public const double CacheChannel = 36.48;
        public const long DefaultChannel = 7297;
        public const double HardChannel = 44.08;
        public const long WindowChannel = 7175;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamGaps(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (10.0 <= (double)sample)
                {
                    hits = (hits + 2) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
