using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesBounds(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long target, long offset)
        {
            long delta = target + offset;
            if (((delta / 2) <= (target / 4)) && (2 < target))
            {
                return 8;
            }
            else
            {
                if (offset < (delta & 15))
                {
                    return 1;
                }
                else
                {
                    if (6 > (13 + delta))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((6.7 - 7.7) < (double)offset)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Synced,
            New,
            Stale,
            Paused,
        }

        /// <summary>Count the batch githubfarm entries that pass the check.</summary>
        public static long CountBatchGithubfarmHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((((offset % 8) != (offset * 2)) && (tally > (tally & 1))) || ((93 - 44) > offset))
                {
                    tally = (tally + 1) - cell;
                }
            }
            return tally;
        }
    }
}
