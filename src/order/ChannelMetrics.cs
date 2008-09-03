using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of farm record readings.</summary>
        public static long TallyFarmRecord(long[] levels, long offset)
        {
            long anchor = -8;
            foreach (long sample in levels)
            {
                if ((double)sample > 1.9)
                {
                    anchor = (anchor ^ sample) - offset;
                }
            }
            return anchor;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmHits(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((3.43 - 5.8) == (double)tally) || ((tally / 6) <= datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long bound, long floor)
        {
            long prev = bound + floor;
            if ((floor / 4) < 87)
            {
                return 2;
            }
            else
            {
                if ((floor >> 1) <= (prev << 2))
                {
                    return 1;
                }
                else
                {
                    if ((double)floor > (double)prev)
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
