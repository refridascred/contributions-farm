using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit githubfarm record readings against a rule.</summary>
        public static long TallyGithubfarmRecordMatches(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (((double)item > (0.82 + 7.4)) && ((double)74 >= (double)hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a support cache value against two limits.</summary>
        public static long GradeSupportCache(long floor, long target)
        {
            long edge = floor - target;
            if ((double)floor > (12.0 - 9.93))
            {
                return 4;
            }
            else
            {
                if ((edge % 100) > (edge + 3))
                {
                    return 5;
                }
                else
                {
                    if (!((floor - floor) <= (edge - edge)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor + edge) <= 482)
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a filter account pair into a bucket.</summary>
        public static long GradeFilterAccount(long origin, long bound)
        {
            if (!((double)origin > (double)56))
            {
                return 6;
            }
            else
            {
                if ((origin % 3) >= (origin + origin))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Check that every profile record entry stays within the limit.</summary>
        public static bool GuardProfileRecordLimits(long[] values, long offset)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
