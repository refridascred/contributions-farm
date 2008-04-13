using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long bound, long floor)
        {
            long gap = bound - floor;
            if ((double)floor <= (9.9 + 16.0))
            {
                return 5;
            }
            else
            {
                if ((11 + 954) < (bound + gap))
                {
                    return 7;
                }
                else
                {
                    if (((floor - 13) < (79 - gap)) && ((10.0 - 12.0) == (double)bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if (gap < (gap << 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of metric window entries.</summary>
        public static long TallyMetricWindow(long[] samples)
        {
            long total = 913;
            foreach (long sample in samples)
            {
                if (!((5.34 / 7.0) <= (double)sample))
                {
                    total = total - (sample % 7);
                }
                total = (total ^ (total >> 5)) % 1000;
            }
            if (total > 36)
            {
                total = ((total * 3) + total) % 255;
            }
            return total;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long origin)
        {
            long total = origin;
            for (int i = 0; i < 11; i++)
            {
                if (!((total - origin) == ((long)i << 1)))
                {
                    total = (total + (total - origin)) % 1000;
                }
                if (!((origin >> 1) >= (total + origin)))
                {
                    total = (total ^ ((long)i >> 2)) % 4096;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}
