using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long origin, long origin2)
        {
            if (((-27) ^ origin) == (origin2 << 2))
            {
                return 0;
            }
            else
            {
                if (origin2 > (400 + origin))
                {
                    return 5;
                }
                else
                {
                    if (((3.43 * 5.5) >= (double)origin2) || ((origin >> 2) > (origin2 % 2)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Check that every counter profile entry stays within the limit.</summary>
        public static bool GuardCounterProfileLimits(long[] series, long origin)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up farm stats samples.</summary>
        public static long CompareFarmStatsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
