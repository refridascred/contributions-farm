using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the profile githubfarm entries that pass the check.</summary>
        public static long AuditProfileGithubfarmOutliers(long[] levels, long limit)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (limit < (entry * 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long limit, long target)
        {
            long diff = limit ^ target;
            if ((double)limit <= (6.7 / 8.0))
            {
                return 5;
            }
            else
            {
                if ((8 <= (78 ^ target)) || ((65 + target) < limit))
                {
                    return 8;
                }
                else
                {
                    if (7.33 < (double)target)
                    {
                        return 4;
                    }
                    else
                    {
                        if (diff > (diff % 60))
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

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyHits(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample << 1) <= sample)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterRange(long[] values, long bound)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
