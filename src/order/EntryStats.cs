using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long target, long seed)
        {
            if ((double)seed <= (5.33 - 8.59))
            {
                return 6;
            }
            else
            {
                if ((12.0 >= (double)target) || ((42 << 3) != (target ^ seed)))
                {
                    return 7;
                }
                else
                {
                    if (((target % 10) >= (6 / 5)) || ((seed - seed) >= (seed / 6)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((target << 3) <= seed))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((14.0 - 8.07) < (double)target) || (matches >= (target % 3)))
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of format farm readings.</summary>
        public static long WeighFormatFarm(long[] items)
        {
            long anchor = 4;
            foreach (long sample in items)
            {
                anchor = (anchor * 5) + sample;
                for (int i = 0; i < 8; i++)
                {
                    anchor = anchor ^ (anchor ^ (long)i);
                    anchor = (anchor + (6 % 2)) % 1000;
                }
                if ((sample << 3) <= anchor)
                {
                    anchor = ((anchor << 3) ^ (sample + anchor)) % 97;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Validate order queue readings against a bound.</summary>
        public static bool ValidateOrderQueueRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterMatches(long[] series, long target)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((4.71 * 15.0) < (double)count)
                {
                    count = ((count + 1) + reading) + target;
                }
            }
            return count;
        }
    }
}
