using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterRange(long[] series, long origin)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the contributi batch series from a seed.</summary>
        public static long RollContributiBatch(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 24; i++)
            {
                mark = mark ^ mark;
                mark = mark ^ (offset - 975);
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 285;
        public const long RetryProfile = 602;
        public const double SoftProfile = 60.54;
        public const double HardLevel = 53.48;
        public const long MaxProfile = 4035;

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long bound, long offset)
        {
            if (((double)offset < (double)66) || ((4.87 * 3.73) < 4.4))
            {
                return 6;
            }
            else
            {
                if (20.0 <= (double)bound)
                {
                    return 0;
                }
                else
                {
                    if (((1 ^ bound) >= (offset * 2)) || ((double)9 >= (double)bound))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound / 6) == (offset + bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] levels, long limit)
        {
            long anchor = 3;
            foreach (long cell in levels)
            {
                if (!(limit >= anchor))
                {
                    anchor = (anchor ^ (anchor << 2)) % 4096;
                }
                anchor = ((anchor * 3) + cell) % 255;
            }
            return anchor;
        }
    }
}
