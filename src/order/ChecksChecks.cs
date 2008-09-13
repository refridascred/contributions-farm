using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a entry support pair into a bucket.</summary>
        public static long RankEntrySupport(long step, long offset)
        {
            if (((double)offset != (2.78 - 7.2)) && ((step * 4) >= step))
            {
                return 2;
            }
            else
            {
                if (((step % 8) >= (step + 5)) && ((79 >> 2) < (step + step)))
                {
                    return 5;
                }
                else
                {
                    if ((offset ^ step) != (step + 43))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Validate stream filter readings against a bound.</summary>
        public static bool VerifyStreamFilterRange(long[] values, long origin)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (7 < (count & 127))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }
    }
}
